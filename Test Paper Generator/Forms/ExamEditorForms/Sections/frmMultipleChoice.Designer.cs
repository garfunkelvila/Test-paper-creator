namespace Test_Paper_Creator {
    partial class frmMultipleChoice {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultipleChoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstvQuestions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTarget = new System.Windows.Forms.ToolStripLabel();
            this.lblCurr = new System.Windows.Forms.ToolStripLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQuestion = new System.Windows.Forms.TextBox();
            this.txbInstruction = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbAns1 = new System.Windows.Forms.TextBox();
            this.txbAns2 = new System.Windows.Forms.TextBox();
            this.txbAns3 = new System.Windows.Forms.TextBox();
            this.txbAns4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lstvQuestions);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 193);
            this.panel1.TabIndex = 12;
            // 
            // lstvQuestions
            // 
            this.lstvQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvQuestions.FullRowSelect = true;
            this.lstvQuestions.Location = new System.Drawing.Point(0, 45);
            this.lstvQuestions.Name = "lstvQuestions";
            this.lstvQuestions.Size = new System.Drawing.Size(760, 148);
            this.lstvQuestions.TabIndex = 3;
            this.lstvQuestions.UseCompatibleStateImageBehavior = false;
            this.lstvQuestions.View = System.Windows.Forms.View.Details;
            this.lstvQuestions.SelectedIndexChanged += new System.EventHandler(this.lstvQuestions_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Question";
            this.columnHeader2.Width = 363;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Answer";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Extra 1";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Extra 2";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Extra 3";
            this.columnHeader6.Width = 83;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete,
            this.toolStripSeparator1,
            this.lblTarget,
            this.lblCurr});
            this.toolStrip1.Location = new System.Drawing.Point(0, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::Test_Paper_Creator.Properties.Resources.Remove_icon;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 22);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTarget
            // 
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(88, 22);
            this.lblTarget.Text = "Target Count: 0";
            // 
            // lblCurr
            // 
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(93, 22);
            this.lblCurr.Text = "Current count: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Questions";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Question";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instruction:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbQuestion
            // 
            this.txbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuestion.Location = new System.Drawing.Point(12, 140);
            this.txbQuestion.Name = "txbQuestion";
            this.txbQuestion.Size = new System.Drawing.Size(550, 20);
            this.txbQuestion.TabIndex = 1;
            // 
            // txbInstruction
            // 
            this.txbInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInstruction.Location = new System.Drawing.Point(12, 32);
            this.txbInstruction.Multiline = true;
            this.txbInstruction.Name = "txbInstruction";
            this.txbInstruction.Size = new System.Drawing.Size(760, 82);
            this.txbInstruction.TabIndex = 0;
            this.txbInstruction.Text = "Multiple Choice";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(697, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(616, 426);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(697, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbAns1
            // 
            this.txbAns1.Location = new System.Drawing.Point(568, 140);
            this.txbAns1.Name = "txbAns1";
            this.txbAns1.Size = new System.Drawing.Size(123, 20);
            this.txbAns1.TabIndex = 2;
            this.txbAns1.TextChanged += new System.EventHandler(this.txbAns1_TextChanged);
            // 
            // txbAns2
            // 
            this.txbAns2.Location = new System.Drawing.Point(6, 19);
            this.txbAns2.Name = "txbAns2";
            this.txbAns2.Size = new System.Drawing.Size(100, 20);
            this.txbAns2.TabIndex = 0;
            // 
            // txbAns3
            // 
            this.txbAns3.Location = new System.Drawing.Point(112, 19);
            this.txbAns3.Name = "txbAns3";
            this.txbAns3.Size = new System.Drawing.Size(100, 20);
            this.txbAns3.TabIndex = 1;
            // 
            // txbAns4
            // 
            this.txbAns4.Location = new System.Drawing.Point(218, 19);
            this.txbAns4.Name = "txbAns4";
            this.txbAns4.Size = new System.Drawing.Size(100, 20);
            this.txbAns4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbAns3);
            this.groupBox1.Controls.Add(this.txbAns2);
            this.groupBox1.Controls.Add(this.txbAns4);
            this.groupBox1.Location = new System.Drawing.Point(15, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(565, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Answer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tltpMain
            // 
            this.tltpMain.IsBalloon = true;
            this.tltpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltpMain.ToolTipTitle = "Information";
            // 
            // frmMultipleChoice
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txbAns1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbQuestion);
            this.Controls.Add(this.txbInstruction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultipleChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Choice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMultipleChoice_FormClosing);
            this.Load += new System.EventHandler(this.frmMultipleChoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstvQuestions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQuestion;
        private System.Windows.Forms.TextBox txbInstruction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbAns1;
        private System.Windows.Forms.TextBox txbAns2;
        private System.Windows.Forms.TextBox txbAns3;
        private System.Windows.Forms.TextBox txbAns4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tltpMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTarget;
        private System.Windows.Forms.ToolStripLabel lblCurr;
    }
}