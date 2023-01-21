using System;
using System.Data;
using System.Data.OleDb;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class Employee : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        string constring = null;
        string eid;
        DataTable dt;
        public Employee()
        {
            InitializeComponent();
        }
        public void Display()
        {
            dt = new DataTable();
            constring = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
            var conn = new OleDbConnection(constring);
            conn.Open();
            var da = new OleDbDataAdapter("select * from employeeDb", conn);
            da.Fill(dt);
            empDt.DataSource = dt;
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
                da = new OleDbDataAdapter("select * from employeeDb where E_ID like '" + searchTxt.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                empDt.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            addEmp addEmpPage = new addEmp();
            addEmpPage.Show();
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

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet4.employeeDb' table. You can move, or remove it, as needed.
            this.employeeDbTableAdapter1.Fill(this.shopDbDataSet4.employeeDb);
            Display();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void empDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curRow = empDt.CurrentCell.RowIndex;
            eid = empDt.Rows[curRow].Cells[0].Value.ToString();
            removeEmpBtn.Enabled = true;
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "DELETE from employeeDb where E_ID = '" + eid + "'";
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
                MessageBox.Show("Removed Employee Successfully.");
                con.Close();
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void updatEmpBtn_Click(object sender, EventArgs e)
        {
            updateEmp updEmp = new updateEmp();
            updEmp.Show();
        }
    }
}
