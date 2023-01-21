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
    public partial class Supplier : Form
    {
        string constring;
        string sid;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        public Supplier()
        {
            InitializeComponent();
            Display();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet2.supplierDb' table. You can move, or remove it, as needed.
            //this.supplierDbTableAdapter1.Fill(this.shopDbDataSet2.supplierDb);

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
                da = new OleDbDataAdapter("select * from supplierDb where Supl_ID like '" + searchTxt.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                suplDt.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Display()
        {
            var dt = new DataTable();
            var da = new OleDbDataAdapter();
            constring = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
            var conn = new OleDbConnection(constring);
            conn.Open();
            da = new OleDbDataAdapter("select * from supplierDb", conn);
            da.Fill(dt);
            suplDt.DataSource = dt;
            conn.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homepage = new Home();
            homepage.Show();
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

        private void addSuplBtn_Click(object sender, EventArgs e)
        {
            addSupplier addSupplierPage = new addSupplier();
            addSupplierPage.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void suplDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curRow = suplDt.CurrentCell.RowIndex;
            sid = suplDt.Rows[curRow].Cells[0].Value.ToString();
            removeSuplBtn.Enabled = true;
        }

        private void removeSuplBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "DELETE from supplierDb where Supl_ID = '" + sid + "'";
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
                MessageBox.Show("Removed Supplier Successfully.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateSuplBtn_Click(object sender, EventArgs e)
        {
            updateSupl updSupl = new updateSupl();
            updSupl.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
    }
}
