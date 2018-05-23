namespace Test_Paper_Creator.Forms.UserManager
{
    partial class frmUserProperties
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            this.txbMiddleName = new System.Windows.Forms.TextBox();
            this.txbFamilyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSuffix = new System.Windows.Forms.TextBox();
            this.txbPrefx = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.cmbAccess = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Given Name";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(58, 31);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(184, 20);
            this.txbFirstName.TabIndex = 1;
            // 
            // txbMiddleName
            // 
            this.txbMiddleName.Location = new System.Drawing.Point(248, 31);
            this.txbMiddleName.Name = "txbMiddleName";
            this.txbMiddleName.Size = new System.Drawing.Size(184, 20);
            this.txbMiddleName.TabIndex = 2;
            // 
            // txbFamilyName
            // 
            this.txbFamilyName.Location = new System.Drawing.Point(438, 31);
            this.txbFamilyName.Name = "txbFamilyName";
            this.txbFamilyName.Size = new System.Drawing.Size(184, 20);
            this.txbFamilyName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Family Name";
            // 
            // txbSuffix
            // 
            this.txbSuffix.Location = new System.Drawing.Point(628, 31);
            this.txbSuffix.Name = "txbSuffix";
            this.txbSuffix.Size = new System.Drawing.Size(40, 20);
            this.txbSuffix.TabIndex = 4;
            this.txbSuffix.TabStop = false;
            this.txbSuffix.Enter += new System.EventHandler(this.txbSuffix_Enter);
            // 
            // txbPrefx
            // 
            this.txbPrefx.Location = new System.Drawing.Point(12, 31);
            this.txbPrefx.Name = "txbPrefx";
            this.txbPrefx.Size = new System.Drawing.Size(40, 20);
            this.txbPrefx.TabIndex = 0;
            this.txbPrefx.TabStop = false;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(58, 119);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(184, 20);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbPassword2
            // 
            this.txbPassword2.Location = new System.Drawing.Point(248, 119);
            this.txbPassword2.Name = "txbPassword2";
            this.txbPassword2.Size = new System.Drawing.Size(184, 20);
            this.txbPassword2.TabIndex = 7;
            this.txbPassword2.UseSystemPasswordChar = true;
            this.txbPassword2.TextChanged += new System.EventHandler(this.txbPassword2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Password";
            // 
            // lblCheck
            // 
            this.lblCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(438, 122);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(10, 13);
            this.lblCheck.TabIndex = 0;
            this.lblCheck.Text = "-";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(593, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "UserName";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(58, 80);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(184, 20);
            this.txbUserName.TabIndex = 5;
            // 
            // cmbAccess
            // 
            this.cmbAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccess.FormattingEnabled = true;
            this.cmbAccess.Items.AddRange(new object[] {
            "Employee",
            "Admin"});
            this.cmbAccess.Location = new System.Drawing.Point(438, 80);
            this.cmbAccess.Name = "cmbAccess";
            this.cmbAccess.Size = new System.Drawing.Size(121, 21);
            this.cmbAccess.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prefix";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Suffix";
            // 
            // frmUserProperties
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 151);
            this.Controls.Add(this.cmbAccess);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbPassword2);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbPrefx);
            this.Controls.Add(this.txbFamilyName);
            this.Controls.Add(this.txbMiddleName);
            this.Controls.Add(this.txbSuffix);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmUserProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.ToolTip tltpMain;
        private System.Windows.Forms.TextBox txbMiddleName;
        private System.Windows.Forms.TextBox txbFamilyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSuffix;
        private System.Windows.Forms.TextBox txbPrefx;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.ComboBox cmbAccess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}