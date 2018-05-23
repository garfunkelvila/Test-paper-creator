using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator.Forms.ExamEditorForms {
    public partial class frmExamNumbering : Form {
        public event EventHandler ready;
        public List<SectionPrecedence> Sections = new List<SectionPrecedence>();

        public frmExamNumbering() {
            InitializeComponent();
        }

        private void frmExamNumbering_Load(object sender, EventArgs e) {
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            MessageBox.Show(this, "You will now add items", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SectionPrecedence tmp;

            if (numericUpDown1.Value > 0) {
                tmp = new SectionPrecedence();
                tmp.SectionType = sectionTypes.TrueFalse;
                tmp.SectionCount = (int)numericUpDown1.Value;
                Sections.Add(tmp);
            }
            if (numericUpDown2.Value > 0) {
                tmp = new SectionPrecedence();
                tmp.SectionType = sectionTypes.Identification;
                tmp.SectionCount = (int)numericUpDown2.Value;
                Sections.Add(tmp);
            }
            if (numericUpDown3.Value > 0) {
                tmp = new SectionPrecedence();
                tmp.SectionType = sectionTypes.MultipleChoice;
                tmp.SectionCount = (int)numericUpDown3.Value;
                Sections.Add(tmp);
            }
            if (numericUpDown4.Value > 0) {
                tmp = new SectionPrecedence();
                tmp.SectionType = sectionTypes.MatchingType;
                tmp.SectionCount = (int)numericUpDown4.Value;
                Sections.Add(tmp);
            }
            if (numericUpDown5.Value > 0) {
                tmp = new SectionPrecedence();
                tmp.SectionType = sectionTypes.Enumeration;
                tmp.SectionCount = (int)numericUpDown5.Value;
                Sections.Add(tmp);
            }
            if (numericUpDown6.Value > 0) {
                tmp = new SectionPrecedence();
                tmp.SectionType = sectionTypes.Essay;
                tmp.SectionCount = (int)numericUpDown6.Value;
                Sections.Add(tmp);
            }

            ready.Invoke();
        }
        #region
        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            numericUpDown1.Value = trackBar1.Value;
            //updateLabel(trackBar1);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            trackBar1.Value = (int) numericUpDown1.Value;
            updateLabel(numericUpDown1);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e) {
            numericUpDown2.Value = trackBar2.Value;
            //updateLabel(trackBar2);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            trackBar2.Value = (int)numericUpDown2.Value;
            updateLabel(numericUpDown2);
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e) {
            numericUpDown3.Value = trackBar3.Value;
            //updateLabel(trackBar3);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
            trackBar3.Value = (int)numericUpDown3.Value;
            updateLabel(numericUpDown3);
        }

        private void trackBar4_Scroll(object sender, EventArgs e) {
            numericUpDown4.Value = trackBar4.Value;
            //updateLabel(trackBar4);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e) {
            trackBar4.Value = (int)numericUpDown4.Value;
            updateLabel(numericUpDown4);
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e) {
            numericUpDown5.Value = trackBar5.Value;
            //updateLabel(trackBar5);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e) {
            trackBar5.Value = (int)numericUpDown5.Value;
            updateLabel(numericUpDown5);
        }

        private void trackBar6_ValueChanged(object sender, EventArgs e) {
            numericUpDown6.Value = trackBar6.Value;
            //updateLabel(trackBar6);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e) {
            trackBar6.Value = (int)numericUpDown6.Value;
            updateLabel(numericUpDown6);
        }

        private void numMaxQuestion_ValueChanged(object sender, EventArgs e) {
            updateLabel(numMaxQuestion);
        }

        private void updateLabel(IWin32Window target) {
            if (numMaxQuestion.Value == 0) {
                lblInfo.Text = "Please increase target size \nOver: " + Math.Abs(calcUnused());
                tltpMain.Show("Please increase target size", numMaxQuestion, 5000);
                tltpMain.Show("Please increase target size", numMaxQuestion, 5000);

                btnAdd.Enabled = false;
                return;
            }
            if (calcUnused() > 0) {
                lblInfo.Text = "Unused: " + calcUnused();
                tltpMain.Hide(this);
                btnAdd.Enabled = false;
            }
            else if (calcUnused() < 0) {
                lblInfo.Text = "Please lessen or increase target size\nOver: " + Math.Abs(calcUnused());
                tltpMain.Show("Above the target, please lessen or increase target size", target, 5000);
                tltpMain.Show("Above the target, please lessen or increase target size", target, 5000);
                btnAdd.Enabled = false;
            }
            else {
                lblInfo.Text = "Ready !!";
                tltpMain.Show("Ready !!", btnAdd, 5000);
                tltpMain.Show("Ready !!", btnAdd, 5000);
                btnAdd.Enabled = true;
            }
        }

        private decimal calcUnused() {
            return numMaxQuestion.Value-(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value);
        }

        #endregion
        private void btnApply(object sender, EventArgs e) {
            numMaxQuestion.Enabled = false;
            trackBar1.Maximum = (int) numMaxQuestion.Value;
            trackBar2.Maximum = (int) numMaxQuestion.Value;
            trackBar3.Maximum = (int) numMaxQuestion.Value;
            trackBar4.Maximum = (int) numMaxQuestion.Value;
            trackBar5.Maximum = (int) numMaxQuestion.Value;
            trackBar6.Maximum = (int) numMaxQuestion.Value;

            numericUpDown1.Maximum = numMaxQuestion.Value;
            numericUpDown2.Maximum = numMaxQuestion.Value;
            numericUpDown3.Maximum = numMaxQuestion.Value;
            numericUpDown4.Maximum = numMaxQuestion.Value;
            numericUpDown5.Maximum = numMaxQuestion.Value;
            numericUpDown6.Maximum = numMaxQuestion.Value;
        }

        
    }
}
