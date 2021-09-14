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
    public partial class addOrders : Form
    {
        BaitaplonDataContext data = new BaitaplonDataContext();
        public addOrders()
        {
            InitializeComponent();
        }

        private void addOrders_Load(object sender, EventArgs e)
        {
            LoadOrder();
            LoadCustomer();
            LoadEmployee();
        }

        private void LoadOrder()
        {
            var dataord = from or in data.Orders 
                          join cus in data.Customers on or.CustomerId equals cus.CustomerId 
                          join emp in data.Employees on or.EmployeeId equals emp.EmployeeId
                          select new
                          {
                              OrderId = or.OrderId,
                              CustomerName = cus.ContactName,
                              EmployeeOrder = emp.Name,
                              OrderDate = or.OrderDate,
                              RequiredDate = or.RequiredDate,
                          };
            dgvOrder.DataSource = dataord.ToList();
        }

        private void LoadCustomer()
        {
            var dataCus = from cus in data.Customers
                          select new
                          {
                              CustomerId = cus.CustomerId,
                              ContactName = cus.ContactName
                          };
            cboCustomer.DataSource = dataCus;
            cboCustomer.DisplayMember = "ContactName";
            cboCustomer.ValueMember = "CustomerId";
        }

        private void LoadEmployee()
        {
            var dataEmp = from emp in data.Employees
                          select new
                          {
                              EmployeeId = emp.EmployeeId,
                              Name = emp.Name
                          };
            cboEmployee.DataSource = dataEmp;
            cboEmployee.DisplayMember = "Name";
            cboEmployee.ValueMember = "EmployeeId";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Không được để trống mã Order ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtId.Text.Length > 0)
            {
                Order or = new Order();
                or.OrderId = txtId.Text;
                or.CustomerId = cboCustomer.SelectedValue.ToString();
                or.EmployeeId = cboEmployee.SelectedValue.ToString();
                or.OrderDate = dateOrder.Value;
                or.RequiredDate = dateRequire.Value;
                data.Orders.InsertOnSubmit(or);
                data.SubmitChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtId.Text = null;
            rchOrder.Text = null;
            LoadOrder();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Không được để trống mã Order ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtId.Text.Length > 0)
            {
                string ma = this.dgvOrder.CurrentRow.Cells[0].Value.ToString();
                Order or = data.Orders.Single(O => O.OrderId.Contains(ma));
                txtId.ReadOnly = true;
                or.CustomerId = cboCustomer.SelectedValue.ToString();
                or.EmployeeId = cboEmployee.SelectedValue.ToString();
                or.OrderDate = dateOrder.Value;
                or.RequiredDate = dateRequire.Value;
                data.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtId.Text = null;
            rchOrder.Text = null;
            LoadOrder();
            

        }

        private void dgvOrder_Click(object sender, EventArgs e)
        {
            string ma = this.dgvOrder.CurrentRow.Cells[0].Value.ToString();
            Order or = data.Orders.Single(O => O.OrderId.Contains(ma));
            txtId.Text = or.OrderId;
            cboCustomer.SelectedValue = or.CustomerId;
            cboEmployee.SelectedValue = or.EmployeeId;
            dateOrder.Value = (DateTime)or.OrderDate;
            dateRequire.Value = (DateTime)or.RequiredDate;
        }
    }
}
