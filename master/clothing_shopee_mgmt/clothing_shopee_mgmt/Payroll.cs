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
    public partial class Payroll : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string name;
        string role;
        string workedDays;
        string overtimeDays;
        string wage;
        string ta;
        string hra;
        string tax;
        string bonus;
        string ctc;
        int sal_ta;
        int sal_hra;
        int sal_wage;
        int sal_tax;
        int sal_ctc;
        int sal_workedDays;
        int sal_overtimeDays;
        int sal_bonus;

        public Payroll()
        {
            InitializeComponent();
            nameValueLbl.Visible = false;
            roleValueLbl.Visible = false;
            ctcValueLbl.Visible = false;
            ctcLbl.Visible = false;
        }

        public void clearTxt()
        {
            workedDaysTxt.Text = "";
            overTimeTxt.Text = "";
            wageTxt.Text = "";
            taTxt.Text = "";
            hraTxt.Text = "";
            taxTxt.Text = "";
            bonusTxt.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homepage = new Home();
            homepage.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully. Returning you to login page.");
            this.Close();
            Login loginpage = new Login();
            loginpage.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idTxt.Text;
                con = new OleDbConnection
                {
                    ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\Qais College\Project- SEM 5\master\shopDb.accdb"
                };
                con.Open();
                string cmdStr = "Select count(*) from payrollDb where E_ID = '" + id + "'"; //get the existence of the record as count 

                OleDbCommand cmd = new OleDbCommand(cmdStr, con);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    ctcValueLbl.Visible = false;
                    ctcLbl.Visible = false;
                    nameValueLbl.Visible = true;
                    roleValueLbl.Visible = true;
                    save.Visible = false;
                    cmdStr = "Select E_Name from payrollDb where E_ID = '" + id + "'";
                    OleDbCommand namecmd = new OleDbCommand(cmdStr, con);
                    name = (string)namecmd.ExecuteScalar();
                    nameValueLbl.Text = name;
                    cmdStr = "Select E_Role from payrollDb where E_ID = '" + id + "'";
                    OleDbCommand rolecmd = new OleDbCommand(cmdStr, con);
                    role = (string)rolecmd.ExecuteScalar();
                    roleValueLbl.Text = role;
                    if(role == "Manager")
                    {
                        wageTxt.Text = "2000";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "10";
                    }
                    else if(role == "Associate_Manager")
                    {
                        wageTxt.Text = "1800";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "10";
                    }
                    else if(role == "Supervisor")
                    {
                        wageTxt.Text = "1600";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "10";
                    }
                    else if(role == "Cashier")
                    {
                        wageTxt.Text = "1200";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "10";
                    }
                    else if(role == "Marketing")
                    {
                        wageTxt.Text = "1500";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "10";
                    }
                    else if(role == "Tech_Support")
                    {
                        wageTxt.Text = "1300";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "10";
                    }
                    else if(role == "Associate")
                    {
                        wageTxt.Text = "1000";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "5";
                    }
                    else if(role == "Intern")
                    {
                        wageTxt.Text = "750";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "0";
                    }
                    else if(role == "Organizer")
                    {
                        wageTxt.Text = "900";
                        taTxt.Text = "5000";
                        hraTxt.Text = "4000";
                        taxTxt.Text = "0";
                    }
                    else
                    {
                        cmdStr = "Select Daily_Wage from payrollDb where E_ID = '" + id + "'";
                        OleDbCommand wagecmd = new OleDbCommand(cmdStr, con);
                        wage = (string)wagecmd.ExecuteScalar();
                        wageTxt.Text = wage;
                        cmdStr = "Select TA from payrollDb where E_ID = '" + id + "'";
                        OleDbCommand tacmd = new OleDbCommand(cmdStr, con);
                        ta = (string)tacmd.ExecuteScalar();
                        taTxt.Text = ta;
                        cmdStr = "Select HRA from payrollDb where E_ID = '" + id + "'";
                        OleDbCommand hracmd = new OleDbCommand(cmdStr, con);
                        hra = (string)hracmd.ExecuteScalar();
                        hraTxt.Text = hra;
                        cmdStr = "Select Income_Tax from payrollDb where E_ID = '" + id + "'";
                        OleDbCommand taxcmd = new OleDbCommand(cmdStr, con);
                        tax = (string)taxcmd.ExecuteScalar();
                        taxTxt.Text = tax;
                        cmdStr = "Select Bonus from payrollDb where E_ID = '" + id + "'";
                        OleDbCommand bonuscmd = new OleDbCommand(cmdStr, con);
                        bonus = (string)bonuscmd.ExecuteScalar();
                        bonusTxt.Text = bonus;
                    }
                    con.Close();
                }
                else if (count == 0)
                {
                    MessageBox.Show("No results found for Employee ID: " + id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salary()
        {
            int temp, tax_temp;
            wage = wageTxt.Text;
            ta = taTxt.Text;
            hra = hraTxt.Text;
            tax = taxTxt.Text;
            bonus = bonusTxt.Text;
            workedDays = workedDaysTxt.Text;
            overtimeDays = overTimeTxt.Text;
            sal_wage = Convert.ToInt32(wage);
            sal_ta = Convert.ToInt32(ta);
            sal_hra = Convert.ToInt32(hra);
            sal_tax = Convert.ToInt32(tax);
            sal_workedDays = Convert.ToInt32(workedDays);
            sal_overtimeDays = Convert.ToInt32(overtimeDays);
            sal_bonus = Convert.ToInt32(bonus);
            temp = (sal_workedDays * sal_wage) + (sal_overtimeDays * sal_wage / 2) + sal_ta + sal_hra;
            tax_temp = (temp * sal_tax) / 100;
            sal_ctc = temp - tax_temp;
            ctc = Convert.ToString(sal_ctc);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            salary();
            ctcLbl.Visible = true;
            ctcValueLbl.Text = ctc;
            ctcValueLbl.Visible = true;
            save.Visible = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = "update payrollDb set CTC = '" + ctc + "', Worked_Days = '" + workedDaysTxt.Text+ "', Overtime_Days = '" +overTimeTxt.Text+ "', Daily_Wage = '" + wageTxt.Text + "', TA = '" + taTxt.Text + "', hra = '" + hraTxt.Text + "', Income_Tax = '" + taxTxt.Text + "', Bonus = '" +bonusTxt.Text+ "' where E_ID = '" + idTxt.Text + "'";
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
                MessageBox.Show("Data Saved Successfuly");
                con.Close();
                clearTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
    }
}
