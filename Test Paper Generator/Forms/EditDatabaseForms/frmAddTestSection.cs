using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator {
    public partial class frmAddTestSection : Form {
        //private dbDataSetTableAdapters.TypeOfTestsTableAdapter TypeOfTestsTableAdapterMain;
        //private dbDataSet.TypeOfTestsDataTable TypeOfTestsDt = new dbDataSet.TypeOfTestsDataTable();

        public frmAddTestSection() {
            InitializeComponent();
        }

        private void frmAddTestSection_Load(object sender, EventArgs e) {
            //TypeOfTestsTableAdapterMain = new Test_Paper_Creator.dbDataSetTableAdapters.TypeOfTestsTableAdapter();
            //TypeOfTestsTableAdapterMain.ClearBeforeFill = true;

            //TypeOfTestsTableAdapterMain.Fill(TypeOfTestsDt);
            foreach (var item in new myEnum().sectionTypesArray) {
                lstbTestTypes.Items.Add(item);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (lstbTestTypes.SelectedItems.Count == 0) {
                MessageBox.Show("Please select a type of test");
            }
        }
    }
}
