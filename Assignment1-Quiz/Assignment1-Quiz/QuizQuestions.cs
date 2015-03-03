using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1_Quiz
{
    public class QuizQuestions
    {
        public string _question { get; set; }
        public string _option1 { get; set; }
        public string _option2 { get; set; }
        public string _option3 { get; set; }
        public string _option4 { get; set; }
        public string _answer { get; set; }

        public QuizQuestions(string question,string op1,string op2,string op3,string op4,string ans)
        {
            _question = question;
            _option1 = op1;
            _option2 = op2;
            _option3 = op3;
            _option4 = op4;
            _answer = ans;
        }
    }
}