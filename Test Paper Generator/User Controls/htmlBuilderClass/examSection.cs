using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Test_Paper_Creator.User_Controls.htmlBuilderClass {


    /// <summary>
    /// This class will be used on test groups and contains instruction
    /// </summary>
    public class examSection {
        string _instruction;
        int _testNumber;
        //public enum sectionType {
        //    none, //escape because this is the default and should be changed
        //    MultipleChoice,
        //    TrueFalse,
        //    Identification
        //}

        sectionTypes _Type;
        List<examItem> sectionItems = new List<examItem>(); // TODO: !!!!!!!!!!! remove this and put the adding of questions in exam item then rename that to exam items
        //examItems myExamItems;

        /// <summary>
        /// this should generate section/test
        /// </summary>
        public string generated(object sender) {
            string temp = new htmlInsertorMethods().p("<b> Test " + FormatRoman(_testNumber)+ "</b> " + _instruction);
            //string temp = new htmlInsertorMethods().p(_testNumber + _instruction);

            //int i;
            //if (sectionItems.Count > 0) {
            //    i = 0;
            //    do {
            //    //Debug.Print("sender: " + sender.ToString());
            //        temp += sectionItems[i].generated; // adding of question
            //    } while (++i < sectionItems.Count);
            //}

            temp += examItems.generated(_Type, sectionItems);
                return temp;
        }
        public string ansGenerated() {
            string temp = new htmlInsertorMethods().p("<b> Test " + FormatRoman(_testNumber) + "</b> " + _instruction);
            temp += examItems.ansGenerated(_Type, sectionItems);
            return temp;
        }
        public string instruction {
            set {
                _instruction = value;
            }
        }
        public int testNumber {
            set {
                _testNumber = value;
            }
            get {
                return _testNumber;
            }
        }
        /// <summary>
        /// Counts the total number of items
        /// </summary>
        public int Total {
            get {
                return sectionItems.Count;// Temporary, but i know ill need propety like this
            }
        }

        public sectionTypes Type {
            set {
                _Type = value;
            }
        }
        //-----------------------------------------------------------------------------
        public void AddQuestion(string question, int itemNumber,string answer = null, string[] choices = null) {
            if(_Type == sectionTypes.MultipleChoice && choices == null) {
                throw new Exception("Choices cant be null when in multiple choice");
            }

            examItem tmpItem = new examItem();

            tmpItem.question = question;
            tmpItem.Type = _Type;
            tmpItem.Choices = choices;
            //Debug.Print("examsection.cs" + choices[0]);
            tmpItem.answer = answer;
            tmpItem.itemNumber = itemNumber;
            sectionItems.Add(tmpItem);
            //Debug.Print("Sucesfully added: " + question + " > Choice:" + choices[0] + ":" + choices.Length);
        }

        public void ClearQuestions() {
            sectionItems.Clear();
        }

        /// <summary>
        /// http://www.source-code.biz/snippets/vbasic/7.htm
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private String FormatRoman(int n) {
            if (n == 0) return "0";
            // There is no roman symbol for 0, but we don't want to return an empty string.
            const string r = "IVXLCDM"; // roman symbols
            int i = Math.Abs(n);
            string s = "";
            int p =0;

            do {
                int d = i % 10;
                i = i/10;

                switch (d) {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        s = s.PadLeft(d + s.Length, Convert.ToChar(r.Substring(p,1)));
                        break;
                    case 4:
                        s = r.Substring(p, 2) + s;
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        s = r.Substring(p + 1, 1) + s.PadLeft(d-5+s.Length, Convert.ToChar(r.Substring(p, 1)));
                        break;
                    case 9:
                        s = r.Substring(p, 1) + r.Substring(p+2,1) + s;
                        break;
                }
                p += 2;
            } while (p < 5);

            s = s.PadLeft(i + s.Length, 'M');
            if (n < 0) {
                s = "-" + s;
            }
            return s;
        }
    }
}
