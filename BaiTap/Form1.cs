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
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCategory addCat = new addCategory();
            addCat.MdiParent = this;
            addCat.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct addpro = new addProduct();
            addpro.MdiParent = this;
            addpro.Show();
        }

        private void orderOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOrders addOn = new addOrders();
            addOn.MdiParent = this;
            addOn.Show();
        }

        private void orderOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOrderDetail addOff = new addOrderDetail();
            addOff.MdiParent = this;
            addOff.Show();
            
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDepartment addDep = new addDepartment();
            addDep.MdiParent = this;
            addDep.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEmployee addEmp = new addEmployee();
            addEmp.MdiParent = this;
            addEmp.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer addCus = new addCustomer();
            addCus.MdiParent = this;
            addCus.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay addPay = new Pay();
            addPay.MdiParent = this;
            addPay.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
