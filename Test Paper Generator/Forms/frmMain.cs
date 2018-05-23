using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator {
    public partial class frmMain : Form {
        public bool isStartingPoint = true;
        public int testNumber = 1;
        private List<SectionPrecedence> Sections = new List<SectionPrecedence>();

        private List<User_Controls.Test_Button_Control> TestButtons = new List<User_Controls.Test_Button_Control>();

        Forms.ExamEditorForms.frmExamNumbering formPrecedence;
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            #region initialization
            switch (isStartingPoint) {
                case false:
                    //closeToolStripMenuItem.Visible = true;
                    exitToolStripMenuItem.Visible = false;
                    break;
                default:
                    //closeToolStripMenuItem.Visible = false;
                    exitToolStripMenuItem.Visible = true;
                    break;
            }
            /*MessageBox.Show("" + TestButtons.Count());
            User_Controls.Test_Button_Control temp = new User_Controls.Test_Button_Control();
            TestButtons.Add(temp);
            temp.Parent = flowLayoutPanel1;
            foreach (var item in TestButtons) {
                item.Dispose();
            }
            MessageBox.Show("" + TestButtons.Count());*/
            #endregion
            webBrowser1.Navigate(Application.StartupPath + "/Resources/Start.html");

            Program.myHtmlbuilder.SectionAdded += MyHtmlbuilder_SectionUpdated;
            Program.myHtmlbuilder.SectionEdited += MyHtmlbuilder_SectionUpdated;


            //newExam();
            //tltpMain.Show("To add a new exam, click here", btnNewExam, 1000);
            //tltpMain.Show("To add a new exam, click here", btnNewExam, 1000);
            //webBrowser1.DocumentText = Program.myHtmlbuilder.generated();
            //webBrowser1.DocumentText = Properties.Resources.Start;
        }

        private void formPrecedence_ready() {
            Sections.Clear();
            Sections.AddRange(formPrecedence.Sections);
            bool doCancel = false;
            foreach (SectionPrecedence item in formPrecedence.Sections) {
                
                //switching done on this controll, and it should be an object instead of controll
                User_Controls.Test_Button_Control testBtn = new User_Controls.Test_Button_Control(testNumber);
                testBtn.InitializeRoutine(ref testNumber, flowLayoutPanel1, item,0);
                if (testBtn.canceled == true) doCancel = true;
                if (doCancel == true) {
                    //Sections.Clear();
                    break;
                }
            }
            formPrecedence.Close();
        }

        private void MyHtmlbuilder_SectionEdited() {
            webBrowser1.DocumentText = Program.myHtmlbuilder.generated(Application.StartupPath + "/Resources/");
            webBrowser2.DocumentText = Program.myHtmlbuilder.ansGenerated(Application.StartupPath + "/Resources/");
            //throw new NotImplementedException();
        }

        private void MyHtmlbuilder_SectionAdded() {
            //generated parameter is to get image
            webBrowser1.DocumentText = Program.myHtmlbuilder.generated(Application.StartupPath + "/Resources/");
            webBrowser2.DocumentText = Program.myHtmlbuilder.ansGenerated(Application.StartupPath + "/Resources/");
        }

        private void MyHtmlbuilder_SectionUpdated() {
            webBrowser1.DocumentText = Program.myHtmlbuilder.generated(Application.StartupPath + "/Resources/");
            webBrowser2.DocumentText = Program.myHtmlbuilder.ansGenerated(Application.StartupPath + "/Resources/");
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            if (Sections.Count > 0) {
                webBrowser1.ShowPrintPreviewDialog();
            }
            else {
                MessageBox.Show("Please create a new exam first");
            }
                
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e) {
            if (Sections.Count > 0) {
                webBrowser2.ShowPrintPreviewDialog();
            }
            else {
                MessageBox.Show("Please create a new exam first");
            }
        }

        private void btnNewTestSection_Click(object sender, EventArgs e) {
            
        }

        private void editDatabaseToolStripMenuItem_Click(object sender, EventArgs e) {
            frmEditDatabase DatabaseForm = new frmEditDatabase();
            DatabaseForm.isStartingPoint = false;
            DatabaseForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        private void btnNewExam_Click(object sender, EventArgs e) {
            newExam();
        }

        private void newExam() {
            Program.myHtmlbuilder.clearSections();
            testNumber = 1;
            formPrecedence = new Forms.ExamEditorForms.frmExamNumbering();
            Sections.Clear();
            formPrecedence.ready += formPrecedence_ready;
            formPrecedence.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.ExitThread();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e) {
            frmUserManager formUserManager = new frmUserManager();
            formUserManager.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Created by: Garfunkel Vila");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
    }


    public class SectionPrecedence {
        private int _count;
        private sectionTypes _type;

        public sectionTypes SectionType {
            set {
                _type = value;
            }
            get {
                return _type;
            }
        }

        public int SectionCount {
            set {
                _count =value;
            }
            get {
                return _count;
            }
        }
    }
}
