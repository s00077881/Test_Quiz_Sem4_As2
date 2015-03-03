using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Assignment1_Quiz.Properties
{
    public class Quiz
    {
        public string _quizName { get; set; }
        public string _quizCategory { get; set; }

        //List holds quiz questions // stored as strings
        public List<string> _quizQuestions = new List<string>();

        public Quiz(string name, string cat, List<string> questions)
        {
            _quizName = name;
            _quizCategory = cat;
            _quizQuestions = questions;
        }
    }
}