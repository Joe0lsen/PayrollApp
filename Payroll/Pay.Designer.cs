
namespace Payroll
{
    partial class Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvPayDetail = new System.Windows.Forms.DataGridView();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPay = new System.Windows.Forms.PictureBox();
            this.btnTime = new System.Windows.Forms.PictureBox();
            this.btnBonus = new System.Windows.Forms.PictureBox();
            this.btnEmp = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTax = new System.Windows.Forms.Label();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.tbBal = new System.Windows.Forms.TextBox();
            this.tbBnsAmt = new System.Windows.Forms.TextBox();
            this.lblBnsAmt = new System.Windows.Forms.Label();
            this.lblVacUsed = new System.Windows.Forms.Label();
            this.tbVacUsed = new System.Windows.Forms.TextBox();
            this.lblHrsWorked = new System.Windows.Forms.Label();
            this.tbHrsWorked = new System.Windows.Forms.TextBox();
            this.cbBonus = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblWage = new System.Windows.Forms.Label();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.datePeriod = new System.Windows.Forms.DateTimePicker();
            this.lblBnsName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.navMarker = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.navIndicator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCalc.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnCalc.Location = new System.Drawing.Point(368, 316);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(135, 42);
            this.btnCalc.TabIndex = 25;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(162, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Honeydew;
            this.btnSubmit.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(34, 316);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 42);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvPayDetail
            // 
            this.dgvPayDetail.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvPayDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayDetail.Location = new System.Drawing.Point(34, 364);
            this.dgvPayDetail.Name = "dgvPayDetail";
            this.dgvPayDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayDetail.Size = new System.Drawing.Size(990, 290);
            this.dgvPayDetail.TabIndex = 22;
            this.dgvPayDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayDetail_CellContentClick);
            this.dgvPayDetail.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayDetail_CellContentDoubleClick);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(28, 103);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(160, 34);
            this.lblEmpID.TabIndex = 9;
            this.lblEmpID.Text = "Employee ID";
            // 
            // cbEmpID
            // 
            this.cbEmpID.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(34, 140);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(213, 35);
            this.cbEmpID.TabIndex = 0;
            this.cbEmpID.SelectionChangeCommitted += new System.EventHandler(this.cbEmpID_SelectionChangeCommitted);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(284, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 34);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(290, 140);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(213, 35);
            this.tbName.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(12, 485);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(68, 68);
            this.btnPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPay.TabIndex = 19;
            this.btnPay.TabStop = false;
            // 
            // btnTime
            // 
            this.btnTime.Image = ((System.Drawing.Image)(resources.GetObject("btnTime.Image")));
            this.btnTime.Location = new System.Drawing.Point(12, 411);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(68, 68);
            this.btnTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTime.TabIndex = 20;
            this.btnTime.TabStop = false;
            // 
            // btnBonus
            // 
            this.btnBonus.Image = ((System.Drawing.Image)(resources.GetObject("btnBonus.Image")));
            this.btnBonus.Location = new System.Drawing.Point(12, 337);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(68, 68);
            this.btnBonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBonus.TabIndex = 21;
            this.btnBonus.TabStop = false;
            // 
            // btnEmp
            // 
            this.btnEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnEmp.Image")));
            this.btnEmp.Location = new System.Drawing.Point(12, 263);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(68, 68);
            this.btnEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmp.TabIndex = 22;
            this.btnEmp.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 189);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 68);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 18;
            this.btnHome.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.lblTax);
            this.panelMain.Controls.Add(this.tbTax);
            this.panelMain.Controls.Add(this.lblBal);
            this.panelMain.Controls.Add(this.tbBal);
            this.panelMain.Controls.Add(this.tbBnsAmt);
            this.panelMain.Controls.Add(this.lblBnsAmt);
            this.panelMain.Controls.Add(this.lblVacUsed);
            this.panelMain.Controls.Add(this.tbVacUsed);
            this.panelMain.Controls.Add(this.lblHrsWorked);
            this.panelMain.Controls.Add(this.tbHrsWorked);
            this.panelMain.Controls.Add(this.cbBonus);
            this.panelMain.Controls.Add(this.btnClear);
            this.panelMain.Controls.Add(this.lblWage);
            this.panelMain.Controls.Add(this.tbWage);
            this.panelMain.Controls.Add(this.lblPeriod);
            this.panelMain.Controls.Add(this.datePeriod);
            this.panelMain.Controls.Add(this.lblBnsName);
            this.panelMain.Controls.Add(this.btnCalc);
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.btnSubmit);
            this.panelMain.Controls.Add(this.dgvPayDetail);
            this.panelMain.Controls.Add(this.lblEmpID);
            this.panelMain.Controls.Add(this.cbEmpID);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.tbName);
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Location = new System.Drawing.Point(86, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 693);
            this.panelMain.TabIndex = 15;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(759, 286);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(113, 34);
            this.lblTax.TabIndex = 53;
            this.lblTax.Text = "Tax (6%)";
            // 
            // tbTax
            // 
            this.tbTax.Enabled = false;
            this.tbTax.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTax.Location = new System.Drawing.Point(765, 323);
            this.tbTax.Name = "tbTax";
            this.tbTax.Size = new System.Drawing.Size(105, 35);
            this.tbTax.TabIndex = 52;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(540, 285);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(104, 34);
            this.lblBal.TabIndex = 51;
            this.lblBal.Text = "Balance";
            // 
            // tbBal
            // 
            this.tbBal.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbBal.Enabled = false;
            this.tbBal.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBal.Location = new System.Drawing.Point(546, 322);
            this.tbBal.Name = "tbBal";
            this.tbBal.Size = new System.Drawing.Size(213, 35);
            this.tbBal.TabIndex = 50;
            // 
            // tbBnsAmt
            // 
            this.tbBnsAmt.Enabled = false;
            this.tbBnsAmt.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBnsAmt.Location = new System.Drawing.Point(811, 234);
            this.tbBnsAmt.Name = "tbBnsAmt";
            this.tbBnsAmt.Size = new System.Drawing.Size(213, 35);
            this.tbBnsAmt.TabIndex = 49;
            // 
            // lblBnsAmt
            // 
            this.lblBnsAmt.AutoSize = true;
            this.lblBnsAmt.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnsAmt.Location = new System.Drawing.Point(805, 197);
            this.lblBnsAmt.Name = "lblBnsAmt";
            this.lblBnsAmt.Size = new System.Drawing.Size(185, 34);
            this.lblBnsAmt.TabIndex = 48;
            this.lblBnsAmt.Text = "Bonus Amount";
            // 
            // lblVacUsed
            // 
            this.lblVacUsed.AutoSize = true;
            this.lblVacUsed.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacUsed.Location = new System.Drawing.Point(540, 197);
            this.lblVacUsed.Name = "lblVacUsed";
            this.lblVacUsed.Size = new System.Drawing.Size(201, 34);
            this.lblVacUsed.TabIndex = 47;
            this.lblVacUsed.Text = "Vacations Hours";
            // 
            // tbVacUsed
            // 
            this.tbVacUsed.Enabled = false;
            this.tbVacUsed.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVacUsed.Location = new System.Drawing.Point(546, 234);
            this.tbVacUsed.Name = "tbVacUsed";
            this.tbVacUsed.Size = new System.Drawing.Size(213, 35);
            this.tbVacUsed.TabIndex = 46;
            // 
            // lblHrsWorked
            // 
            this.lblHrsWorked.AutoSize = true;
            this.lblHrsWorked.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsWorked.Location = new System.Drawing.Point(284, 197);
            this.lblHrsWorked.Name = "lblHrsWorked";
            this.lblHrsWorked.Size = new System.Drawing.Size(184, 34);
            this.lblHrsWorked.TabIndex = 45;
            this.lblHrsWorked.Text = "Hours Worked";
            // 
            // tbHrsWorked
            // 
            this.tbHrsWorked.Enabled = false;
            this.tbHrsWorked.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHrsWorked.Location = new System.Drawing.Point(290, 234);
            this.tbHrsWorked.Name = "tbHrsWorked";
            this.tbHrsWorked.Size = new System.Drawing.Size(213, 35);
            this.tbHrsWorked.TabIndex = 44;
            // 
            // cbBonus
            // 
            this.cbBonus.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.cbBonus.FormattingEnabled = true;
            this.cbBonus.Location = new System.Drawing.Point(811, 140);
            this.cbBonus.Name = "cbBonus";
            this.cbBonus.Size = new System.Drawing.Size(213, 35);
            this.cbBonus.TabIndex = 33;
            this.cbBonus.SelectionChangeCommitted += new System.EventHandler(this.cbBonus_SelectionChangeCommitted);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(902, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 42);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.Location = new System.Drawing.Point(28, 197);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(120, 34);
            this.lblWage.TabIndex = 31;
            this.lblWage.Text = "Wage/Hr";
            // 
            // tbWage
            // 
            this.tbWage.Enabled = false;
            this.tbWage.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWage.Location = new System.Drawing.Point(34, 234);
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(213, 35);
            this.tbWage.TabIndex = 30;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(540, 103);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(90, 34);
            this.lblPeriod.TabIndex = 29;
            this.lblPeriod.Text = "Period";
            // 
            // datePeriod
            // 
            this.datePeriod.CalendarFont = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.datePeriod.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.datePeriod.CalendarTitleBackColor = System.Drawing.Color.Honeydew;
            this.datePeriod.CustomFormat = "MMM/yyyy";
            this.datePeriod.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.datePeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePeriod.Location = new System.Drawing.Point(546, 140);
            this.datePeriod.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePeriod.Name = "datePeriod";
            this.datePeriod.Size = new System.Drawing.Size(213, 35);
            this.datePeriod.TabIndex = 28;
            this.datePeriod.Value = new System.DateTime(2023, 1, 21, 0, 0, 0, 0);
            // 
            // lblBnsName
            // 
            this.lblBnsName.AutoSize = true;
            this.lblBnsName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnsName.Location = new System.Drawing.Point(805, 103);
            this.lblBnsName.Name = "lblBnsName";
            this.lblBnsName.Size = new System.Drawing.Size(160, 34);
            this.lblBnsName.TabIndex = 27;
            this.lblBnsName.Text = "Bonus Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // navMarker
            // 
            this.navMarker.BackColor = System.Drawing.Color.Black;
            this.navMarker.Location = new System.Drawing.Point(786, 62);
            this.navMarker.Name = "navMarker";
            this.navMarker.Size = new System.Drawing.Size(54, 6);
            this.navMarker.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Poplar Std", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(614, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(92, 51);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Poplar Std", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(414, 11);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(134, 51);
            this.lblBonus.TabIndex = 2;
            this.lblBonus.Text = "Bonuses";
            this.lblBonus.Click += new System.EventHandler(this.lblBonus_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Poplar Std", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(179, 11);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(166, 51);
            this.lblEmp.TabIndex = 1;
            this.lblEmp.Text = "Employees";
            this.lblEmp.Click += new System.EventHandler(this.lblEmp_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Poplar Std", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(25, 11);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(97, 51);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Honeydew;
            this.panelTop.Controls.Add(this.ExitBox);
            this.panelTop.Controls.Add(this.navMarker);
            this.panelTop.Controls.Add(this.lblPay);
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.lblBonus);
            this.panelTop.Controls.Add(this.lblEmp);
            this.panelTop.Controls.Add(this.lblHome);
            this.panelTop.Location = new System.Drawing.Point(86, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1131, 68);
            this.panelTop.TabIndex = 17;
            // 
            // ExitBox
            // 
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(1079, 12);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(42, 42);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBox.TabIndex = 5;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Poplar Std", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(777, 11);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(73, 51);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Pay";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // navIndicator
            // 
            this.navIndicator.BackColor = System.Drawing.Color.Maroon;
            this.navIndicator.Location = new System.Drawing.Point(10, 483);
            this.navIndicator.Name = "navIndicator";
            this.navIndicator.Size = new System.Drawing.Size(72, 72);
            this.navIndicator.TabIndex = 54;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 717);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnBonus);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navIndicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvPayDetail;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.ComboBox cbEmpID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btnPay;
        private System.Windows.Forms.PictureBox btnTime;
        private System.Windows.Forms.PictureBox btnBonus;
        private System.Windows.Forms.PictureBox btnEmp;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel navMarker;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblBnsName;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker datePeriod;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbBonus;
        private System.Windows.Forms.Label lblVacUsed;
        private System.Windows.Forms.TextBox tbVacUsed;
        private System.Windows.Forms.Label lblHrsWorked;
        private System.Windows.Forms.TextBox tbHrsWorked;
        private System.Windows.Forms.Label lblBnsAmt;
        private System.Windows.Forms.TextBox tbBnsAmt;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox tbBal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel navIndicator;
    }
}