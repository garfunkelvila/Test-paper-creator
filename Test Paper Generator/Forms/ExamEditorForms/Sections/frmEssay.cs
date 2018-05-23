using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Paper_Creator.User_Controls.htmlBuilderClass;

namespace Test_Paper_Creator {
    public partial class frmEssay : Form {
        public examSection _Section;
        public bool isEdit = true;
        public bool isOk = false;
        public int _target;
        public frmEssay() {
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
            _Section.Type = sectionTypes.Essay;
            //_Section.testNumber = 1;
            //_Section.testNumber = 1; // temporary


            int i, number = 0;
            do {
                i = new Random().Next(0, lstvQuestions.Items.Count - 1);

                _Section.AddQuestion(lstvQuestions.Items[i].SubItems[1].Text, ++number);
                lstvQuestions.Items.RemoveAt(i);
            } while (lstvQuestions.Items.Count > 0);

            //Debug.Print("THIS IS WROOOOOONG !!!!!!!!!!!!");
            if (isEdit == true) {
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

            ListViewItem li = new ListViewItem();
            li.Text = "#";
            li.SubItems.Add(txbQuestion.Text);
            li.SubItems.Add(numericUpDown1.Value.ToString());
            lstvQuestions.Items.Add(li);
            txbQuestion.Clear();
            txbQuestion.Focus();
            numericUpDown1.Value = 5;


            //--- TOTAL COunts
            int cur = 0;
            foreach (ListViewItem item in lstvQuestions.Items) {
                cur += int.Parse(item.SubItems[2].Text);
            }

            lblCurrent.Text = "Current: " + cur;
            if (cur == _target) {
                btnOk.Enabled = true;
            }
            else {
                btnOk.Enabled = false;
            }
        }

        private void frmEssay_FormClosing(object sender, FormClosingEventArgs e) {
            if (isOk != true) {
                if (MessageBox.Show(this, "Are you sure you want to cancel adding of questions?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No) {
                    e.Cancel = true;
                }
                else {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void frmEssay_Load(object sender, EventArgs e) {
            lblTarget.Text = "Target count: " + _target;
            btnOk.Enabled = false;
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
