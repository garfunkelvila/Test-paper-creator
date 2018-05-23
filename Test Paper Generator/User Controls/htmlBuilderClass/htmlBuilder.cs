using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Paper_Creator.User_Controls.htmlBuilderClass;
using System.Diagnostics;

namespace Test_Paper_Creator {
    public delegate void EventHandler();

    class htmlBuilder {
        public event EventHandler SectionAdded;
        public event EventHandler SectionEdited;
        string styles = "<style>" + Properties.Resources.htmlStyle + "</style>";
        string head = "<title>aaa</title>";

        List<examSection> examSections = new List<examSection>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">This is used for image location</param>
        /// <returns></returns>
        public string generated(string s) {
            int i;
            string examSectionExtracted = "";
            //string examHeaderExtracted = "";

            if (examSections.Count > 0) {
                i = 0;
                do {
                    examSectionExtracted += examSections[i].generated(this);
                } while (++i < examSections.Count);
            }

            i = 0;
            /*do {
                examHeaderExtracted += examSections[i].generated;
            } while (i++ <= examSections.Count);*/

            return 
                "<html>" + 
                "<head>" + 
                head + styles +
                "</head>" + 
                "<body>" +
                "<div id=\"logo-header\"><img src=\"" + s + "Brookes Logo.jpg\" style=\"width: 64px; float:left; overflow: visible\"></div>" + 
                    "<div style = \"font-family:'Old English Text MT'; font-size:28pt; color:green; text-align:center;\" > School Name</div>" + 
                    "<p style = \"font-family:'Calibri';font-size:12pt;text-align:center; margin-top:0px;margin-bottom:0.1in;\" > Mabuhay Homes 2000 Paliparan II Dasmariñas City, Cavite</ p >" + 
                    "<hr/>" +
                    "<table>"+
                    "<tr><td>Name: _______________________________<td><td>Score: _______<td></tr>" +
                    "<tr><td>Teacher Name: _______________________<td><td>Date: ________<td></tr><table/>" +
                examSectionExtracted +
                "</body>" + 
                "</html>";
        }
        public string ansGenerated(string s) {
            int i;
            string examSectionExtracted = "";
            //string examHeaderExtracted = "";

            if (examSections.Count > 0) {
                i = 0;
                do {
                    examSectionExtracted += examSections[i].ansGenerated();
                } while (++i < examSections.Count);
            }

            return
                "<html>" +
                "<head>" +
                head + styles +
                "</head>" +
                "<body>" +
                "<div id=\"logo-header\"><img src=\"" + s + "Brookes Logo.jpg\" style=\"width: 64px; float:left; overflow: visible\"></div>" +
                    "<div style = \"font-family:'Old English Text MT'; font-size:28pt; color:green; text-align:center;\" > Brooke's Point Academy</div>" +
                    "<p style = \"font-family:'Calibri';font-size:12pt;text-align:center; margin-top:0px;margin-bottom:0.1in;\" > Mabuhay Homes 2000 Paliparan II Dasmariñas City, Cavite</ p >" +
                    "<hr/>" +
                examSectionExtracted +
                "</body>" +
                "</html>";
        }
        public string GeneratedAnswerkeys() {
            return "Answer key not ready yet";
        }

        public void editHeader() {

        }

        public void addSection(examSection section) {
            examSections.Add(section);
            Debug.Print("Sucesfully added a section");
            SectionAdded.Invoke();
        }
        public void editSection(int sectionNumber, examSection section) {
            Debug.Print("Section Number Received: " + sectionNumber) ;
            examSections[sectionNumber - 1] = section;// replace ?
            SectionEdited.Invoke();
        }
        public void clearSections() {
            examSections.Clear();
        }
        public List<examSection> items {
            get {
                return examSections;
            }
        }
    }
}
