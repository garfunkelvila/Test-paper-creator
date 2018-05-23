using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper_Creator.User_Controls.htmlBuilderClass {

    /// <summary>
    /// this class is the item content of exam items;
    /// </summary>
    class examItem {
        private sectionTypes _type;
        private string _question;
        private string _answer;
        private string[] _choices;
        public int itemNumber;

        public string question {
            set {
                _question = value;
            }
        }

        public string[] Choices {
            set {
                switch (_type) {
                    case sectionTypes.none:
                        break;
                    case sectionTypes.MultipleChoice:
                        break;
                    case sectionTypes.MatchingType:
                        break;
                    case sectionTypes.TrueFalse:
                        break;
                    case sectionTypes.Identification:
                        break;
                    default:
                        break;
                }
                _choices = value;
                //System.Diagnostics.Debug.Write("ExamItem.cs >" + _choices[0]);
            }
            get {
                return _choices;
            }
        }

        public string generated {
            get {
                switch (_type) {
                    case sectionTypes.none:
                        throw new Exception("INVALID VALUE");
                    case sectionTypes.TrueFalse:
                        return TrueFalse();
                    case sectionTypes.Identification:
                        return Identification();
                    case sectionTypes.MultipleChoice:
                        return MultipleChoice();
                    case sectionTypes.MatchingType:
                        return MatchingType();
                    case sectionTypes.Enumeration:
                        return Enumeration();
                    case sectionTypes.Essay:
                        return Essay();
                    default:
                        throw new Exception("ENEXPECTED ERROR");
                }
            }
        }
        public string answersGenerated {
            get {
                switch (_type) {
                    case sectionTypes.none:
                        throw new Exception("INVALID VALUE");
                    case sectionTypes.TrueFalse:
                        return AnsTrueFalse();
                    case sectionTypes.Identification:
                        return AnsIdentification();
                    case sectionTypes.MultipleChoice:
                        return AnsMultipleChoice();
                    case sectionTypes.MatchingType:
                        return AnsMatchingType();
                    case sectionTypes.Enumeration:
                        return "";
                    case sectionTypes.Essay:
                        return "";
                    default:
                        throw new Exception("ENEXPECTED ERROR");
                }
            }
        }
        public string answer {
            get {
                return _answer;
            }
            set {
                _answer = value;
            }
        }

        public sectionTypes Type {
            set {
                _type = value;
            }
        }
        //-----------------------------------------------------------------------------
        #region generator
        private string TrueFalse() {
            return "__________ " + itemNumber + ". " + _question + "<br>";
        }
        private string Identification() {
            return "____________________ " + itemNumber + ". " + _question + "<br>";
        }
        private string MultipleChoice() {
            return itemNumber + ". " + _question + "<br>" + 
                "<table style=\"margin-left:0.5in\"><tr>" + 
                "<td width=\"25%\"> a. " + _choices[0] + "</td>" +
                "<td width=\"25%\"> b. " + _choices[1] + "</td>" +
                "<td width=\"25%\"> c. " + _choices[2] + "</td>" +
                "<td width=\"25%\"> d. " + _choices[3] + "</td>" +
                "</tr></table>";
        }
        private string MatchingType() {
            //Debug.Print("examitem.cs" + _choices[0]);
            return "<table style=\"margin-left:0.5in\"><tr>" +
                "<td width=\"75%\">" + itemNumber + ". " + _question + "</td>" +
                "<td width=\"25%\">" + _choices[0] + "</td>" +
                "</tr></table><br>";
        }
        private string Enumeration() {
            return itemNumber + ". " + _question + "<br>";
        }
        private string Essay() {
            return itemNumber + ". " + _question + "<br>";
        }
        #endregion

        #region answers
        private string AnsTrueFalse() {
            return itemNumber + ". " + _answer + "<br>";
        }
        private string AnsIdentification() {
            return itemNumber + ". " + _answer + "<br>";
        }
        private string AnsMultipleChoice() {
            return itemNumber + ". " + _answer + "<br>";
        }
        private string AnsMatchingType() {
            return itemNumber + ". " + _answer + "<br>";
        }
        #endregion
    }
}
