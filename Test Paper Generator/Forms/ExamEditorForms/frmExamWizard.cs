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
    public partial class frmExamWizard : Form {
        public event EventHandler ready;
        //135, 12
        //private dbDataSetTableAdapters.TypeOfTestsTableAdapter typesOfTestsTableAdapterMain;
        //private dbDataSet.TypeOfTestsDataTable typesDt = new dbDataSet.TypeOfTestsDataTable();
        public List<SectionPrecedence> Sections = new List<SectionPrecedence>();

        List<CheckBox> chkBoxesList = new List<CheckBox>();
        List<string> typeList = new List<string>();
        int step = 1;

        public frmExamWizard() {
            InitializeComponent();
        }

        private void frmExamWizard_Load(object sender, EventArgs e) {
            //typesOfTestsTableAdapterMain = new dbDataSetTableAdapters.TypeOfTestsTableAdapter();
            //typesOfTestsTableAdapterMain.ClearBeforeFill = true;
            //typesOfTestsTableAdapterMain.Fill(typesDt);

            int i = 0;
            myEnum types = new myEnum();
            do {
                CheckBox chkb = new CheckBox();
                chkBoxesList.Add(chkb);
                chkb.Text = types.sectionTypesArray[i];
                chkb.Parent = pnlTypes;
            } while (++i < types.sectionTypesArray.Length);
        }

        private void btnNext_Click(object sender, EventArgs e) {

            switch (step) {
                case 1: // adding of types
                    foreach (CheckBox item in chkBoxesList) {
                        if (item.Checked) {
                            typeList.Add(item.Text);
                        }
                    }
                    step++;
                    //lblMessage.Text = "How many " + typeList[0] + " questions you will be adding?";
                    secondStep();
                    //typeList.RemoveAt(0);
                    panel1.Visible = false;
                    panel2.Location = panel1.Location;
                    panel2.Visible = true;

                    break;
                case 2: // adding of item counts
                    if (numItems.Value == 0) {
                        tltpMain.Show("Please enter the number of items", numItems, 0);
                        tltpMain.Show("Please enter the number of items", numItems);
                        return;
                    }
                    if (typeList.Count > 0) {
                        secondStep();
                    }
                    else {
                        step++;
                        MessageBox.Show(this,"You will now add items","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
                        this.Visible = false;
                        ready.Invoke();
                    }
                    break;
                default:
                    break;
            }
        }
        private void secondStep() {
            lblMessage.Text = "How many " + typeList[0] + " questions you will be adding?";


            //--------------------------
            SectionPrecedence tmp = new SectionPrecedence();
            // tsanggala male dat kinuha ko sa database imbis na i parse -_-"
            switch (typeList[0]) {
                case "True or False":
                    tmp.SectionType = sectionTypes.TrueFalse;
                    break;
                case "Identification":
                    tmp.SectionType = sectionTypes.Identification;
                    break;
                case "Multiple Choice":
                    tmp.SectionType = sectionTypes.MultipleChoice;
                    break;
                case "Matching Type":
                    tmp.SectionType = sectionTypes.MatchingType;
                    break;
                case "Enumeraion":
                    tmp.SectionType = sectionTypes.Enumeration;
                    break;
                case "Essay":
                    tmp.SectionType = sectionTypes.Essay;
                    break;
                default:
                    tmp.SectionType = sectionTypes.none;
                    break;
            }

            tmp.SectionCount = (int)numItems.Value;
            //--------------------------------------------

            Sections.Add(tmp);
            typeList.RemoveAt(0);
            //--------------------------
            numItems.Value = 0;
        }
    }
}
