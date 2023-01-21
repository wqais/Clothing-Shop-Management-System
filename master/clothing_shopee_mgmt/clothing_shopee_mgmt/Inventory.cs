using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class Inventory : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string pid;
        string constring = null;
        DataTable dt;
        OleDbDataAdapter da;

        public Inventory()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            dt = new DataTable();
            constring = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
            var conn = new OleDbConnection(constring);
            conn.Open();
            var da = new OleDbDataAdapter("select * from inventoryDb", conn);
            da.Fill(dt);
            productDt.DataSource = dt;
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
                da = new OleDbDataAdapter("select * from inventoryDb where Prod_ID like '" + searchTxt.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                productDt.DataSource = dt;
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully. Returning you to login page.");
            this.Close();
            Login loginpage = new Login();
            loginpage.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet3.inventoryDb' table. You can move, or remove it, as needed.
            //this.inventoryDbTableAdapter1.Fill(this.shopDbDataSet3.inventoryDb);
            // TODO: This line of code loads data into the 'shopDbDataSet2.inventoryDb' table. You can move, or remove it, as needed.
            //this.inventoryDbTableAdapter.Fill(this.shopDbDataSet2.inventoryDb);

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            addProd newProd = new addProd();
            newProd.Show();
        }

        private void reqRefillBtn_Click(object sender, EventArgs e)
        {
            //void
        }

        private void productDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curRow = productDt.CurrentCell.RowIndex;
            pid = productDt.Rows[curRow].Cells[0].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "DELETE from inventoryDb where Prod_ID = '" + pid + "'";
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                cmd = new OleDbCommand
                {
                    Connection = con,
                    CommandText = cmdText
                };
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed Product Successfully.");
                con.Close();
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateProd updateProd = new updateProd();
            updateProd.Show();
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
