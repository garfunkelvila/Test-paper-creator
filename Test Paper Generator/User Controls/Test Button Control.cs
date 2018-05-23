using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Test_Paper_Creator.User_Controls {
    public partial class Test_Button_Control : UserControl {
        int _testNumber;
        //public event EventHandler contentUpdated;
        //public event EventHandler doneAdding;
        //public event EventHandler finished;
        public bool canceled = false;
        public Test_Button_Control(int TestNumber) {
            InitializeComponent();
        }

        public void InitializeRoutine(ref int TestNumber, FlowLayoutPanel parent, SectionPrecedence item, int target) {
            //Debug.Print("Temporary, also get type as parameter");

            switch (item.SectionType) {
                case sectionTypes.none:
                    MessageBox.Show("This shouldnt show");
                    //SectionForm = new frmAddTestSection();
                    break;
                case sectionTypes.TrueFalse:
                    //startTrueOrFalse(item.SectionCount);
                    frmTrueFalse TrueFalseForm = new frmTrueFalse();
                    TrueFalseForm._Section = new htmlBuilderClass.examSection();
                    TrueFalseForm._Section.testNumber = TestNumber;
                    TrueFalseForm._target = item.SectionCount;
                    _testNumber = TestNumber;
                    TrueFalseForm.isEdit = false;

                    if (TrueFalseForm.ShowDialog() == DialogResult.Cancel) {
                        canceled = true;
                        this.Dispose();
                        return;
                    }
                    else {
                        TestNumber++;
                        this.Parent = parent;
                        return;
                    }
                    //break;
                case sectionTypes.Identification:
                    frmIdentification IdentificationForm = new frmIdentification();
                    IdentificationForm._Section = new htmlBuilderClass.examSection();
                    IdentificationForm._Section.testNumber = TestNumber;
                    IdentificationForm._target = item.SectionCount;
                    _testNumber = TestNumber;
                    IdentificationForm.isEdit = false;

                    if (IdentificationForm.ShowDialog() == DialogResult.Cancel) {
                        canceled = true;
                        this.Dispose();
                        return;
                    }
                    else {
                        TestNumber++;
                        this.Parent = parent;
                        return;
                    }
                    //break;
                case sectionTypes.MultipleChoice:
                    frmMultipleChoice MultipleChoiceForm = new frmMultipleChoice();
                    MultipleChoiceForm._Section = new htmlBuilderClass.examSection();
                    MultipleChoiceForm._Section.testNumber = TestNumber;
                    MultipleChoiceForm._target = item.SectionCount;
                    _testNumber = TestNumber;
                    MultipleChoiceForm.isEdit = false;

                    if (MultipleChoiceForm.ShowDialog() == DialogResult.Cancel) {
                        canceled = true;
                        this.Dispose();
                        return;
                    }
                    else {
                        TestNumber++;
                        this.Parent = parent;
                        return;
                    }
                case sectionTypes.MatchingType:
                    //MessageBox.Show("Matching not yet ready");
                    frmMatchingType MatchingTypeForm = new frmMatchingType();
                    MatchingTypeForm._Section = new htmlBuilderClass.examSection();
                    MatchingTypeForm._Section.testNumber = TestNumber;
                    MatchingTypeForm._target = item.SectionCount;
                    _testNumber = TestNumber;
                    MatchingTypeForm.isEdit = false;

                    if (MatchingTypeForm.ShowDialog() == DialogResult.Cancel) {
                        canceled = true;
                        this.Dispose();
                        return;
                    }
                    else {
                        TestNumber++;
                        this.Parent = parent;
                        return;
                    }
                case sectionTypes.Enumeration:
                    frmEnumeration EnumerationForm = new frmEnumeration();
                    EnumerationForm._Section = new htmlBuilderClass.examSection();
                    EnumerationForm._Section.testNumber = TestNumber;
                    EnumerationForm._target = item.SectionCount;
                    _testNumber = TestNumber;
                    EnumerationForm.isEdit = false;

                    if (EnumerationForm.ShowDialog() == DialogResult.Cancel) {
                        canceled = true;
                        this.Dispose();
                        return;
                    }
                    else {
                        TestNumber++;
                        this.Parent = parent;
                        return;
                    }
                case sectionTypes.Essay:
                    frmEssay EssayForm = new frmEssay();
                    EssayForm._Section = new htmlBuilderClass.examSection();
                    EssayForm._Section.testNumber = TestNumber;
                    EssayForm._target = item.SectionCount;
                    _testNumber = TestNumber;
                    EssayForm.isEdit = false;

                    if (EssayForm.ShowDialog() == DialogResult.Cancel) {
                        canceled = true;
                        this.Dispose();
                        return;
                    }
                    else {
                        TestNumber++;
                        this.Parent = parent;
                        return;
                    }
                    
                default:
                    MessageBox.Show("An error occured");
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnEdit_Click(object sender, EventArgs e) {
            frmTrueFalse TrueFalseForm = new frmTrueFalse();
            TrueFalseForm._Section = new htmlBuilderClass.examSection();
            TrueFalseForm._Section.testNumber = _testNumber;
            TrueFalseForm.isEdit = true;
            TrueFalseForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            this.Dispose();
        }
        
        #region properties
        public int TestNumber {
            set {
                _testNumber = value;
            }
            get {
                return _testNumber;
            }
        }
        #endregion
    }
}
