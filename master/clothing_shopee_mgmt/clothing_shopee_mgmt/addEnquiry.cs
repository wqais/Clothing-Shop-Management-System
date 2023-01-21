using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class addEnquiry : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public addEnquiry()
        {
            InitializeComponent();
        }

        public void clearTxt()
        {
            idTxt.Text = "";
            enqIDTxt.Text = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cust_id = idTxt.Text;
                string enq_id = enqIDTxt.Text;
                string enq_type = this.typeCb.GetItemText(this.typeCb.SelectedItem);
                string status = "Open";
                string cmdText = "insert into enquiryDb (Enq_ID, Cust_ID, Enquiry_Subject, Ticket_Status) values ('" + enq_id + "', '" + cust_id + "', '" + enq_type + "', '" + status + "')";
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
                if (cust_id == "" || enq_id == "" || enq_type == "")
                {
                    MessageBox.Show("Empty fields detected. Make sure you fill all the details.");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry successful");
                    con.Close();
                    clearTxt();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
