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
    public partial class updateCust : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string init_name;
        string init_email;
        string init_phno;
        public updateCust()
        {
            InitializeComponent();
        }

        public void clearTxt()
        {
            nameTxt.Text = "";
            emailTxt.Text = "";
            phnoTxt.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idTxt.Text;
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                string cmdStr = "Select count(*) from customersDb where Cust_ID = '" + id + "'"; //get the existence of the record as count 

                OleDbCommand cmd = new OleDbCommand(cmdStr, con);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Record Found! Insert new details.");
                    updateEmpForm.Visible = true;
                    cmdStr = "Select Cust_Name from customersDb where Cust_ID = '" + id + "'";
                    OleDbCommand enamecmd = new OleDbCommand(cmdStr, con);
                    init_name = (string)enamecmd.ExecuteScalar();
                    nameTxt.Text = init_name;
                    cmdStr = "Select Cust_Email from customersDb where Cust_ID = '" + id + "'";
                    OleDbCommand emailcmd = new OleDbCommand(cmdStr, con);
                    init_email = (string)emailcmd.ExecuteScalar();
                    emailTxt.Text = init_email;
                    cmdStr = "Select Cust_PhNo from customersDb where Cust_ID = '" + id + "'";
                    OleDbCommand phnocmd = new OleDbCommand(cmdStr, con);
                    init_phno = (string)phnocmd.ExecuteScalar();
                    phnoTxt.Text = init_phno;
                    con.Close();
                }
                else if (count == 0)
                {
                    MessageBox.Show("No results found for Customer ID: " + id);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idTxt.Text;
                string name = nameTxt.Text;
                string email = emailTxt.Text;
                string phno = phnoTxt.Text;
                string cmdText = "UPDATE customersDb SET Cust_Name = '" + name + "', Cust_Email = '" + email + "', Cust_PhNo = '" + phno + "' where Cust_ID = '" + id + "'";
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
                MessageBox.Show("Edited Customer Successfully");
                con.Close();
                clearTxt();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
