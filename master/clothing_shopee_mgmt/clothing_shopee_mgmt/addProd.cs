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
    public partial class addProd : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string suplID;

        public addProd()
        {
            InitializeComponent();
        }

        public void ClearTxt() 
        {
            nameTxt.Text = "";
            pidTxt.Text = "";
            snameTxt.Text = "";
            typeTxt.Text = "";
            stockTxt.Text = "";
        }

        private void addProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet3.supplierDb' table. You can move, or remove it, as needed.
            this.supplierDbTableAdapter.Fill(this.shopDbDataSet3.supplierDb);

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            suplID = this.suplIdCB.GetItemText(this.suplIdCB.SelectedItem);
            string cmdText = "select Supl_Name from supplierDb where Supl_ID = '" +suplID+ "'";
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
            snameTxt.Text = (string)cmd.ExecuteScalar();
            string cmd2Text = "select Supl_Type from supplierDb where Supl_ID = '" + suplID + "'";
            OleDbCommand cmd2 = new OleDbCommand
            {
                Connection = con,
                CommandText = cmd2Text
            };
            typeTxt.Text = (string)cmd2.ExecuteScalar();
            con.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearTxt();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = pidTxt.Text;
                string name = nameTxt.Text;
                string sname = snameTxt.Text;
                string type = typeTxt.Text;
                string stock = stockTxt.Text;
                string price = priceTxt.Text;
                string refillDate = datePicker.Value.ToShortDateString();
                string cmdText = "INSERT into inventoryDb (Prod_ID, Prod_Name, Prod_Type, Prod_Stock, Prod_Price, Supl_ID, Supl_Name, Prod_Next_Refill) values('" + pid + "','" + name + "','" + type + "','" + stock + "', '" + stock + "','" + suplID + "', '" + sname + "', '" + refillDate + "') ";
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
                if (pid == "" || name == "" || sname == "" || type == "" || stock == "" || price == "")
                {
                    MessageBox.Show("Empty fields detected. Make sure you fill all the details");
                }
                else
                {
                        if(Regex.Match(priceTxt.Text, @"^[0-9]").Success)
                        {
                            if(Regex.Match(stockTxt.Text, @"^[0-9]").Success)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Entry successful");
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid stock value");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid price value");
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
