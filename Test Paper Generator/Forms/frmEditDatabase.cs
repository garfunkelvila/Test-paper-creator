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
    public partial class frmEditDatabase : Form {
        public bool isStartingPoint = true;

        //private dbDataSetTableAdapters.TypeOfTestsTableAdapter TypeOfTestsTableAdapterMain;
        //private dbDataSetTableAdapters.ChaptersTableAdapter ChaptersTableAdapterMain;
        //private dbDataSet.TypeOfTestsDataTable TypeOfTestsDt = new dbDataSet.TypeOfTestsDataTable();
        //private dbDataSet.ChaptersDataTable ChaptersDt = new dbDataSet.ChaptersDataTable();

        public frmEditDatabase() {
            InitializeComponent();
        }



        private void frmEditDatabase_Load(object sender, EventArgs e) {
            switch (isStartingPoint) {
                case false:
                    closeToolStripMenuItem.Visible = true;
                    exitToolStripMenuItem.Visible = false;
                    break;
                default:
                    closeToolStripMenuItem.Visible = false;
                    exitToolStripMenuItem.Visible = true;
                    break;
            }

            //TypeOfTestsTableAdapterMain = new dbDataSetTableAdapters.TypeOfTestsTableAdapter();
            //TypeOfTestsTableAdapterMain.ClearBeforeFill = true;

            //ChaptersTableAdapterMain = new dbDataSetTableAdapters.ChaptersTableAdapter();
            //ChaptersTableAdapterMain.ClearBeforeFill = true;


            //cmbxTypeOfTest.Items.Clear();
            //TypeOfTestsTableAdapterMain.Fill(TypeOfTestsDt);
            //foreach (var item in TypeOfTestsDt) {
            //    cmbxTypeOfTest.Items.Add(item.TypeName);
            //}

            //ChaptersTableAdapterMain.Fill(ChaptersDt);

            //ListViewItem li;

            //lstvChapters.Items.Clear();
            //li = lstvChapters.Items.Add("#");
            //li.SubItems.Add("All");
            //foreach (var item in ChaptersDt) {
            //    li = lstvChapters.Items.Add(item.ChapterNumber);
            //    li.SubItems.Add(item.ChapterTitle);
            //}

        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            EditDatabaseForms.frmAddQuestion aa = new EditDatabaseForms.frmAddQuestion();
            aa.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
    }
}
