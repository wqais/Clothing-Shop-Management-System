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
    public partial class updateProd : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string init_name;
        string init_stock;
        string init_refillDate;
        public updateProd()
        {
            InitializeComponent();
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
                string pid = pidTxt.Text;
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                string cmdStr = "Select count(*) from inventoryDb where Prod_ID = '" + pid + "'"; //get the existence of the record as count 

                OleDbCommand cmd = new OleDbCommand(cmdStr, con);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Record Found! Insert new details.");
                    updateProdForm.Visible = true;
                    cmdStr = "Select Prod_Name from inventoryDb where Prod_ID = '" + pid + "'";
                    OleDbCommand namecmd = new OleDbCommand(cmdStr, con);
                    init_name = (string)namecmd.ExecuteScalar();
                    nameTxt.Text = init_name;
                    cmdStr = "Select Prod_Stock from inventoryDb where Prod_ID = '" + pid + "'";
                    OleDbCommand stockcmd = new OleDbCommand(cmdStr, con);
                    init_stock = (string)stockcmd.ExecuteScalar(); ;
                    stockTxt.Text = init_stock;
                    con.Close();
                }
                else if (count == 0)
                {
                    MessageBox.Show("No results found for Product ID: " + pid);
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
                string id = pidTxt.Text;
                string name = nameTxt.Text;
                string stock = stockTxt.Text;
                string date = refillDate.Value.ToShortDateString();
                string cmdText = "UPDATE inventoryDb SET Prod_Name = '" + name + "', Prod_Stock ='" + stock + "', Prod_Next_Refill = '" + date + "' where Prod_ID = '" + id + "'";
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
                MessageBox.Show("Edited Product Details Successfully");
                nameTxt.Text = "";
                stockTxt.Text = "";
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "";
            stockTxt.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
