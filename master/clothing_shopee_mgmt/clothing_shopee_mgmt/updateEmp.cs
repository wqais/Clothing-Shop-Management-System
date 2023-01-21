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
    public partial class updateEmp : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string init_name;
        string init_addr;
        string init_phno;
        string init_email;
        public updateEmp()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string eid = eidTxt.Text;
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                string cmdStr = "Select count(*) from employeeDb where E_ID = '" + eid + "'"; //get the existence of the record as count 

                OleDbCommand cmd = new OleDbCommand(cmdStr, con);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Record Found! Insert new details.");
                    updateEmpForm.Visible = true;
                    cmdStr = "Select E_Name from employeeDb where E_ID = '" +eid+ "'";
                    OleDbCommand enamecmd = new OleDbCommand(cmdStr, con);
                    init_name = (string)enamecmd.ExecuteScalar();
                    enameTxt.Text = init_name;
                    cmdStr = "Select E_Email from employeeDb where E_ID = '" +eid+ "'";
                    OleDbCommand emailcmd = new OleDbCommand(cmdStr, con);
                    init_email = (string)emailcmd.ExecuteScalar(); ;
                    eemailTxt.Text = init_email;
                    cmdStr = "Select E_PhNo from employeeDb where E_ID = '" +eid+ "'";
                    OleDbCommand phnocmd = new OleDbCommand(cmdStr, con);
                    init_phno = (string)phnocmd.ExecuteScalar();
                    ephnoTxt.Text = init_phno;
                    cmdStr = "Select E_Addr from employeeDb where E_ID = '" +eid+ "'";
                    OleDbCommand addrcmd = new OleDbCommand(cmdStr, con);
                    init_addr = (string)addrcmd.ExecuteScalar();
                    eaddrTxt.Text = init_addr;
                    con.Close();
                }
                else if (count == 0)
                {
                    MessageBox.Show("No results found for Employee ID: " + eid);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string edoj = dojPicker.Value.ToShortDateString();
                string cmdText = "UPDATE employeeDb SET E_Name = '" + ename + "', E_Email = '" + eemail + "', E_PhNo = '" + ephno + "', E_Addr = '" + eaddr + "', E_DOJ = '" + edoj + "' WHERE E_ID = '" + eid + "'";
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
                MessageBox.Show("Edited Employee Successfully");
                con.Close();
                eidTxt.Text = "";
                enameTxt.Text = "";
                eemailTxt.Text = "";
                ephnoTxt.Text = "";
                eaddrTxt.Text = "";
            }
            catch(Exception ex)
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
