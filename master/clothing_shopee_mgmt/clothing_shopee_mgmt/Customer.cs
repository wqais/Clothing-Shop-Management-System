using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class Customer : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        DataTable dt;
        OleDbDataAdapter da;
        string constring;
        public Customer()
        {
            InitializeComponent();
            Display();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet3.customersDb' table. You can move, or remove it, as needed.
            //this.customersDbTableAdapter.Fill(this.shopDbDataSet3.customersDb);

        }

        public void Display()
        {
            dt = new DataTable();
            constring = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
            var conn = new OleDbConnection(constring);
            conn.Open();
            var da = new OleDbDataAdapter("select * from customersDb", conn);
            da.Fill(dt);
            custDt.DataSource = dt;
            conn.Close();
        }

        public void Search()
        {
            try
            {
                var dt = new DataTable();
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                da = new OleDbDataAdapter("select * from customersDb where Cust_ID like '" + searchTxt.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                custDt.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpage = new Login();
            loginpage.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addCust addCust = new addCust();
            addCust.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateCust updatecust = new updateCust();
            updatecust.Show();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
