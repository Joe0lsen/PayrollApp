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
    public partial class Detail : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\git\Payroll\Payroll\PayrollDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Detail()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbPhone.Text == "" || cbGender.SelectedIndex == -1 || tbAddress.Text == "" || tbSal.Text == "")
            {
                MessageBox.Show("Required Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,JoinDate,EmpBaseSal)" +
                        "values(@EN,@EG,@ED,@EP,@EA,@EPos,@JD,@EBS)", Con);
                    cmd.Parameters.AddWithValue("@EN", tbName.Text);
                    cmd.Parameters.AddWithValue("@EG", cbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", dateDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", tbPhone.Text);
                    cmd.Parameters.AddWithValue("@EA", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@EPos", cbPos.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", dateJoin.Value.Date);
                    cmd.Parameters.AddWithValue("@EBS", tbSal.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
