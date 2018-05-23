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
    public partial class frmMultipleChoice : Form {
        public examSection _Section;
        public bool isEdit = true;
        public bool isOk = false;
        public int _target;
        public frmMultipleChoice() {
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
            _Section.Type = sectionTypes.MultipleChoice;
            //_Section.testNumber = 1;
            //_Section.testNumber = 1; // temporary

            int number = 0;
            Random rnd = new Random();
            //int i = 0;
            do {
                int i = rnd.Next(0,lstvQuestions.Items.Count-1);
                List<string> bb = new List<string> { lstvQuestions.Items[i].SubItems[2].Text , lstvQuestions.Items[i].SubItems[3].Text , lstvQuestions.Items[i].SubItems[4].Text , lstvQuestions.Items[i].SubItems[5].Text };
                List<string> aa = new List<string>();
                string ans = lstvQuestions.Items[i].SubItems[2].Text;
                bool isPicked = false;
                do {
                    int ii = rnd.Next(0, bb.Count- 1);
                    if (bb[ii] == ans && isPicked == false) {
                        if (aa.Count == 0) ans = "a. " + ans;
                        if (aa.Count == 1) ans = "b. " + ans;
                        if (aa.Count == 2) ans = "c. " + ans;
                        if (aa.Count == 3) ans = "d. " + ans;
                        isPicked = true;
                    }
                    aa.Add(bb[ii]);
                    bb.RemoveAt(ii);
                } while (bb.Count > 0);


                _Section.AddQuestion(lstvQuestions.Items[i].SubItems[1].Text, ++number, ans, aa.ToArray());
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

            if (txbAns1.Text.Length == 0) {
                tltpMain.Show("The answer is empty, please enter the answer", txbAns1);
                tltpMain.Show("The answer is empty, please enter the answer", txbAns1);
                return;
            }

            if (txbAns2.Text.Length == 0) {
                tltpMain.Show("The extra is empty, please add an extra", txbAns2);
                tltpMain.Show("The extra is empty, please add an extra", txbAns2);
                return;
            }

            if (txbAns3.Text.Length == 0) {
                tltpMain.Show("The extra is empty, please add an extra", txbAns3);
                tltpMain.Show("The extra is empty, please add an extra", txbAns3);
                return;
            }

            if (txbAns4.Text.Length == 0) {
                tltpMain.Show("The extra is empty, please add an extra", txbAns4);
                tltpMain.Show("The extra is empty, please add an extra", txbAns4);
                return;
            }

            ListViewItem li = new ListViewItem();
            li.Text = "#";
            li.SubItems.Add(txbQuestion.Text);
            li.SubItems.Add(txbAns1.Text);
            li.SubItems.Add(txbAns2.Text);
            li.SubItems.Add(txbAns3.Text);
            li.SubItems.Add(txbAns4.Text);
            lstvQuestions.Items.Add(li);
            txbAns1.Clear();
            txbAns2.Clear();
            txbAns3.Clear();
            txbAns4.Clear();
            txbQuestion.Clear();
            txbQuestion.Focus();
            lblCurr.Text = "Current: " + lstvQuestions.Items.Count;
            if (lstvQuestions.Items.Count == _target) {
                btnOk.Enabled = true;
            }
            else {
                btnOk.Enabled = false;
            }
        }

        private void frmMultipleChoice_Load(object sender, EventArgs e) {
            lblTarget.Text = "Target count: " + _target;
            btnOk.Enabled = false;
        }

        private void txbAns1_TextChanged(object sender, EventArgs e) {

        }

        private void frmMultipleChoice_FormClosing(object sender, FormClosingEventArgs e) {
            if (isOk != true) {
                if (MessageBox.Show(this, "Are you sure you want to cancel adding of questions?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No) {
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
