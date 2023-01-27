using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Payroll
{
    public partial class Pay : Form
    {
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\git\Payroll\Payroll\PayrollDB.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable idTable = new DataTable();
        public Pay()
        {
            InitializeComponent();
            ShowPayDetails();
            GetEmployees();
            GetBonus();
            Clear();
        }
        private void Clear()
        {
            cbEmpID.SelectedIndex = -1;
            cbBonus.SelectedIndex = -1;
            tbBnsAmt.Text = "0";
            tbWage.Text = "";
            tbName.Text = "";
            tbHrsWorked.Text = "";
            tbVacUsed.Text = "0";
            tbBal.Text = "";
            tbTax.Text = "";

            Key = 0;
        }
        private void ShowPayDetails()
        {
            Con.Open();
            string Query = "Select * from PayTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            new SqlCommandBuilder(sda);
            var dSet = new DataSet();
            sda.Fill(dSet);
            dgvPayDetail.DataSource = dSet.Tables[0];
            Con.Close();
        }

        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            
            idTable.Columns.Add("EmpId", typeof(int));
            idTable.Load(Rdr);
            cbEmpID.ValueMember = "EmpId";
            cbEmpID.DataSource = idTable;
            Con.Close();
        }
        private void GetBonus()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from BonusTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Columns.Add("BName", typeof(string));
            dTable.Load(Rdr);
            cbBonus.ValueMember = "BName";
            cbBonus.DataSource = dTable;
            Con.Close();
        }
        private void GetHrsWorked()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TimeTbl where EmpId=" + cbEmpID.SelectedValue.ToString() + "", Con);
            DataTable dTable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dTable);
            foreach (DataRow dRow in dTable.Rows)
            {
                tbHrsWorked.Text = dRow["HrsWorked"].ToString();
            }
            Con.Close();
        }
        private void GetVacUsed()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TimeTbl where EmpId=" + cbEmpID.SelectedValue.ToString() + "", Con);
            DataTable dTable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dTable);
            foreach (DataRow dRow in dTable.Rows)
            {
                tbVacUsed.Text = dRow["VacUsed"].ToString();
            }
            Con.Close();
        }
        private void GetNames()
        {
            Con.Open();
            string Query = "Select * from EmployeeTbl where EmpId=" + cbEmpID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dTable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dTable);
            foreach (DataRow dRow in dTable.Rows)
            {
                tbName.Text = dRow["EmpName"].ToString();
                tbWage.Text = dRow["EmpWage"].ToString();
            }
            Con.Close();
        }
        private void GetBonusAmt()
        {
            Con.Open();
            string Query = "Select * from BonusTbl where BName='" + cbBonus.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dTable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dTable);
            foreach (DataRow dRow in dTable.Rows)
            {
                tbBnsAmt.Text = dRow["BAmt"].ToString();
            }
            Con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbBal.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    string Period = datePeriod.Value.ToString("MMM") + "/" + datePeriod.Value.Year;
                    Con.Open();
                    string Query = "Update PayTbl Set EmpId=@EI,EmpName=@EN,EmpWage=@EW,EmpHrs=@EH,VacUsed=@VU,BonusName=@BN,EmpBonus=@EB,EmpTax=@ET," +
                        "EmpBalance=@EBal,PayPeriod=@PP Where PaymentNum=@PayKey";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.Parameters.AddWithValue("@EI", cbEmpID.Text);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@EW", tbWage.Text);
                    cmd.Parameters.AddWithValue("@EH", tbHrsWorked.Text);
                    cmd.Parameters.AddWithValue("@VU", tbVacUsed.Text);
                    cmd.Parameters.AddWithValue("@BN", cbBonus.Text);
                    cmd.Parameters.AddWithValue("@EB", tbBnsAmt.Text);
                    cmd.Parameters.AddWithValue("@ET", tbTax.Text);
                    cmd.Parameters.AddWithValue("@EBal", tbBal.Text);
                    cmd.Parameters.AddWithValue("@PP", Period);
                    cmd.Parameters.AddWithValue("@PayKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowPayDetails();
                    MessageBox.Show("Payment Updated");
                    Clear();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex);
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbBal.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    string Period = datePeriod.Value.ToString("MMM") + "/" + datePeriod.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PayTbl(EmpId,EmpName,EmpWage,EmpHrs,VacUsed,BonusName,EmpBonus,EmpTax,EmpBalance,PayPeriod)" +
                        "values(@EI,@EN,@EW,@EH,@VU,@BN,@EB,@ET,@EBal,@PP)", Con);
                    cmd.Parameters.AddWithValue("@EI", cbEmpID.Text);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@EW", tbWage.Text);
                    cmd.Parameters.AddWithValue("@EH", tbHrsWorked.Text);
                    cmd.Parameters.AddWithValue("@VU", tbVacUsed.Text);
                    cmd.Parameters.AddWithValue("@BN", cbBonus.Text);
                    cmd.Parameters.AddWithValue("@EB", tbBnsAmt.Text);
                    cmd.Parameters.AddWithValue("@ET", tbTax.Text);
                    cmd.Parameters.AddWithValue("@EBal", tbBal.Text);
                    cmd.Parameters.AddWithValue("@PP", Period);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowPayDetails();
                    MessageBox.Show("Payment Submitted!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void cbEmpID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbVacUsed.Text = "0";
            tbBnsAmt.Text = "0";
            tbHrsWorked.Text = "";
            tbBal.Text = "";
            tbTax.Text = "";
            GetNames();
            GetHrsWorked();
            GetVacUsed();
            GetBonus();
        }

        private void cbBonus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBonusAmt();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (tbHrsWorked.Text == "")
            {
                MessageBox.Show("Missing Required Information \n\nSelect another employee");
            }

            else
            {
                float empWage = (float)Convert.ToDouble(tbWage.Text);
                float empHrs = (float)Convert.ToDouble(tbHrsWorked.Text);
                float empVac = (float)Convert.ToDouble(tbVacUsed.Text);
                int empBns = Convert.ToInt32(tbBnsAmt.Text);
                float taxRate = 0.06f; // -6% tax

                float sTotal = empWage * (empHrs + empVac) + empBns;
                float empTax = sTotal * taxRate;
                float gTotal = sTotal - empTax;

                tbBal.Text = Math.Round((float)gTotal, 2).ToString();
                tbTax.Text = "-" + Math.Round((float)empTax, 2).ToString();
            }

        }

        private void dgvPayDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                cbEmpID.SelectedValue = dgvPayDetail.Rows[rowIndex].Cells[1].Value;
                tbName.Text = dgvPayDetail.Rows[rowIndex].Cells[2].Value.ToString();
                tbWage.Text = dgvPayDetail.Rows[rowIndex].Cells[3].Value.ToString();
                tbHrsWorked.Text = dgvPayDetail.Rows[rowIndex].Cells[4].Value.ToString();
                tbVacUsed.Text = dgvPayDetail.Rows[rowIndex].Cells[5].Value.ToString();
                cbBonus.SelectedValue = dgvPayDetail.Rows[rowIndex].Cells[6].Value;
                tbBnsAmt.Text = dgvPayDetail.Rows[rowIndex].Cells[7].Value.ToString();
                tbTax.Text = dgvPayDetail.Rows[rowIndex].Cells[8].Value.ToString();
                tbBal.Text = dgvPayDetail.Rows[rowIndex].Cells[9].Value.ToString();
                datePeriod.Text = dgvPayDetail.Rows[rowIndex].Cells[10].Value.ToString();

                if (tbName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(dgvPayDetail.Rows[rowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void dgvPayDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 600, 900);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Lampshade, LLC", new System.Drawing.Font("Averia", 12, System.Drawing.FontStyle.Bold), Brushes.Red, new Point(220, 25));
            e.Graphics.DrawString("Knome Payroll System 1.0", new System.Drawing.Font("Averia", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(200, 45));

            string payNum = dgvPayDetail.SelectedRows[0].Cells[0].Value.ToString();
            string period = dgvPayDetail.SelectedRows[0].Cells[10].Value.ToString();
            string empId = dgvPayDetail.SelectedRows[0].Cells[1].Value.ToString();
            string empName = dgvPayDetail.SelectedRows[0].Cells[2].Value.ToString();
            string wage = dgvPayDetail.SelectedRows[0].Cells[3].Value.ToString();
            string hrs = dgvPayDetail.SelectedRows[0].Cells[4].Value.ToString();
            string vac = dgvPayDetail.SelectedRows[0].Cells[5].Value.ToString();
            string bName = dgvPayDetail.SelectedRows[0].Cells[6].Value.ToString();
            string bAmt = dgvPayDetail.SelectedRows[0].Cells[7].Value.ToString();
            string tax = dgvPayDetail.SelectedRows[0].Cells[8].Value.ToString();
            string bal = dgvPayDetail.SelectedRows[0].Cells[9].Value.ToString();

            e.Graphics.DrawString("Payment Number: " + payNum, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Payment Period: " + period, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(250, 100));
            e.Graphics.DrawString("Employee ID: " + empId, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("Employee Name: " + empName, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(250, 150));
            e.Graphics.DrawString("Hourly Rate: " + wage, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(50, 180));
            e.Graphics.DrawString("Hours Worked: " + hrs, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(50, 210));
            e.Graphics.DrawString("Vacation Hours Used: " + vac, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(50, 240));
            e.Graphics.DrawString("Bonus: " + bName, new System.Drawing.Font("Bellota", 8, System.Drawing.FontStyle.Bold), Brushes.DarkBlue, new Point(50, 270));
            e.Graphics.DrawString("Amout: " + bAmt, new System.Drawing.Font("Bellota", 8, System.Drawing.FontStyle.Bold), Brushes.DarkBlue, new Point(250, 270));
            e.Graphics.DrawString("Tax: " + tax, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.DarkRed, new Point(50, 300));
            e.Graphics.DrawString("Total: " + bal, new System.Drawing.Font("Bellota", 10, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(50, 330));

            e.Graphics.DrawString("Powered by Knome Payroll System 1.0", new System.Drawing.Font("Bellota", 12, System.Drawing.FontStyle.Bold), Brushes.Crimson, new Point(150, 420));
        }

        private void lblEmp_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void lblBonus_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
            Obj.Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            Time Obj = new Time();
            Obj.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }
    }
}
