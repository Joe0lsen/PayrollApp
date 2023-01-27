
namespace Payroll
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.navMarker = new System.Windows.Forms.Panel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnEmp = new System.Windows.Forms.PictureBox();
            this.btnBonus = new System.Windows.Forms.PictureBox();
            this.btnDetail = new System.Windows.Forms.PictureBox();
            this.btnTime = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.navIndicator = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.lblStart);
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Location = new System.Drawing.Point(86, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 693);
            this.panelMain.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Honeydew;
            this.panelSide.Controls.Add(this.lblWelcome);
            this.panelSide.Location = new System.Drawing.Point(86, 77);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(236, 628);
            this.panelSide.TabIndex = 0;
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
            this.panelTop.TabIndex = 1;
            // 
            // navMarker
            // 
            this.navMarker.BackColor = System.Drawing.Color.Black;
            this.navMarker.Location = new System.Drawing.Point(34, 62);
            this.navMarker.Name = "navMarker";
            this.navMarker.Size = new System.Drawing.Size(74, 6);
            this.navMarker.TabIndex = 3;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 189);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 68);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            // 
            // btnEmp
            // 
            this.btnEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnEmp.Image")));
            this.btnEmp.Location = new System.Drawing.Point(12, 263);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(68, 68);
            this.btnEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmp.TabIndex = 3;
            this.btnEmp.TabStop = false;
            // 
            // btnBonus
            // 
            this.btnBonus.Image = ((System.Drawing.Image)(resources.GetObject("btnBonus.Image")));
            this.btnBonus.Location = new System.Drawing.Point(12, 411);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(68, 68);
            this.btnBonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBonus.TabIndex = 3;
            this.btnBonus.TabStop = false;
            // 
            // btnDetail
            // 
            this.btnDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.Image")));
            this.btnDetail.Location = new System.Drawing.Point(12, 337);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(68, 68);
            this.btnDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDetail.TabIndex = 4;
            this.btnDetail.TabStop = false;
            // 
            // btnTime
            // 
            this.btnTime.Image = ((System.Drawing.Image)(resources.GetObject("btnTime.Image")));
            this.btnTime.Location = new System.Drawing.Point(12, 485);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(68, 68);
            this.btnTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTime.TabIndex = 3;
            this.btnTime.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(12, 559);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(68, 68);
            this.btnPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPay.TabIndex = 3;
            this.btnPay.TabStop = false;
            // 
            // navIndicator
            // 
            this.navIndicator.BackColor = System.Drawing.Color.Maroon;
            this.navIndicator.Location = new System.Drawing.Point(10, 187);
            this.navIndicator.Name = "navIndicator";
            this.navIndicator.Size = new System.Drawing.Size(72, 72);
            this.navIndicator.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Poplar Std", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lblWelcome.Location = new System.Drawing.Point(43, 78);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(145, 306);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome\r\nto\r\nKnome\r\nPayroll\r\nSystem\r\n1.0!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Italic);
            this.lblStart.ForeColor = System.Drawing.Color.Black;
            this.lblStart.Location = new System.Drawing.Point(376, 233);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(535, 86);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "To get started,\r\nselect one of the tabs above";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 717);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnBonus);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navIndicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnEmp;
        private System.Windows.Forms.PictureBox btnBonus;
        private System.Windows.Forms.PictureBox btnDetail;
        private System.Windows.Forms.PictureBox btnTime;
        private System.Windows.Forms.PictureBox btnPay;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBonus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel navMarker;
        private System.Windows.Forms.Panel navIndicator;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStart;
    }
}

