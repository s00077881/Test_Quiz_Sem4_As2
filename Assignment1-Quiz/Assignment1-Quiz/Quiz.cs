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

        //List holds quiz questions // stored as strings
        public List<string> _quizQuestions = new List<string>();

        public Quiz(string id, string name, string cat)
        {
            _quizID = id;
            _quizName = name;
            _quizCategory = cat;
            //_quizQuestions = GetQuizQuestions();
        }

        //public List<string> GetQuizQuestions()
        //{
        //    return "";
        //}
    }
}