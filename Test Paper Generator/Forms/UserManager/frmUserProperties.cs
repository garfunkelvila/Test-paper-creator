using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator.Forms.UserManager{
    public partial class frmUserProperties : Form{
        public bool _isEdit;
        private dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapterMain;
        public int _id;
        public frmUserProperties(bool isEdit, int id = -1){
            InitializeComponent();
            _isEdit = isEdit;
            _id = id;
        }

        private void frmUserProperties_Load(object sender, EventArgs e) {
            employeesTableAdapterMain = new dbDataSetTableAdapters.EmployeesTableAdapter();

            switch (_isEdit) {
                case true:
                    dbDataSet.EmployeesDataTable init = new dbDataSet.EmployeesDataTable();
                    employeesTableAdapterMain.FillByEmployeeId(init, _id);
                    txbPrefx.Text = init[0].NamePrefix;
                    txbFirstName.Text = init[0].GivenName;
                    txbMiddleName.Text = init[0].MiddleName;
                    txbFamilyName.Text = init[0].FamilyName;
                    txbSuffix.Text = init[0].NameSuffix;
                    txbUserName.Text = init[0].LoginName;
                    txbPassword.Text = init[0].Password;
                    txbPassword2.Text = init[0].Password;
                    if (init[0].AccesID == 1) {
                        cmbAccess.SelectedIndex = 1;
                    }
                    else {
                        cmbAccess.SelectedIndex = 0;
                    }
                    break;
                case false:
                    cmbAccess.SelectedIndex = 0;
                    break;
                default:
                    throw new Exception("aaaaaaaaaaaaaa");
                    //break;
            }
        }

        private void txbSuffix_Enter(object sender, EventArgs e){
            tltpMain.Show("Name Suffix",txbSuffix);
        }

        private void txbPassword2_TextChanged(object sender, EventArgs e) {
            if(txbPassword.Text != txbPassword2.Text) {
                lblCheck.Text = "Password not matched";
                btnOk.Enabled = false;
            }
            else {
                lblCheck.Text = "Password matched";
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            dbDataSet.EmployeesDataTable init = new dbDataSet.EmployeesDataTable();
            switch (_isEdit) {
                case true:
                    employeesTableAdapterMain.UpdateUserByIdQuery(txbPrefx.Text, txbFirstName.Text, txbMiddleName.Text, txbFamilyName.Text, txbSuffix.Text, txbUserName.Text, txbPassword.Text, cmbAccess.SelectedIndex == 0 ? 2 : 1, _id);
                    
                    this.DialogResult = DialogResult.OK;
                    break;
                case false:
                    employeesTableAdapterMain.InsertUserQuery(txbPrefx.Text, txbFirstName.Text, txbMiddleName.Text, txbFamilyName.Text, txbSuffix.Text, txbUserName.Text, txbPassword.Text, cmbAccess.SelectedIndex == 0?2:1);
                    if (MessageBox.Show(this, "User sucesfully added, do you want to add more?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        //employeesTableAdapterMain.FillByEmployeeId(init, _id);
                        txbPrefx.Clear();
                        txbFirstName.Clear();
                        txbMiddleName.Clear();
                        txbFamilyName.Clear();
                        txbSuffix.Clear();
                        txbPassword.Clear();
                        txbPassword2.Clear();
                        lblCheck.Text = "-";
                    }
                    else {
                        this.Close();
                    }
                    break;
                default:
                    throw new Exception("aaaaaaaaaaaaaa");
            }
        }


    }
}
