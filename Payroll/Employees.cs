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
    public partial class Employees : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\git\Payroll\Payroll\PayrollDB.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;
        public Employees()
        {
            InitializeComponent();
            ShowDetails();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbWage.Text = "";
            cbGender.SelectedIndex = -1;
            cbPos.SelectedIndex = -1;
            Key = 0;
        }

        private void ShowDetails()
        {
            Con.Open();
            string Query = "Select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            new SqlCommandBuilder(sda);
            var dSet = new DataSet();
            sda.Fill(dSet);
            dgvDetail.DataSource = dSet.Tables[0];
            Con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbPhone.Text == "" || cbGender.SelectedIndex == -1 || tbAddress.Text == "" || tbWage.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,JoinDate,EmpWage)" +
                        "values(@EN,@EG,@ED,@EP,@EA,@EPos,@JD,@EW)", Con);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@EG", cbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", dateDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", tbPhone.Text);
                    cmd.Parameters.AddWithValue("@EA", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@EPos", cbPos.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", dateJoin.Value.Date);
                    cmd.Parameters.AddWithValue("@EW", tbWage.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowDetails();
                    MessageBox.Show("Employee Saved");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                tbName.Text = dgvDetail.Rows[rowIndex].Cells[1].Value.ToString();
                cbGender.SelectedItem = dgvDetail.Rows[rowIndex].Cells[2].Value.ToString();
                dateDOB.Text = dgvDetail.Rows[rowIndex].Cells[3].Value.ToString();
                tbPhone.Text = dgvDetail.Rows[rowIndex].Cells[4].Value.ToString();
                tbAddress.Text = dgvDetail.Rows[rowIndex].Cells[5].Value.ToString();
                cbPos.SelectedItem = dgvDetail.Rows[rowIndex].Cells[6].Value.ToString();
                dateJoin.Text = dgvDetail.Rows[rowIndex].Cells[7].Value.ToString();
                tbWage.Text = dgvDetail.Rows[rowIndex].Cells[8].Value.ToString();

                if (tbName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(dgvDetail.Rows[rowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || cbGender.SelectedIndex == -1 || tbAddress.Text == "" || tbWage.Text == "")
            {
                MessageBox.Show("Select an employee name and enter new information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTbl Set EmpName=@EN,EmpGen=@EG,EmpDOB=@ED,EmpPhone=@EP,EmpAdd=@EA,EmpPos=@EPos,JoinDate=@JD,EmpWage=@EW where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@EG", cbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", dateDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", tbPhone.Text);
                    cmd.Parameters.AddWithValue("@EA", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@EPos", cbPos.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", dateJoin.Value.Date);
                    cmd.Parameters.AddWithValue("@EW", tbWage.Text);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowDetails();
                    MessageBox.Show("Employee Updated");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an employee name");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeTbl where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    Con.Close();
                    ShowDetails();
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

        private void lblBonus_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
            Obj.Show();
            this.Hide();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            Time Obj = new Time();
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
