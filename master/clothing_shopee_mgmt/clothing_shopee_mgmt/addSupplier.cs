using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class addSupplier : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public addSupplier()
        {
            InitializeComponent();
        }

        public void clearTxt()
        {
            sidTxt.Text = "";
            snameTxt.Text = "";
            semailTxt.Text = "";
            sphnoTxt.Text = "";
            saddrTxt.Text = "";
            suplTypeTxt.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sid = sidTxt.Text;
                string sname = snameTxt.Text;
                string semail = semailTxt.Text;
                string sphno = sphnoTxt.Text;
                string saddr = saddrTxt.Text;
                string stype = suplTypeTxt.Text;
                string cmdText = "INSERT into supplierDb (Supl_ID, Supl_Name, Supl_Email, Supl_PhNo, Supl_Addr, Supl_Type) values('" +sid + "','" + sname + "','" + semail + "','" + sphno + "', '" + saddr + "', '" + stype + "') ";
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
                if(sid == ""|| sname == ""|| semail == "" || sphno == "" || saddr == "" || stype == "")
                {
                    MessageBox.Show("Empty fields detected. Make sure that you fill all the details");
                }
                else
                {
                    if(Regex.Match(snameTxt.Text, "^[A-Z][a-zA-Z]*$").Success)
                    {
                        if(Regex.Match(sphnoTxt.Text, @"^[0-9]{10}$").Success)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Entry successful");
                            con.Close();
                            clearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Phone number should contain 10 digits");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name should not contain special characters and first letter should be Capital.");
                    }
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
    }
}
