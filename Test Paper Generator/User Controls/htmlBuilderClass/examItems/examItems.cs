using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper_Creator.User_Controls.htmlBuilderClass {
    /// <summary>
    /// This class returns and generates question part
    /// </summary>
    class examItems {
        public static string generated(sectionTypes type, List<examItem> sectionItems) {
            string temp = "";
            int i = 0;
            do {
                //Debug.Print("sender: " + sender.ToString());
                temp += sectionItems[i].generated; // adding of question
                //System.Diagnostics.Debug.Write("ExamItem.cs >" + sectionItems[i].Choices[0]);
            } while (++i < sectionItems.Count);
            return temp;
        }
        public static string ansGenerated(sectionTypes type, List<examItem> sectionItems) {
            string temp = "";
            int i = 0;
            do {
                //Debug.Print("sender: " + sender.ToString());
                temp += sectionItems[i].answersGenerated; // adding of question
            } while (++i < sectionItems.Count);
            return temp;
        }

    }
}
