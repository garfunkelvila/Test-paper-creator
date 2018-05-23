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
    public partial class frmSectionPrecedence : Form {
        //public EventHandler Ready;
        public event EventHandler ready;
        public frmSectionPrecedence() {
            InitializeComponent();
        }
        //private dbDataSetTableAdapters.TypeOfTestsTableAdapter typesOfTestsTableAdapterMain;
        //private dbDataSet.TypeOfTestsDataTable typesDt = new dbDataSet.TypeOfTestsDataTable();

        public List<SectionPrecedence> Sections = new List<SectionPrecedence>();

        private void frmSectionPrecedence_Load(object sender, EventArgs e) {
            //typesOfTestsTableAdapterMain = new dbDataSetTableAdapters.TypeOfTestsTableAdapter();
            //typesOfTestsTableAdapterMain.ClearBeforeFill = true;
            //typesOfTestsTableAdapterMain.Fill(typesDt);

            btnAdd.Enabled = false;
            btnRemove.Enabled = false;

            int i = 0;
            myEnum types = new myEnum();

            lstv1.Items.Clear();
            lstv2.Items.Clear();

            do {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = types.sectionTypesArray[i];
                lstv1.Items.Add(lvi);
            } while (++i < types.sectionTypesArray.Length);
            
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (numCount.Value == 0) {
                tltpMain.Show("Please select number of items", numCount,0);
                tltpMain.Show("Please select number of items", numCount);
                return;
            }
            
            ListViewItem tmp = new ListViewItem();
            tmp.Text = lstv1.SelectedItems[0].Text;
            tmp.SubItems.Add(numCount.Value + "");
            lstv2.Items.Add(tmp);
            lstv1.Items.RemoveAt(lstv1.SelectedIndices[0]);
            numCount.Value = 0;
        }
        private void lstv1_SelectedIndexChanged(object sender, EventArgs e) {
            btnAdd.Enabled = lstv1.SelectedIndices.Count == 1 ? true : false;
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            lstv1.Items.Add(lstv2.SelectedItems[0].Text);
            lstv2.Items.RemoveAt(lstv2.SelectedIndices[0]);
        }

        private void lstv2_SelectedIndexChanged(object sender, EventArgs e) {
            btnRemove.Enabled = lstv2.SelectedIndices.Count == 1 ? true : false;
        }

        private void btnOk_Click(object sender, EventArgs e) {
  
            foreach (ListViewItem item in lstv2.Items) {
                SectionPrecedence tmp = new SectionPrecedence();
                // tsanggala male dat kinuha ko sa database imbis na i parse -_-"
                switch (item.Text) {
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

                tmp.SectionCount = int.Parse(item.SubItems[1].Text);

                Sections.Add(tmp);
            }

            ready.Invoke();// raise only if really ready and not a cancel
            //this.Close();
        }
    }
}
