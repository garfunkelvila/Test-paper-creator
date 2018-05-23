using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper_Creator {
    public enum sectionTypes {
        none,
        TrueFalse,
        Identification,
        MultipleChoice,
        MatchingType,
        Enumeration,
        Essay
    }

    

    class myEnum {
        public string[] sectionTypesArray = new string[6] {"True or False","Identification","Multiple Choice","Matching Type", "Enumeraion", "Essay" };

    }
}
