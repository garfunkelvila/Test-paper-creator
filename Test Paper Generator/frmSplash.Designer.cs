namespace Test_Paper_Creator {
    partial class frmSplash {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.tltpLogin = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewExam = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.pnlOpen = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerMedia = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright © 2016";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(3, 88);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(3);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Location = new System.Drawing.Point(12, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 125);
            this.panel1.TabIndex = 3;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.button5);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txbPassword);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.txbUserName);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Location = new System.Drawing.Point(414, 3);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(318, 119);
            this.pnlLogin.TabIndex = 4;
            this.pnlLogin.Visible = false;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(240, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Quit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(159, 93);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txbPassword.Location = new System.Drawing.Point(82, 29);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(233, 20);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password";
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txbUserName.Location = new System.Drawing.Point(82, 3);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(233, 20);
            this.txbUserName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Name:";
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 10;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Interval = 10;
            this.tmrFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // tltpLogin
            // 
            this.tltpLogin.IsBalloon = true;
            this.tltpLogin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnNewExam
            // 
            this.btnNewExam.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewExam.Location = new System.Drawing.Point(215, 3);
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(100, 23);
            this.btnNewExam.TabIndex = 2;
            this.btnNewExam.Text = "New Exam";
            this.btnNewExam.UseVisualStyleBackColor = false;
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(215, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(206, 110);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label1";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(215, 61);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(100, 23);
            this.btnAccounts.TabIndex = 4;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // pnlOpen
            // 
            this.pnlOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOpen.Controls.Add(this.btnAccounts);
            this.pnlOpen.Controls.Add(this.lblName);
            this.pnlOpen.Controls.Add(this.btnCancel);
            this.pnlOpen.Controls.Add(this.btnNewExam);
            this.pnlOpen.Location = new System.Drawing.Point(12, 121);
            this.pnlOpen.Name = "pnlOpen";
            this.pnlOpen.Size = new System.Drawing.Size(318, 119);
            this.pnlOpen.TabIndex = 4;
            this.pnlOpen.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(735, 245);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            // 
            // timerMedia
            // 
            this.timerMedia.Enabled = true;
            this.timerMedia.Tick += new System.EventHandler(this.timerMedia_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIDEO REMOVED";
            // 
            // frmSplash
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.CancelButton = this.button5;
            this.ClientSize = new System.Drawing.Size(759, 399);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pnlOpen);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Paper Generator";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlOpen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.ToolTip tltpLogin;
        private System.Windows.Forms.Button btnNewExam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Panel pnlOpen;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timerMedia;
        private System.Windows.Forms.Label label1;
    }
}