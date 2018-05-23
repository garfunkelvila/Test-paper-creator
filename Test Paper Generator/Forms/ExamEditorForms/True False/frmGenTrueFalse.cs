using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paper_Creator.True_False {
    public partial class frmGenTrueFalse : Form {
        public frmGenTrueFalse() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            listViewMain.Items.Clear();

            int i = 0;
            do {
                listViewMain.Items.Add("Test ... Test...");
            } while (i++ <= numQuestions.Value);
        }

        private void frmGenTrueFalse_Load(object sender, EventArgs e) {

        }
    }
}
