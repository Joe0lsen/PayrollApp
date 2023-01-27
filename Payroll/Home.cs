using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll;

namespace Payroll
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
    }
}
