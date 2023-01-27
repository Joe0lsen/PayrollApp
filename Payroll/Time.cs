using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll
{
    public partial class Time : Form
    {
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\git\Payroll\Payroll\PayrollDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Time()
        {
            InitializeComponent();
            ShowTimeDetails();
            GetEmployees();
            tbVacUsed.Text = "0";
        }
        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Columns.Add("EmpId", typeof(int));
            dTable.Load(Rdr);
            cbEmpID.ValueMember = "EmpId";
            cbEmpID.DataSource = dTable;
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
            foreach(DataRow dRow in dTable.Rows)
            {
                tbName.Text = dRow["EmpName"].ToString();
            }
            Con.Close();
        }
        private void Clear()
        {
            cbEmpID.SelectedIndex = -1;
            tbName.Text = "";
            tbHrsWorked.Text = "";
            tbVacUsed.Text = "0";

            Key = 0;
        }

        private void ShowTimeDetails()
        {
            Con.Open();
            string Query = "Select * from TimeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            new SqlCommandBuilder(sda);
            var dSet = new DataSet();
            sda.Fill(dSet);
            dgvTimeDetail.DataSource = dSet.Tables[0];
            Con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbEmpID.Text == "" || tbName.Text == "" || tbHrsWorked.Text == "" || tbVacUsed.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    string Period = datePeriod.Value.ToString("MMM") + "/" + datePeriod.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TimeTbl(EmpId,EmpName,HrsWorked,VacUsed,Period)" +
                        "values(@ID,@EN,@HW,@VU,@Per)", Con);
                    cmd.Parameters.AddWithValue("@ID", cbEmpID.Text);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@HW", Math.Round((float)Convert.ToDouble(tbHrsWorked.Text),2));
                    cmd.Parameters.AddWithValue("@VU", Math.Round((float)Convert.ToDouble(tbVacUsed.Text),2));
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowTimeDetails();
                    MessageBox.Show("Employee Time Saved");
                    Clear();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex);
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                tbName.Text = dgvTimeDetail.Rows[rowIndex].Cells[2].Value.ToString();
                cbEmpID.SelectedValue = dgvTimeDetail.Rows[rowIndex].Cells[1].Value;
                tbHrsWorked.Text = dgvTimeDetail.Rows[rowIndex].Cells[3].Value.ToString();
                tbVacUsed.Text = dgvTimeDetail.Rows[rowIndex].Cells[4].Value.ToString();
                datePeriod.Text = dgvTimeDetail.Rows[rowIndex].Cells[5].Value.ToString();
                
                if (tbName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(dgvTimeDetail.Rows[rowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbEmpID.Text == "" || tbName.Text == "" || tbHrsWorked.Text == "" || tbVacUsed.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    string Period = datePeriod.Value.ToString("MMM") + "/" + datePeriod.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TimeTbl Set EmpId=@ID,EmpName=@EN,HrsWorked=@HW,VacUsed=@VU,Period=@Per Where TimeNum=@TimeKey", Con);
                    cmd.Parameters.AddWithValue("@ID", cbEmpID.Text);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@HW", Math.Round(Convert.ToDouble(tbHrsWorked.Text), 2));
                    cmd.Parameters.AddWithValue("@VU", Math.Round(Convert.ToDouble(tbVacUsed.Text), 2));
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.Parameters.AddWithValue("@TimeKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowTimeDetails();
                    MessageBox.Show("Employee Time Updated");
                    Clear();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex);
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from TimeTbl where TimeNum=@TimeKey", Con);
                    cmd.Parameters.AddWithValue("@TimeKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Time Deleted");
                    Con.Close();
                    ShowTimeDetails();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbEmpID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetNames();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lblPay_Click(object sender, EventArgs e)
        {
            Pay Obj = new Pay();
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
