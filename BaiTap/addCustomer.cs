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
    public partial class addCustomer : Form
    {
        BaitaplonDataContext data = new BaitaplonDataContext();
        bool edit = true;
        public addCustomer()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(txtMa.Text == "")
            {
                MessageBox.Show("Không được để trống mã ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Không được để trống tên ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Không được để trống số điện thoại ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Không được để trống địa chỉ ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPhone.Text.Length==10 && txtPhone.Text.StartsWith("09") || txtPhone.Text.StartsWith("03") && txtName.Text.Length>0 && txtMa.Text.Length>0 && txtAddress.Text.Length>0)
            {
                Customer cu = new Customer();
                cu.CustomerId = txtMa.Text;
                cu.ContactName = txtName.Text;
                cu.Address = txtAddress.Text;
                cu.Phone = txtPhone.Text;
                data.Customers.InsertOnSubmit(cu);
                data.SubmitChanges();
                txtAddress.Text = txtMa.Text = txtName.Text = txtPhone.Text = "";
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomer();
            }
            txtAddress.Text = null;
            txtMa.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            var datacus = from cus in data.Customers
                          select new
                          {
                              CustomerId = cus.CustomerId,
                              ContactName = cus.ContactName,
                              Address = cus.Address,
                              Phone = cus.Phone
                          };
            dgvCustomer.DataSource = datacus.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Bạn có muốn xóa không", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string ma = this.dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                    Customer cus = data.Customers.Single(cu => cu.CustomerId.Equals(ma));
                    data.Customers.DeleteOnSubmit(cus);
                    data.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomer();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn không thể xóa được bản ghi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Không được để trống mã ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Không được để trống tên ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Không được để trống số điện thoại ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Không được để trống địa chỉ ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPhone.Text.Length == 10 && txtPhone.Text.StartsWith("09") || txtPhone.Text.StartsWith("03") && txtName.Text.Length > 0 && txtMa.Text.Length > 0 && txtAddress.Text.Length > 0)
            {
                string ma = this.dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                Customer cus = data.Customers.Single(cu => cu.CustomerId.Contains(ma));
                txtMa.ReadOnly = true;
                cus.ContactName = txtName.Text;
                cus.Address = txtAddress.Text;
                cus.Phone = txtPhone.Text;
                data.SubmitChanges();
                txtAddress.Text = txtMa.Text = txtName.Text = txtPhone.Text = "";
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomer();
            }
                
            txtAddress.Text = null;
            txtMa.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            

        }


        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            string ma = this.dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            Customer cus = data.Customers.Single(cu => cu.CustomerId.Equals(ma));
            txtMa.Text = cus.CustomerId;
            txtName.Text = cus.ContactName;
            txtAddress.Text = cus.Address;
            txtPhone.Text = cus.Phone;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = from s in data.Customers.Where(cus => cus.ContactName.Contains(txtSearch.Text)) select s;
            dgvCustomer.DataSource = result;
        }
    }
}
