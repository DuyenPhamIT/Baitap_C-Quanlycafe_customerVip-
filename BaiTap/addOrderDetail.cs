using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class addOrderDetail : Form
    {
        BaitaplonDataContext data = new BaitaplonDataContext();
        public addOrderDetail()
        {
            InitializeComponent();
        }
        private void btnNew_Click(object sender, EventArgs e)
        { 
            OrderDetail ord = new OrderDetail();
            ord.OrderId = cboId.SelectedValue.ToString();
            ord.ProductId = int.Parse(cboProduct.SelectedValue.ToString());
            ord.Size = cboSize.SelectedItem.ToString();
            ord.Quantity =int.Parse(numQuantity.Value.ToString());
            ord.Discount =Convert.ToDouble(txtDis.Text);
            ord.NodeCustom = rchNote.Text;
            data.OrderDetails.InsertOnSubmit(ord);
            data.SubmitChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDis.Text = null;
            rchNote.Text = null;
            LoadOrderDetail();
        }

        private void addOrderDetail_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadOrder();
            LoadOrderDetail();
        }

        private void LoadProduct()
        {
            var dataProduct = from pro in data.Products
                              select new
                              {
                                  ProductId = pro.ProductId,
                                  ProductName = pro.ProductName
                              };
            cboProduct.DataSource = dataProduct.ToList();
            cboProduct.DisplayMember = "ProductName";
            cboProduct.ValueMember = "ProductId";
        }

        private void LoadOrder()
        {
            var dataOrder = from or in data.Orders
                            select new
                            {
                                OrderId = or.OrderId
                            };
            cboId.DataSource = dataOrder.ToList();
            cboId.DisplayMember = "OrderId";
            cboId.ValueMember = "OrderId";
        }

        private void LoadOrderDetail()
        {
            var dataOrderDetail = from ord in data.OrderDetails join or in data.Orders on ord.OrderId equals or.OrderId
                                  join pro in data.Products on ord.ProductId equals pro.ProductId
                                  select new
                                  {
                                      STT = ord.STT,
                                      OrderId = or.OrderId,
                                      ProductId = pro.ProductName,
                                      Size = ord.Size,
                                      Quantity = ord.Quantity,
                                      Discount = ord.Discount,
                                      Price = pro.Price*ord.Quantity-(pro.Price*ord.Quantity*ord.Discount/100),
                                      OrderDate = or.OrderDate,
                                      RequiredDate = or.RequiredDate,
                                      NoteCustomer = ord.NodeCustom,
                                  };
            dgvOrderDetail.DataSource = dataOrderDetail.ToList();
            LoadOrder();
            LoadProduct();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvOrderDetail.CurrentRow.Cells[0].Value.ToString());
            OrderDetail ord = data.OrderDetails.Single(p => p.STT.Equals(id));
            ord.OrderId = cboId.SelectedValue.ToString();
            ord.ProductId = int.Parse(cboProduct.SelectedValue.ToString());
            ord.Size = cboSize.SelectedItem.ToString();
            ord.Quantity = int.Parse(numQuantity.Value.ToString());
            ord.Discount = Convert.ToDouble(txtDis.Text);
            ord.NodeCustom = rchNote.Text;
            data.SubmitChanges();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDis.Text = null;
            rchNote.Text = null;
            LoadOrderDetail();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Bạn có muốn xóa không", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.dgvOrderDetail.CurrentRow.Cells[0].Value.ToString());
                    OrderDetail ord = data.OrderDetails.Single(p => p.STT.Equals(id));
                    data.OrderDetails.DeleteOnSubmit(ord);
                    data.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrderDetail();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn không thể xóa được bản ghi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    
        private void dgvOrderDetail_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvOrderDetail.CurrentRow.Cells[0].Value.ToString());
            OrderDetail ord = data.OrderDetails.Single(p => p.STT.Equals(id));
            cboId.SelectedValue = ord.OrderId;
            cboProduct.SelectedValue = ord.ProductId;
            cboSize.SelectedItem = ord.Size;
            numQuantity.Value = (decimal)ord.Quantity;
            txtDis.Text = ord.Discount.ToString();
            rchNote.Text = ord.NodeCustom;
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
