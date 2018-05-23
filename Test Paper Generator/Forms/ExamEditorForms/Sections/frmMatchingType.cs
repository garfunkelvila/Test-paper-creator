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
using System.Diagnostics;

namespace Test_Paper_Creator {
    public partial class frmMatchingType : Form {
        public examSection _Section;
        public bool isEdit = true;
        public int _target;
        public bool isOk = false;
        public frmMatchingType() {
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
            _Section.Type = sectionTypes.MatchingType;
            //_Section.testNumber = 1;
            //_Section.testNumber = 1; // temporary

            List<string> questions = new List<string>();
            List<string> answers = new List<string>();
            List<string> choices = new List<string>();
            int index = 0;
            do {
                questions.Add(lstvQuestions.Items[index].SubItems[1].Text);
            } while (++index < lstvQuestions.Items.Count);
            index = 0;
            do {
                answers.Add(lstvQuestions.Items[index].SubItems[2].Text);
            } while (++index < lstvQuestions.Items.Count);
            index = 0;
            do {
                choices.Add(lstvQuestions.Items[0].SubItems[2].Text);
                lstvQuestions.Items.RemoveAt(0);
            } while (lstvQuestions.Items.Count != 0);
            //--------------------------------------------

            int q,c, number = 0;
            string[] choice;

            Random rnd = new Random();

            do {
                q = rnd.Next(0, questions.Count);
                c = rnd.Next(0, choices.Count);

                //MessageBox.Show("q = " + q + "; c = " + c);

                choice = new string[1] { Convert.ToChar(number + 97) + ". " + choices[c] };
                //MessageBox.Show(choices[c] + " : " +  c);
                choices.RemoveAt(c);

                _Section.AddQuestion(questions[q], ++number, answers[q], choice);
                //Debug.Write("questions[q]:" + questions[q]);
                //Debug.Write("number:" + number);
                //Debug.Write("answers[q]:" + answers[q]);
                //Debug.Write("choice[0]:" + choice[0]);
                
                questions.RemoveAt(q);
                answers.RemoveAt(q);
                
            } while (questions.Count > 0);

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

            if (txbAnswer.Text.Length == 0) {
                tltpMain.Show("Please select an answer", txbAnswer);
                tltpMain.Show("Please select an answer", txbAnswer);
                return;
            }



            ListViewItem li = new ListViewItem();
            li.Text = "#";
            li.SubItems.Add(txbQuestion.Text);
            li.SubItems.Add(txbAnswer.Text);

            lstvQuestions.Items.Add(li);
            txbQuestion.Clear();
            txbQuestion.Focus();
            txbAnswer.Clear();
            lblCurrent.Text = "Current: " + lstvQuestions.Items.Count;
            if (lstvQuestions.Items.Count == _target) {
                btnOk.Enabled = true;
            }
            else {
                btnOk.Enabled = false;
            }

        }

        private void frmMatchingType_FormClosing(object sender, FormClosingEventArgs e) {
            if (isOk != true) {
                if (MessageBox.Show(this, "Are you sure you want to cancel adding of questions?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No) {
                    e.Cancel = true;
                }
                else {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void frmMatchingType_Load(object sender, EventArgs e) {
            lblTarget.Text = "Targert count: 0" + _target;
            btnOk.Enabled = false;
        }

        private void lstvQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            if(lstvQuestions.SelectedItems.Count > 0) {
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
