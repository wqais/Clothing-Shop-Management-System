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
    public partial class addEmp : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public addEmp()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string eid = eidTxt.Text;
                string ename = enameTxt.Text;
                string eemail = eemailTxt.Text;
                string ephno = ephnoTxt.Text;
                string eaddr = eaddrTxt.Text;
                string role = this.roleCb.GetItemText(this.roleCb.SelectedItem);
                string edoj = dojPicker.Value.ToShortDateString();
                string cmdText = "INSERT into employeeDb (E_ID, E_Role, E_Name, E_Email, E_Phno, E_Addr, E_DOJ) values('" + eid + "', '" + role + "','" + ename + "','" + eemail + "','" + ephno + "', '" + eaddr + "', '" + edoj + "') ";
                string payCmd = "insert into payrollDb (E_ID, E_Name, E_Role) values('" + eid + "', '" + ename + "', '" + role + "')";
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
                OleDbCommand cmd2 = new OleDbCommand
                {
                    Connection = con,
                    CommandText = payCmd
                };
                if(eid == "" || ename == "" || eemail == "" || ephno == "" || eaddr == "")
                {
                    MessageBox.Show("Empty fields detected. Make sure that you enter all details.");
                }
                else
                {
                    if (Regex.Match(enameTxt.Text, "^[A-Z][a-zA-Z]*$").Success)
                    {
                        if (Regex.Match(ephnoTxt.Text, @"^[0-9]{10}$").Success)
                        {
                            cmd.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Entry successful");
                            con.Close();
                            eidTxt.Text = "";
                            enameTxt.Text = "";
                            eemailTxt.Text = "";
                            ephnoTxt.Text = "";
                            eaddrTxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Phone number should contain 10 digits");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name should not contain special characters and first letter should be capital.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void clearBtn_Click(object sender, EventArgs e)
        {
            eidTxt.Text = "";
            enameTxt.Text = "";
            eemailTxt.Text = "";
            ephnoTxt.Text = "";
            eaddrTxt.Text = "";
        }
    }
}
