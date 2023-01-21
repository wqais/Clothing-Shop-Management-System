using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothing_shopee_mgmt
{
    public partial class updateSupl : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string init_name;
        string init_addr;
        string init_phno;
        string init_email;
        string init_type;
        public updateSupl()
        {
            InitializeComponent();
        }

        public void clearTextFields()
        {
            sidTxt.Text = "";
            sidTxt.Text = "";
            snameTxt.Text = "";
            semailTxt.Text = "";
            sphnoTxt.Text = "";
            stypeTxt.Text = "";
            saddrTxt.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sid = sidTxt.Text;
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                string cmdStr = "Select count(*) from supplierDb where Supl_ID = '" + sid + "'"; //get the existence of the record as count 

                OleDbCommand cmd = new OleDbCommand(cmdStr, con);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Record Found! Insert new details.");
                    updateSuplForm.Visible = true;
                    cmdStr = "Select Supl_Name from supplierDb where Supl_ID='" +sid+ "'";
                    OleDbCommand snamecmd = new OleDbCommand(cmdStr, con);
                    init_name = (string)snamecmd.ExecuteScalar();
                    snameTxt.Text = init_name;
                    cmdStr = "Select Supl_PhNo from supplierDb where Supl_ID='" +sid+ "'";
                    OleDbCommand phnocmd = new OleDbCommand(cmdStr, con);
                    init_phno = (string)phnocmd.ExecuteScalar();
                    sphnoTxt.Text = init_phno;
                    cmdStr = "Select Supl_Addr from supplierDb where Supl_ID='" +sid+ "'";
                    OleDbCommand addrcmd = new OleDbCommand(cmdStr, con);
                    init_addr = (string)addrcmd.ExecuteScalar();
                    saddrTxt.Text = init_addr;
                    cmdStr = "Select Supl_Email from supplierDb where Supl_ID='" +sid+ "'";
                    OleDbCommand emailcmd = new OleDbCommand(cmdStr, con);
                    init_email = (string)emailcmd.ExecuteScalar();
                    semailTxt.Text = init_email;
                    cmdStr = "Select Supl_Type from supplierDb where Supl_ID='" +sid+ "'";
                    OleDbCommand stypecmd = new OleDbCommand(cmdStr, con);
                    init_type = (string)stypecmd.ExecuteScalar();
                    stypeTxt.Text = init_type;
                    con.Close();
                }
                else if (count == 0)
                {
                    MessageBox.Show("No results found for Supplier ID: " + sid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string stype = stypeTxt.Text;
                string cmdText = "UPDATE supplierDb SET Supl_Name = '" + sname + "', Supl_Email = '" + semail + "', Supl_PhNo = '" + sphno + "', Supl_Addr = '" + saddr + "', Supl_Type = '" + stype + "' WHERE Supl_ID = '" + sid + "'";
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
                MessageBox.Show("Edited Supplier Successfully");
                con.Close();
                clearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
