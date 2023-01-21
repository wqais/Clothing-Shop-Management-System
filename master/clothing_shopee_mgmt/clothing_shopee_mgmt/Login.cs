using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace clothing_shopee_mgmt
{
    public partial class Login : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        string login_aID;
        public Login()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            dateUpdate.Start();
            timeUpdate.Start();
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void logintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTxt.Text;
                string pass = passwordTxt.Text;
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM loginDb where Username='" + username + "' AND Password='" + pass + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successful");
                    con.Close();
                    con.Dispose();
                    this.Hide();
                    Home homepage = new Home();
                    homepage.Show();
                }
                else
                {
                    if (String.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Username field cannot be empty!");
                    }
                    else if (String.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Password field cannot be empty!");
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");
                    }
                }

                /*OleDbCommand aidCmd = new OleDbCommand();
                aidCmd.Connection = con;
                aidCmd.CommandText = "Select Name from loginDb where Password ='" + pass + "'";
                login_aID = (string)cmd.ExecuteScalar();
                Profile admin_Profile = new Profile(login_aID);*/

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timeUpdate_Tick(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timeUpdate_Tick_1(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToString("hh/mm/ss");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            usernameTxt.Text = "";
            passwordTxt.Text = "";
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void showPasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordChk.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp reg = new SignUp();
            reg.Show();
        }
    }
}
