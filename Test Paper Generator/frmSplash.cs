using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator {
    public partial class frmSplash : Form {
        private dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapterMain;
        private dbDataSet.EmployeesDataTable EmpDt = new dbDataSet.EmployeesDataTable();
        private dbDataSet.EmployeesDataTable EmpDt2 = new dbDataSet.EmployeesDataTable();
        private dbDataSet.EmployeesDataTable EmpDt3 = new dbDataSet.EmployeesDataTable();



        private OleDbDataAdapter lDA = new OleDbDataAdapter();

        //int prog = 0;
        int opac = 0;
        int attemp = 0;

        public frmSplash() {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e) {
            employeesTableAdapterMain = new Test_Paper_Creator.dbDataSetTableAdapters.EmployeesTableAdapter();
            employeesTableAdapterMain.ClearBeforeFill = true;
            //dataConnection.connect();

            


            //axShockwaveFlash1.Movie = Application.StartupPath + "/Resources/intro.swf";
            //axShockwaveFlash1.Loop = false;
            //axShockwaveFlash1.Play();
            this.Opacity = 0;
            tmrFadeIn.Start();

            /*axWindowsMediaPlayer1.URL = Application.StartupPath + "/Resources/SAD Intro.wmv";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.windowlessVideo = true;
            axWindowsMediaPlayer1.enableContextMenu = false;*/
            //tmrMain.Start();
        }

        

        private void tmrMain_Tick(object sender, EventArgs e) {
            //if (prgBarMain.Value == 100) {
            //    tmrMain.Stop();
            //    tmrMain.Enabled = false;
               
            //    pnlLogin.Visible = true;
            //    prgBarMain.Visible = false;
            //}
            //else {
            //    prgBarMain.Value = prog++;
            //}
        }

        private void button5_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            //Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            //TODO: same password dont show message, it is not handled
            employeesTableAdapterMain.FillByLogin(EmpDt, txbUserName.Text, txbPassword.Text);   // this sh*t uses select * from -_-
            employeesTableAdapterMain.FillByUserName(EmpDt2, txbUserName.Text);
            employeesTableAdapterMain.FillByPassword(EmpDt3, txbPassword.Text);

            if ((EmpDt2.Rows.Count >= 1) && (EmpDt3.Rows.Count >= 1)) {
                // booth password and user name exists
                
                // check if match
                if (EmpDt.Rows.Count == 1) {
                    string temp = EmpDt[0].Acces_Name + " ";

                    MessageBox.Show("Welcome " + temp +  EmpDt[0].GivenName);
                    lblName.Text = temp + EmpDt[0].GivenName;
                    pnlOpen.Visible = true;
                    pnlOpen.Parent = panel1;
                    if (EmpDt[0].Acces_Name == "Employee" ) btnAccounts.Visible = false;
                    pnlOpen.Location = pnlLogin.Location;
                    pnlLogin.Visible = false;

                    txbPassword.Clear();
                    txbUserName.Clear();
                    attemp = 0;
                }
                else {
                    if (attemp == 3) {
                        MessageBox.Show(this, "Max number of tries exeeded, application will exit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    MessageBox.Show(this, "User Name and Password not matched", "Attemp " + ++attemp);
                }

            }

            if ((EmpDt2.Rows.Count == 1) && (EmpDt3.Rows.Count == 0)) {
                if (attemp == 3) {
                    MessageBox.Show(this, "Max number of tries exeeded, application will exit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
                //Username exist but password don't
                //MessageBox.Show("Invalid Password");
                txbPassword.Focus();
                tltpLogin.ToolTipTitle = EmpDt2[0].GivenName + " : Attemp " + ++attemp;
                tltpLogin.Show("Your password missmatched", txbPassword,0);
                tltpLogin.Show("Your password missmatched", txbPassword);
            }
            if ((EmpDt2.Rows.Count == 0) && (EmpDt3.Rows.Count == 1)) {
                if (attemp == 3) {
                    MessageBox.Show(this, "Max number of tries exeeded, application will exit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
                //Username exist but password don't
                //MessageBox.Show("Invalid User Name");
                txbUserName.Focus();
                tltpLogin.ToolTipTitle = EmpDt3[0].GivenName + " : Attemp " + ++attemp;
                tltpLogin.Show("Your user name missmatched", txbUserName,0);
                tltpLogin.Show("Your user name missmatched", txbUserName);
            }
            if ((EmpDt2.Rows.Count == 0) && (EmpDt3.Rows.Count == 0)) {
                if (attemp == 3) {
                    MessageBox.Show(this, "Max number of tries exeeded, application will exit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
                txbUserName.Focus();
                tltpLogin.ToolTipTitle = "Attemp " + ++attemp;
                tltpLogin.Show("User name or password doesnt exist!", btnLogin,0);
                tltpLogin.Show("User name or password doesnt exist!", btnLogin);
            }
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            pnlOpen.Visible = false;
            pnlLogin.Visible = true;
        }

        private void btnNewExam_Click(object sender, EventArgs e) {
            Program.LoginMode = Program.LoginModes.NewExam;
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }
        private void btnAccounts_Click(object sender, EventArgs e) {
            Program.LoginMode = Program.LoginModes.ManageUsers;
            this.DialogResult = DialogResult.OK;
        }

        private void timerFadeIn_Tick(object sender, EventArgs e) {
            if (opac == 100) {
                tmrFadeIn.Stop();

                BackgroundWorker bgWorderTmp = new BackgroundWorker();
                lblLoading.Text = "Connecting to database...";
                bgWorderTmp.DoWork += BgWorderTmp_DoWork;
                bgWorderTmp.RunWorkerCompleted += BgWorderTmp_RunWorkerCompleted;
                bgWorderTmp.RunWorkerAsync();

                //tmrMain.Start();

                //lblLoading.Text = "Ready...";
                //prgBarMain.Value = 100;
                //pnlLogin.Visible = true;
            }
            else {
                this.Opacity = opac++ * 0.01;
            }
            
        }

        private void BgWorderTmp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if ((string) e.Result == "failed") {
                lblLoading.Text = "FAILED...";
            }
            else {
                lblLoading.Text = "Ready...";
                pnlLogin.Visible = true;
            }
            
            //throw new NotImplementedException();
        }

        private void BgWorderTmp_DoWork(object sender, DoWorkEventArgs e) {
            dbDataSet.EmployeesDataTable init = new dbDataSet.EmployeesDataTable();
            try {
                employeesTableAdapterMain.Fill(init);
            }
            catch (Exception) {
                e.Result = "failed";
            }
            
            //throw new NotImplementedException();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e) {

        }

        private void lblName_Click(object sender, EventArgs e) {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            if (e.newState == 1) {
                //MessageBox.Show("");
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration - 0.1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }

        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e) {
            //if (e.newPosition == 9) MessageBox.Show("");
            
        }

        private void timerMedia_Tick(object sender, EventArgs e) {
            if ((int) axWindowsMediaPlayer1.Ctlcontrols.currentPosition == 9) axWindowsMediaPlayer1.Ctlcontrols.pause();
            //label5.Text = "" + axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
        }

        private void pnlLogin_Paint (object sender, PaintEventArgs e) {

        }
    }
}

