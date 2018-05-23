namespace Test_Paper_Creator.Forms.ExamEditorForms {
    partial class frmSectionPrecedence {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "try",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "try",
            "15"}, -1);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lstv2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(219, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "<< Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(425, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstv2
            // 
            this.lstv2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstv2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstv2.Location = new System.Drawing.Point(300, 34);
            this.lstv2.MultiSelect = false;
            this.lstv2.Name = "lstv2";
            this.lstv2.Size = new System.Drawing.Size(200, 147);
            this.lstv2.TabIndex = 2;
            this.lstv2.UseCompatibleStateImageBehavior = false;
            this.lstv2.View = System.Windows.Forms.View.Details;
            this.lstv2.SelectedIndexChanged += new System.EventHandler(this.lstv2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 48;
            // 
            // lstv1
            // 
            this.lstv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lstv1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lstv1.Location = new System.Drawing.Point(13, 34);
            this.lstv1.MultiSelect = false;
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new System.Drawing.Size(200, 147);
            this.lstv1.TabIndex = 2;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = System.Windows.Forms.View.Details;
            this.lstv1.SelectedIndexChanged += new System.EventHandler(this.lstv1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 124;
            // 
            // numCount
            // 
            this.numCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCount.Location = new System.Drawing.Point(219, 90);
            this.numCount.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(75, 20);
            this.numCount.TabIndex = 3;
            // 
            // tltpMain
            // 
            this.tltpMain.IsBalloon = true;
            this.tltpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tltpMain.ToolTipTitle = "Error";
            // 
            // frmSectionPrecedence
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 244);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.lstv1);
            this.Controls.Add(this.lstv2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSectionPrecedence";
            this.Text = "Section Precedence";
            this.Load += new System.EventHandler(this.frmSectionPrecedence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView lstv2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstv1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.ToolTip tltpMain;
    }
}