using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dateUpdate_Tick(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timeUpdate_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToString("hh/mm/ss");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully. Returning you to login page.");
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventoryPage = new Inventory();
            inventoryPage.Show();
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier suppliersPage = new Supplier();
            suppliersPage.Show();
        }

        private void empMgmtBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employeePage = new Employee();
            employeePage.Show();
        }

        private void billingBtn_Click(object sender, EventArgs e)
        {
            addBill billingPage = new addBill();
            billingPage.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile currProfile = new Profile();
            currProfile.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customerPage = new Customer();
            customerPage.Show();
            this.Close();
        }

        private void enquiriesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enquiry enquirypage = new Enquiry();
            enquirypage.Show();
            this.Close();
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payroll payrollPage = new Payroll();
            payrollPage.Show();
            this.Close();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report salesReport = new Report();
            salesReport.Show();
            this.Close();
        }
    }
}
