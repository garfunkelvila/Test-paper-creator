using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper_Creator.User_Controls.htmlBuilderClass {
    class htmlInsertorMethods {
        public string table(string content, string className = "", string style = "") {
            if (!content.ToUpper().Contains("TD")) throw new Exception("Table content dont have a TD in it");

            return "<table class=\"" + className + "\" style=\""+ style +"\">" + content + "</table>";
        }

        public string tr(string content, string className = "", string style = "") {


            return "<tr class=\"" + className + "\" style=\"" + style + "\">" + content + "</tr>";
        }
        public string td(string content, string className = "", string style = "") {

            return "<td class=\"" + className + "\" style=\"" + style + "\">" + content + "</td>";
        }

        public string p(string content, string className = "", string style = "") {
            return "<p class=\"" + className + "\" style=\"" + style + "\">" + content + "</p>";
        }
    }
}