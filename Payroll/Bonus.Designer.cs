
namespace Payroll
{
    partial class Bonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonus));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvBDetail = new System.Windows.Forms.DataGridView();
            this.lblBName = new System.Windows.Forms.Label();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPay = new System.Windows.Forms.PictureBox();
            this.btnTime = new System.Windows.Forms.PictureBox();
            this.btnBonus = new System.Windows.Forms.PictureBox();
            this.btnEmp = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navMarker = new System.Windows.Forms.Panel();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblBAmount = new System.Windows.Forms.Label();
            this.tbBAmount = new System.Windows.Forms.TextBox();
            this.navIndicator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.panelMain.SuspendLayout();
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
            // dgvBDetail
            // 
            this.dgvBDetail.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvBDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBDetail.Location = new System.Drawing.Point(34, 364);
            this.dgvBDetail.Name = "dgvBDetail";
            this.dgvBDetail.ReadOnly = true;
            this.dgvBDetail.Size = new System.Drawing.Size(990, 290);
            this.dgvBDetail.TabIndex = 22;
            this.dgvBDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBDetail_CellContentClick);
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.Location = new System.Drawing.Point(28, 137);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(160, 34);
            this.lblBName.TabIndex = 7;
            this.lblBName.Text = "Bonus Name";
            // 
            // tbBName
            // 
            this.tbBName.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBName.Location = new System.Drawing.Point(34, 174);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(213, 35);
            this.tbBName.TabIndex = 0;
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
            // navMarker
            // 
            this.navMarker.BackColor = System.Drawing.Color.Black;
            this.navMarker.Location = new System.Drawing.Point(423, 62);
            this.navMarker.Name = "navMarker";
            this.navMarker.Size = new System.Drawing.Size(112, 6);
            this.navMarker.TabIndex = 4;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            this.ExitBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.lblBAmount);
            this.panelMain.Controls.Add(this.tbBAmount);
            this.panelMain.Controls.Add(this.btnClear);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.dgvBDetail);
            this.panelMain.Controls.Add(this.lblBName);
            this.panelMain.Controls.Add(this.tbBName);
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Location = new System.Drawing.Point(86, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 693);
            this.panelMain.TabIndex = 15;
            // 
            // lblBAmount
            // 
            this.lblBAmount.AutoSize = true;
            this.lblBAmount.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAmount.Location = new System.Drawing.Point(284, 137);
            this.lblBAmount.Name = "lblBAmount";
            this.lblBAmount.Size = new System.Drawing.Size(185, 34);
            this.lblBAmount.TabIndex = 28;
            this.lblBAmount.Text = "Bonus Amount";
            // 
            // tbBAmount
            // 
            this.tbBAmount.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBAmount.Location = new System.Drawing.Point(290, 174);
            this.tbBAmount.Name = "tbBAmount";
            this.tbBAmount.Size = new System.Drawing.Size(213, 35);
            this.tbBAmount.TabIndex = 1;
            // 
            // navIndicator
            // 
            this.navIndicator.BackColor = System.Drawing.Color.Maroon;
            this.navIndicator.Location = new System.Drawing.Point(10, 335);
            this.navIndicator.Name = "navIndicator";
            this.navIndicator.Size = new System.Drawing.Size(72, 72);
            this.navIndicator.TabIndex = 29;
            // 
            // Bonus
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
            this.Name = "Bonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvBDetail;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.TextBox tbBName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btnPay;
        private System.Windows.Forms.PictureBox btnTime;
        private System.Windows.Forms.PictureBox btnBonus;
        private System.Windows.Forms.PictureBox btnEmp;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel navMarker;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblBAmount;
        private System.Windows.Forms.TextBox tbBAmount;
        private System.Windows.Forms.Panel navIndicator;
    }
}