using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Paper_Creator {
    public static class dataConnection {
        public static OleDbConnection sConn;
        static DataSet lDS = new DataSet();
        //static OleDbDataReader LDReader;
        //static OleDbDataAdapter lDA;
        //static DataRow lDR;
        public static void connect() {
            try {
                sConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"" + Application.StartupPath + "\\dbMain.accdb\";Persist Security Info=True");
                sConn.Open();
                sConn.StateChange += SConn_StateChange;
            }
            catch (Exception) {
                throw;
            }
        }

        private static void SConn_StateChange(object sender, StateChangeEventArgs e) {

            throw new NotImplementedException();
        }
    }
}
