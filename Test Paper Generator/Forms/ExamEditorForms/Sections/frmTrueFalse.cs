using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Test_Paper_Creator.User_Controls.htmlBuilderClass;

namespace Test_Paper_Creator {
    public partial class frmTrueFalse : Form {
        public examSection _Section;
        public bool isEdit = true;
        public int _target;
        public bool isOk = false;
        public frmTrueFalse() {
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e) {
            if (lstvQuestions.Items.Count == 0) {
                tltpMain.Show("The questions are empty, please add a question", btnAdd);
                tltpMain.Show("The questions are empty, please add a question", btnAdd);
                return;
            }

            //examSection Section = new examSection();
            _Section.instruction = txbInstruction.Text;
            _Section.Type = sectionTypes.TrueFalse;
            //_Section.testNumber = 1;
            //_Section.testNumber = 1; // temporary


            int i, number = 0;
            Random rnd = new Random();
            do {
                i = rnd.Next(0, lstvQuestions.Items.Count - 1);
                _Section.AddQuestion(lstvQuestions.Items[i].SubItems[1].Text, ++number, lstvQuestions.Items[i].SubItems[2].Text);
                lstvQuestions.Items.RemoveAt(i);
            } while (lstvQuestions.Items.Count > 0);

            //Debug.Print("THIS IS WROOOOOONG !!!!!!!!!!!!");
            if (isEdit == true) {
                Debug.Print("_Section.testNumber: " + _Section.testNumber);
                Program.myHtmlbuilder.editSection(_Section.testNumber, _Section);
            }
            else {
                Program.myHtmlbuilder.addSection(_Section);
            }

            //btnOkPressed.Invoke();
            isOk = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (txbQuestion.Text.Length == 0) {
                tltpMain.Show("The question is empty, please add a question", txbQuestion);
                tltpMain.Show("The question is empty, please add a question", txbQuestion);
                return;
            }

            if (cmbAnswer.SelectedIndex  == 0) {
                tltpMain.Show("Please select an answer", cmbAnswer);
                tltpMain.Show("Please select an answer", cmbAnswer);
                return;
            }

            

            ListViewItem li = new ListViewItem();
            li.Text = "#";
            li.SubItems.Add(txbQuestion.Text);
            li.SubItems.Add(cmbAnswer.Text);
            //li.SubItems.Add(numPoints.Value.ToString());
                        
            lstvQuestions.Items.Add(li);

            lblCurrent.Text = "Current: " + lstvQuestions.Items.Count;
            if (lstvQuestions.Items.Count == _target) {
                btnOk.Enabled = true;
            }
            else {
                btnOk.Enabled = false;
            }

            txbQuestion.Clear();
            txbQuestion.Focus();
            cmbAnswer.SelectedIndex = 0;
            //numPoints.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            //delete recently added
        }

        private void btnNext_Click(object sender, EventArgs e) {
            True_False.frmGenTrueFalse tmp = new True_False.frmGenTrueFalse();
            tmp.ShowDialog();
        }

        private void frmTrueFalse_Load(object sender, EventArgs e) {
            cmbAnswer.SelectedIndex = 0;
            lblTarget.Text = "Target count: " + _target;
            btnOk.Enabled = false;
        }

        private void frmTrueFalse_FormClosing(object sender, FormClosingEventArgs e) {
            if (isOk != true) {
                if (MessageBox.Show(this,"Are you sure you want to cancel adding of questions?","Are you sure?",MessageBoxButtons.YesNo) == DialogResult.No) {
                    e.Cancel = true;
                }
                else {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            
        }

        private void lstvQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstvQuestions.SelectedItems.Count > 0) {
                btnDelete.Enabled = true;
            }
            else {
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            lstvQuestions.Items.Remove(lstvQuestions.FocusedItem);
        }
    }
}
