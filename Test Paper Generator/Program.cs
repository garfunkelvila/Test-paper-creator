using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator {
    
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public enum LoginModes {
            NewExam,
            OpenLast,
            ManageUsers
        }

        

        public static LoginModes LoginMode;

        public static htmlBuilder myHtmlbuilder = new htmlBuilder();
        public static frmSplash splash;
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splash = new frmSplash();
            //Application.Run(new Forms.ExamEditorForms.frmExamNumbering());
            if (splash.ShowDialog() == DialogResult.Cancel) {
                Application.ExitThread();
            }
            
            else {
            //LoginMode = LoginModes.NewExam;
                switch (LoginMode) {
                    case LoginModes.NewExam:
                        Application.Run(new frmMain());
                        break;
                    case LoginModes.OpenLast:
                        Application.Run(new frmMain());
                        break;
                    case LoginModes.ManageUsers:
                        Application.Run(new frmUserManager());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
