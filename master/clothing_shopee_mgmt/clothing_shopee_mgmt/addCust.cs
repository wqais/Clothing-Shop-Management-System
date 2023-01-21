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
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace clothing_shopee_mgmt
{
    public partial class addCust : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public addCust()
        {
            InitializeComponent();
        }

        public void clearTxt()
        {
            nameTxt.Text = "";
            idTxt.Text = "";
            emailTxt.Text = "";
            phnoTxt.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idTxt.Text;
                string name = nameTxt.Text;
                string email = emailTxt.Text;
                string phno = phnoTxt.Text;
                string regDate = DateTime.Now.ToString("dd/MM/yyyy");
                string cmdText = "INSERT into customersDb (Cust_ID, Cust_Name, Cust_Reg_Date, Cust_PhNo, Cust_Email) values('" + id + "','" + name + "','" + regDate + "', '" + phno + "', '" + email + "') ";
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
                if (id == "" || name == "" || email == "" || phno == "")
                {
                    MessageBox.Show("Empty fields found. Make sure that you enter all the details.");
                }
                else
                {
                    if (Regex.Match(phnoTxt.Text, @"^[0-9]{10}$").Success)
                    {
                        if (Regex.Match(nameTxt.Text, "^[A-Z][a-zA-Z]*$").Success)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Entry successful");
                            con.Close();
                            clearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Name should not contain special characters and first letter should be capital");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number should contain 10 digits.");
                    }
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
    }
}
