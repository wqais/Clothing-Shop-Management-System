using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Printing;
using System.Web;

namespace clothing_shopee_mgmt
{
    public partial class addBill : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        Bitmap bmp;
        string cust_id, prod_name, prod_id, supl_name, prod_price, disc, p_qty, p_total, p_stock, sr_no, new_stock, cartTotal, date;
        int p_price, qty, discount, total, sum = 0, s_no = 0, stock;

        public addBill()
        {
            InitializeComponent();
            suplCb.Enabled = false;
            itemCount.Value = 1;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            int height  = billData.Height;
            billData.Height = billData.RowCount * billData.RowTemplate.Height * 2;
            bmp = new Bitmap(billData.Width, billData.Height);
            billData.DrawToBitmap(bmp, new Rectangle(0, 0, billData.Width, billData.Height));
            billData.Height = height;
            printBillDialog.Document = printBill;
            printBillDialog.PrintPreviewControl.Zoom = 0.75;
            printBillDialog.ShowDialog();
            try
            {
                cust_id = custIdTxt.Text;
                cartTotal = Convert.ToString(sum);
                date = DateTime.Now.ToShortDateString();
                string cmdText = "insert into billDb (Cust_ID, Total, [Date]) values ('" + cust_id + "', '" + cartTotal + "', '" + date + "')";
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
                con.Close();
                clearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*try
            {
                cust_id = custIdTxt.Text;
                cartTotal = Convert.ToString(sum);
                date = DateTime.Now.ToShortDateString();
                string cmdText = "insert into billDb (Cust_ID, Total, [Date]) values ('" + cust_id + "', '" + cartTotal + "', '" + date + "')";
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Qais College\Project - SEM 5\Access\shopReportsDb.mdb"
                };
                con.Open();
                cmd = new OleDbCommand
                {
                    Connection = con,
                    CommandText = cmdText
                };
                cmd.ExecuteNonQuery();
                con.Close();
                clearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "delete from tempBillDb where SR_NO = '" + sr_no + "'";
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
                con.Close();
                try
                {
                    prod_id = idTxt.Text;
                    stock += qty;
                    new_stock = Convert.ToString(stock);
                    string cmdString = "update inventoryDb set Prod_Stock = '" + new_stock + "' where Prod_ID = '" + prod_id + "'";
                    con = new OleDbConnection
                    {
                        ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                    };
                    con.Open();
                    OleDbCommand stockCmd = new OleDbCommand
                    {
                        Connection = con,
                        CommandText = cmdString
                    };
                    stockCmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    clearFields();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "delete from tempBillDb";
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
                con.Close();
                s_no = 0;
                sum = 0;
                Display();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearFields()
        {
            idTxt.Text = "";
            itemCount.Value = 1;
            nameTxt.Text = "";
            suplCb.Text = "";
            priceTxt.Text = "";
            discountTxt.Text = "";
        }

        public void Display()
        {
            DataTable dt = new DataTable();
            string constring = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb";
            var conn = new OleDbConnection(constring);
            conn.Open();
            var da = new OleDbDataAdapter("select * from tempBillDb", conn);
            da.Fill(dt);
            billData.DataSource = dt;
            conn.Close();
        }

        public void cbItems()
        {
            prod_name = nameTxt.Text;
            if (prod_name == "")
            {
                suplCb.Enabled = false;
            }
            else
            {
                try
                {
                    DataTable dt = null;
                    string cmdText = "select Supl_Name from inventoryDb where Prod_Name = '" + prod_name + "'";
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
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    suplCb.Enabled = true;
                    suplCb.DisplayMember = "Supl_Name";
                    suplCb.ValueMember = "Supl_Name";
                    suplCb.DataSource = dt;
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void prodID()
        {
            prod_name = nameTxt.Text;
            supl_name = this.suplCb.GetItemText(this.suplCb.SelectedItem);
            try
            {
                string cmdText = "select Prod_ID from inventoryDb where Prod_Name = '" + prod_name + "' and Supl_Name = '" + supl_name + "'";
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
                prod_id = (string)cmd.ExecuteScalar();
                idTxt.Text = prod_id;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getPrice()
        {
            prod_id = idTxt.Text;
            if (idTxt.Text == "")
            {
                priceTxt.Text = "";
            }
            else
            {
                try
                {
                    string cmdText = "select Prod_Price from inventoryDb where Prod_ID = '" + prod_id + "'";
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
                    prod_price = (string)cmd.ExecuteScalar();
                    priceTxt.Text = prod_price;
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void calcBill()
        {
            try
            {
                prod_id = idTxt.Text;
                string cmdText = "select Prod_Stock from inventoryDb where Prod_ID = '" + prod_id + "'";
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
                p_stock = (string)cmd.ExecuteScalar();
                con.Close();
                stock = Convert.ToInt32(p_stock);
                int temp, temp_disc;
                prod_price = priceTxt.Text;
                if (discountTxt.Text == "")
                {
                    disc = "0";
                }
                else
                {
                    disc = discountTxt.Text;
                }
                qty = Convert.ToInt32(itemCount.Value);
                p_price = Convert.ToInt32(prod_price);
                discount = Convert.ToInt32(disc);
                if (stock > 0)
                {
                    temp = p_price * qty;
                    temp_disc = temp * discount / 100;
                    total = temp - temp_disc;
                    sum += total;
                    stock -= qty;
                    try
                    {
                        new_stock = Convert.ToString(stock);
                        string cmdString = "update inventoryDb set Prod_Stock = '" + new_stock + "' where Prod_ID = '" + prod_id + "'";
                        con = new OleDbConnection
                        {
                            ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                        };
                        con.Open();
                        OleDbCommand stockCmd = new OleDbCommand
                        {
                            Connection = con,
                            CommandText = cmdString
                        };
                        stockCmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Selected product is out of stock.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void addItem()
        {
            s_no++;
            calcBill();
            sr_no = Convert.ToString(s_no);
            prod_id = idTxt.Text;
            prod_name = nameTxt.Text;
            supl_name = this.suplCb.GetItemText(this.suplCb.SelectedItem); ;
            p_qty = Convert.ToString(Convert.ToInt32(itemCount.Value));
            p_total = Convert.ToString(total);
            try
            {
                string cmdText = "insert into tempBillDb (SR_NO, Name, Quantity, Price) values ('" + sr_no + "', '" + supl_name + " " + prod_name +"', '" + p_qty + "', '" + p_total + "')";
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
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDbDataSet5.tempBillDb' table. You can move, or remove it, as needed.
            //this.tempBillDbTableAdapter.Fill(this.shopDbDataSet5.tempBillDb);

        }

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cbItems();
                prodID();
                getPrice();
            }
        }

        private void suplCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodID();
            getPrice();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addItem();
            Display();
            billData.Rows[s_no].Cells[4].Value = sum;
        }
    }
}
