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
    public partial class Pay : Form
    {
        BaitaplonDataContext data = new BaitaplonDataContext();
        public Pay()
        {
            InitializeComponent();
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thanh toán " + txtOrder.Text + "\nTổng tiền: " + txtTotal.Text + " VNĐ", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (ms == DialogResult.Yes)
            {
                MessageBox.Show("Đã thanh toán " + txtOrder.Text, "Xong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (ms == DialogResult.No)
            {
                this.Close();
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = from ord in data.OrderDetails.Where(o => o.OrderId.Contains(txtOrder.Text))
                         join or in data.Orders on ord.OrderId equals or.OrderId
                         join pro in data.Products on ord.ProductId equals pro.ProductId
                         select new {
                             OrderId = or.OrderId,
                             ProductId = pro.ProductName,
                             Size = ord.Size,
                             Quantity = ord.Quantity,
                             Discount = ord.Discount,
                             Price = (pro.Price * ord.Quantity) - (pro.Price * ord.Quantity * ord.Discount / 100)
                         };
            pntBill.DataSource = result.ToList();
            
            int sc = pntBill.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc; i++)
                thanhtien += float.Parse(pntBill.Rows[i].Cells["Price"].Value.ToString());
            txtTotal.Text = thanhtien.ToString();
        }

        private void gpbBill_Enter(object sender, EventArgs e)
        {

        }

        private void txtTotal_Click(object sender, EventArgs e) 

        {
            int sc = pntBill.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc; i++)
            thanhtien += float.Parse(pntBill.Rows[i].Cells["Price"].Value.ToString());
            txtTotal.Text = thanhtien.ToString();
        }
    }
}
