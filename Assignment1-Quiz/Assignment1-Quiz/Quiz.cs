using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Assignment1_Quiz
{
    public class Quiz
    {
        public string _quizID { get; set; }
        public string _quizName { get; set; }
        public string _quizCategory { get; set; }

        public Quiz(string id, string name, string cat)
        {
            _quizID = id;
            _quizName = name;
            _quizCategory = cat;
        }

        public string WriteFormat()
        {
            return string.Format("{0},{1},{2}",_quizID,_quizName,_quizCategory);
        }
    }
}