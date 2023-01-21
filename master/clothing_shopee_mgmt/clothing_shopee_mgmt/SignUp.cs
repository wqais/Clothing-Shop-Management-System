using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace clothing_shopee_mgmt
{
    public partial class SignUp : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public SignUp()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            conPassTxt.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string aid = aIdTxt.Text;
                string username = usernameTxt.Text;
                string pass = passwordTxt.Text;
                string conPass = conPassTxt.Text;
                string email = emailTxt.Text;
                string name = nameTxt.Text;
                string cmdText = "INSERT into loginDb (A_ID, Name, Username, [Password], Email) values('" + aid + "', '" + name + "', '" + username + "','" + pass + "', '" + email + "') ";
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
                if (nameTxt.Text == "" || aIdTxt.Text == "" || usernameTxt.Text == "" || passwordTxt.Text == "" || conPassTxt.Text == "" || emailTxt.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {
                    if (Regex.Match(nameTxt.Text, "^[A-Z][a-zA-Z]*$").Success)
                    {
                        if (conPass == pass)
                        {
                            if (pass.Length < 8)
                            {
                                MessageBox.Show("Password should contain at least 8 characters.");
                            }
                            else
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Entry successful");
                                aIdTxt.Text = "";
                                usernameTxt.Text = "";
                                passwordTxt.Text = "";
                                conPassTxt.Text = "";
                                emailTxt.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords don't match, try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name cannot contain special characters and first letter must be Capital");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
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
