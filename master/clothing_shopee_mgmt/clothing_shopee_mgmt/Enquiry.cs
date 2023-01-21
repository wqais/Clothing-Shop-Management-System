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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace clothing_shopee_mgmt
{
    public partial class Enquiry : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        string constring;
        string enq_id;
        public Enquiry()
        {
            InitializeComponent();
            Display();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        public void Display()
        {
            dt = new DataTable();
            constring = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
            var conn = new OleDbConnection(constring);
            conn.Open();
            var da = new OleDbDataAdapter("select * from enquiryDb", conn);
            da.Fill(dt);
            enqDt.DataSource = dt;
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
                da = new OleDbDataAdapter("select * from enquiryDb where Enq_ID like '" + searchTxt.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                enqDt.DataSource = dt;
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully. Returning you to login page.");
            this.Close();
            Login loginpage = new Login();
            loginpage.Show();
        }

        private void Enquiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet4.enquiryDb' table. You can move, or remove it, as needed.
            this.enquiryDbTableAdapter.Fill(this.shopDbDataSet4.enquiryDb);

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void enqDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curRow = enqDt.CurrentCell.RowIndex;
            enq_id = enqDt.Rows[curRow].Cells[0].Value.ToString();
            closeBtn.Enabled = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "Closed";
                string cmdText = "UPDATE enquiryDb SET Ticket_Status = '" + status + "' where Enq_ID = '" + enq_id + "'";
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                cmd = new OleDbCommand
                {
                    Connection = con,
                    CommandText = cmdText
                };
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket Closed Successfully");
                con.Close();
                Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEnquiry addenquiry = new addEnquiry();
            addenquiry.Show();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
