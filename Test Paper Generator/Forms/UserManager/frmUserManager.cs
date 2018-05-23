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
    public partial class frmUserManager : Form {
        private dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapterMain;
        string lastSearchBGW;

        public frmUserManager() {
            InitializeComponent();
        }

        private void frmUserManager_Load(object sender, EventArgs e) {
            employeesTableAdapterMain = new dbDataSetTableAdapters.EmployeesTableAdapter();
        }

        private void cntxMain_Opening(object sender, CancelEventArgs e) {
            if (lstvUsers.SelectedItems.Count == 0) {
                editSelectedToolStripMenuItem.Visible = false;
                deleteSelectedToolStripMenuItem.Visible = false;
            }
            else {
                editSelectedToolStripMenuItem.Visible = true;
                deleteSelectedToolStripMenuItem.Visible = true;
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e) {
            if (!SearchWorker.IsBusy && txbSearch.Text.Length >= 3) {
                SearchWorker.RunWorkerAsync(txbSearch.Text);
                lastSearchBGW = txbSearch.Text;
            }
            else {
                lstvUsers.Items.Clear();
            }
        }

        private void SearchWorker_DoWork(object sender, DoWorkEventArgs e) {
            dbDataSet.EmployeesDataTable init = new dbDataSet.EmployeesDataTable();
            employeesTableAdapterMain.FillByUsers(init,e.Argument.ToString());
            e.Result = init; // stack overflow google XD
        }

        private void SearchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            lstvUsers.Items.Clear();
            // check if previews search matches
            if (lastSearchBGW != txbSearch.Text) {
                SearchWorker.RunWorkerAsync(txbSearch.Text);
                lastSearchBGW = txbSearch.Text;
                return;
            }
            

            dbDataSet.EmployeesDataTable eDt = (dbDataSet.EmployeesDataTable)e.Result;
            if (eDt.Count == 0) return;

            int i = 0;
            //this.Text = eDt[0].GivenName;
            do
            {
                ListViewItem lstv = new ListViewItem();
                lstv.Text = eDt[i].GivenName;
                lstv.SubItems.Add(eDt[i].MiddleName);
                lstv.SubItems.Add(eDt[i].FamilyName);
                lstv.SubItems.Add(eDt[i].LoginName);
                lstv.SubItems.Add(eDt[i].Acces_Name);
                lstv.SubItems.Add(eDt[i].Id + "");

                lstvUsers.Items.Add(lstv);
            } while (++i < eDt.Count);
        }

        private void AddUser_Click(object sender, EventArgs e) {
            Forms.UserManager.frmUserProperties tmp = new Forms.UserManager.frmUserProperties(false);
            tmp.ShowDialog();
        }

        private void deleteSelected_Click(object sender, EventArgs e) {
            //MessageBox.Show(lstvUsers.SelectedItems[0].SubItems[5].Text);
            dbDataSet.EmployeesDataTable init = new dbDataSet.EmployeesDataTable();
            employeesTableAdapterMain.DeleteQueryById(int.Parse( lstvUsers.SelectedItems[0].SubItems[5].Text));

            SearchWorker.RunWorkerAsync(txbSearch.Text);
            lastSearchBGW = txbSearch.Text;
        }

        private void EditSelected_Click(object sender, EventArgs e) {
            Forms.UserManager.frmUserProperties tmp = new Forms.UserManager.frmUserProperties(true, int.Parse(lstvUsers.SelectedItems[0].SubItems[5].Text));
            tmp.ShowDialog();
        }

        private void lstvUsers_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstvUsers.SelectedItems.Count > 0) {
                btnEditSelected.Enabled = true;
                btnDelete.Enabled = true;
            }
            else {
                btnEditSelected.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!SearchWorker.IsBusy && txbSearch.Text.Length >= 3) {
                SearchWorker.RunWorkerAsync(txbSearch.Text);
                lastSearchBGW = txbSearch.Text;
            }
            else {
                lstvUsers.Items.Clear();
            }
        }

        private void txbSearch_Click(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.ExitThread();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Restart();
        }
    }
}
