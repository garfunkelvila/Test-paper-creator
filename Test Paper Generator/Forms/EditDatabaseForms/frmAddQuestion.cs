using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator.EditDatabaseForms {
    public partial class frmAddQuestion : Form {
        //private dbDataSetTableAdapters.TypeOfTestsTableAdapter TypeOfTestsTableAdapterMain;
        //private dbDataSet.TypeOfTestsDataTable TypeOfTestsDt = new dbDataSet.TypeOfTestsDataTable();

        public frmAddQuestion() {
            InitializeComponent();
        }

        private void frmAddQuestion_Load(object sender, EventArgs e) {
            //TypeOfTestsTableAdapterMain = new Test_Paper_Creator.dbDataSetTableAdapters.TypeOfTestsTableAdapter();
            //TypeOfTestsTableAdapterMain.ClearBeforeFill = true;


            // TODO: This line of code loads data into the 'dbDataSet.TypeOfTests' table. You can move, or remove it, as needed.
            //TypeOfTestsTableAdapterMain.Fill(TypeOfTestsDt);
            foreach (var item in new myEnum().sectionTypesArray) {
                cmbxTypeOfTest.Items.Add(item);
            }
        }
    }
}
