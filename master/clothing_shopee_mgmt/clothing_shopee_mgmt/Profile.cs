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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            //adminIDLbl.Text = "Hello " +login_aID;
            passwordTxt.UseSystemPasswordChar = true;
            conPassTxt.UseSystemPasswordChar = true;
        }

        OleDbConnection con;
        OleDbCommand cmd;
        string init_name;
        string init_username;
        string init_password;
        string init_email;

        private void clearTxt()
        {
            nameTxt.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            conPassTxt.Text = "";
            emailTxt.Text = "";
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
            MessageBox.Show("Logged Out Successfuly. Returning you to the home page.");
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(conPassTxt.Text != "")
                {
                    if (conPassTxt.Text.Length > 7)
                    {
                        if (conPassTxt.Text == passwordTxt.Text)
                        {
                            string aid = adminIDTxt.Text;
                            string name = nameTxt.Text;
                            string email = emailTxt.Text;
                            string username = usernameTxt.Text;
                            string pass = passwordTxt.Text;
                            string cmdText = "UPDATE loginDb SET Name = '" + name + "', Email = '" + email + "', Username = '" + username + "', [Password] = '" + pass + "' WHERE A_ID = '" + aid + "'";
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
                            MessageBox.Show("Edited Admin Details Successfully");
                            con.Close();
                            clearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Passwords don't match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password length should be at least 8 characters.");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password field cannot be empty!");
                    conPassTxt.Focus();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string aid = adminIDTxt.Text;
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                string cmdStr = "Select count(*) from loginDb where A_ID = '" + aid + "'"; //get the existence of the record as count 

                OleDbCommand cmd = new OleDbCommand(cmdStr, con);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Record Found! Insert new details.");
                    admDetails.Visible = true;
                    cmdStr = "Select Name from loginDb where A_ID = '" + aid + "'";
                    OleDbCommand enamecmd = new OleDbCommand(cmdStr, con);
                    init_name = (string)enamecmd.ExecuteScalar();
                    nameTxt.Text = init_name;
                    cmdStr = "Select Username from loginDb where A_ID = '" + aid + "'";
                    OleDbCommand usernamecmd = new OleDbCommand(cmdStr, con);
                    init_username = (string)usernamecmd.ExecuteScalar();
                    usernameTxt.Text = init_username;
                    cmdStr = "Select [Password] from loginDb where A_ID = '" + aid + "'";
                    OleDbCommand emailcmd = new OleDbCommand(cmdStr, con);
                    init_password = (string)emailcmd.ExecuteScalar(); ;
                    passwordTxt.Text = init_password;
                    cmdStr = "Select Email from loginDb where A_ID = '" + aid + "'";
                    OleDbCommand phnocmd = new OleDbCommand(cmdStr, con);
                    init_email = (string)phnocmd.ExecuteScalar();
                    emailTxt.Text = init_email;
                    con.Close();
                    deleteBtn.Visible = true;
                }
                else if (count == 0)
                {
                    MessageBox.Show("No results found for Admin ID: " + aid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conPassTxt.UseSystemPasswordChar == false){
                conPassTxt.UseSystemPasswordChar = true;
            }
            else
            {
                conPassTxt.UseSystemPasswordChar = false;
            }
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if(passwordTxt.UseSystemPasswordChar == false)
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string aid = adminIDTxt.Text;
            try
            {
                string cmdText = "DELETE from loginDb where A_ID = '" + aid + "'";
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
                MessageBox.Show("Removed Admin Successfully.");
                con.Close();
                clearTxt();
                adminIDTxt.Text = "";
                //Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
