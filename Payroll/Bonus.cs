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
    public partial class Bonus : Form
    {
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\git\Payroll\Payroll\PayrollDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Bonus()
        {
            InitializeComponent();
            ShowBDetails();
        }
        private void Clear()
        {
            tbBName.Text = "";
            tbBAmount.Text = "";

            Key = 0;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void ShowBDetails()
        {
            Con.Open();
            string Query = "Select * from BonusTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            new SqlCommandBuilder(sda);
            var dSet = new DataSet();
            sda.Fill(dSet);
            dgvBDetail.DataSource = dSet.Tables[0];
            Con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbBName.Text == "" || tbBAmount.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BonusTbl(BName,BAmt)values(@BN,@BA)", Con);
                    cmd.Parameters.AddWithValue("@BN", tbBName.Text);
                    cmd.Parameters.AddWithValue("@BA", Convert.ToDouble(tbBAmount.Text));
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowBDetails();
                    MessageBox.Show("Bonus Saved");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void dgvBDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                tbBName.Text = dgvBDetail.Rows[rowIndex].Cells[1].Value.ToString();
                tbBAmount.Text = dgvBDetail.Rows[rowIndex].Cells[2].Value.ToString();
                
                if (tbBName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(dgvBDetail.Rows[rowIndex].Cells[0].Value.ToString());
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbBName.Text == "" || tbBAmount.Text == "")
            {
                MessageBox.Show("Select a bonus and enter new information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update BonusTbl Set BName=@BN,BAmt=@BA Where BId=@BKey", Con);
                    cmd.Parameters.AddWithValue("@BN", tbBName.Text);
                    cmd.Parameters.AddWithValue("@BA", tbBAmount.Text);
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    ShowBDetails();
                    MessageBox.Show("Bonus Updated");
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
                MessageBox.Show("Select a bonus name");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from BonusTbl where BId=@BKey", Con);
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Deleted");
                    Con.Close();
                    ShowBDetails();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblEmp_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
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
