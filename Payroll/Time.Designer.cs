
namespace Payroll
{
    partial class Time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTimeDetail = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPay = new System.Windows.Forms.PictureBox();
            this.btnTime = new System.Windows.Forms.PictureBox();
            this.btnBonus = new System.Windows.Forms.PictureBox();
            this.btnEmp = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.navMarker = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.datePeriod = new System.Windows.Forms.DateTimePicker();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblHrsWorked = new System.Windows.Forms.Label();
            this.tbHrsWorked = new System.Windows.Forms.TextBox();
            this.lblVacUsed = new System.Windows.Forms.Label();
            this.tbVacUsed = new System.Windows.Forms.TextBox();
            this.navIndicator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeDetail)).BeginInit();
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(902, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 42);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Honeydew;
            this.btnDelete.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(290, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 42);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Honeydew;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(34, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 42);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvTimeDetail
            // 
            this.dgvTimeDetail.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvTimeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeDetail.Location = new System.Drawing.Point(34, 364);
            this.dgvTimeDetail.Name = "dgvTimeDetail";
            this.dgvTimeDetail.ReadOnly = true;
            this.dgvTimeDetail.Size = new System.Drawing.Size(990, 290);
            this.dgvTimeDetail.TabIndex = 22;
            this.dgvTimeDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // btnPay
            // 
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(12, 485);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(68, 68);
            this.btnPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPay.TabIndex = 18;
            this.btnPay.TabStop = false;
            // 
            // btnTime
            // 
            this.btnTime.Image = ((System.Drawing.Image)(resources.GetObject("btnTime.Image")));
            this.btnTime.Location = new System.Drawing.Point(12, 411);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(68, 68);
            this.btnTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTime.TabIndex = 19;
            this.btnTime.TabStop = false;
            // 
            // btnBonus
            // 
            this.btnBonus.Image = ((System.Drawing.Image)(resources.GetObject("btnBonus.Image")));
            this.btnBonus.Location = new System.Drawing.Point(12, 337);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(68, 68);
            this.btnBonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBonus.TabIndex = 20;
            this.btnBonus.TabStop = false;
            // 
            // btnEmp
            // 
            this.btnEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnEmp.Image")));
            this.btnEmp.Location = new System.Drawing.Point(12, 263);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(68, 68);
            this.btnEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmp.TabIndex = 21;
            this.btnEmp.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 189);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 68);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 17;
            this.btnHome.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.lblVacUsed);
            this.panelMain.Controls.Add(this.tbVacUsed);
            this.panelMain.Controls.Add(this.lblHrsWorked);
            this.panelMain.Controls.Add(this.tbHrsWorked);
            this.panelMain.Controls.Add(this.lblPeriod);
            this.panelMain.Controls.Add(this.datePeriod);
            this.panelMain.Controls.Add(this.lblEmpID);
            this.panelMain.Controls.Add(this.cbEmpID);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.tbName);
            this.panelMain.Controls.Add(this.btnClear);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.dgvTimeDetail);
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Location = new System.Drawing.Point(86, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 693);
            this.panelMain.TabIndex = 14;
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
            this.navMarker.Location = new System.Drawing.Point(623, 62);
            this.navMarker.Name = "navMarker";
            this.navMarker.Size = new System.Drawing.Size(70, 6);
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
            this.panelTop.Controls.Add(this.navMarker);
            this.panelTop.Controls.Add(this.ExitBox);
            this.panelTop.Controls.Add(this.lblPay);
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.lblBonus);
            this.panelTop.Controls.Add(this.lblEmp);
            this.panelTop.Controls.Add(this.lblHome);
            this.panelTop.Location = new System.Drawing.Point(86, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1131, 68);
            this.panelTop.TabIndex = 16;
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
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(540, 103);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(90, 34);
            this.lblPeriod.TabIndex = 39;
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
            this.datePeriod.TabIndex = 38;
            this.datePeriod.Value = new System.DateTime(2023, 1, 21, 0, 0, 0, 0);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(28, 103);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(160, 34);
            this.lblEmpID.TabIndex = 35;
            this.lblEmpID.Text = "Employee ID";
            // 
            // cbEmpID
            // 
            this.cbEmpID.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(34, 140);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(213, 35);
            this.cbEmpID.TabIndex = 34;
            this.cbEmpID.SelectionChangeCommitted += new System.EventHandler(this.cbEmpID_SelectionChangeCommitted);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(284, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 34);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(290, 140);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(213, 35);
            this.tbName.TabIndex = 32;
            // 
            // lblHrsWorked
            // 
            this.lblHrsWorked.AutoSize = true;
            this.lblHrsWorked.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsWorked.Location = new System.Drawing.Point(28, 197);
            this.lblHrsWorked.Name = "lblHrsWorked";
            this.lblHrsWorked.Size = new System.Drawing.Size(184, 34);
            this.lblHrsWorked.TabIndex = 41;
            this.lblHrsWorked.Text = "Hours Worked";
            // 
            // tbHrsWorked
            // 
            this.tbHrsWorked.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHrsWorked.Location = new System.Drawing.Point(34, 234);
            this.tbHrsWorked.Name = "tbHrsWorked";
            this.tbHrsWorked.Size = new System.Drawing.Size(213, 35);
            this.tbHrsWorked.TabIndex = 40;
            // 
            // lblVacUsed
            // 
            this.lblVacUsed.AutoSize = true;
            this.lblVacUsed.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacUsed.Location = new System.Drawing.Point(284, 197);
            this.lblVacUsed.Name = "lblVacUsed";
            this.lblVacUsed.Size = new System.Drawing.Size(201, 34);
            this.lblVacUsed.TabIndex = 43;
            this.lblVacUsed.Text = "Vacations Hours";
            // 
            // tbVacUsed
            // 
            this.tbVacUsed.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVacUsed.Location = new System.Drawing.Point(290, 234);
            this.tbVacUsed.Name = "tbVacUsed";
            this.tbVacUsed.Size = new System.Drawing.Size(213, 35);
            this.tbVacUsed.TabIndex = 42;
            // 
            // navIndicator
            // 
            this.navIndicator.BackColor = System.Drawing.Color.Maroon;
            this.navIndicator.Location = new System.Drawing.Point(10, 409);
            this.navIndicator.Name = "navIndicator";
            this.navIndicator.Size = new System.Drawing.Size(72, 72);
            this.navIndicator.TabIndex = 44;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 717);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnBonus);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navIndicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeDetail)).EndInit();
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

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvTimeDetail;
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
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker datePeriod;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.ComboBox cbEmpID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblVacUsed;
        private System.Windows.Forms.TextBox tbVacUsed;
        private System.Windows.Forms.Label lblHrsWorked;
        private System.Windows.Forms.TextBox tbHrsWorked;
        private System.Windows.Forms.Panel navIndicator;
    }
}