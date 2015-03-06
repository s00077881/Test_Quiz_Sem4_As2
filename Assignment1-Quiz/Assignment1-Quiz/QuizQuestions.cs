using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1_Quiz
{
    [Serializable]
    public class QuizQuestions
    {
        public string _id { get; set; }
        public string _question { get; set; }
        public string _option1 { get; set; }
        public string _option2 { get; set; }
        public string _option3 { get; set; }
        public string _option4 { get; set; }
        public string _answer { get; set; }

        public QuizQuestions(){}

        public QuizQuestions(string id,string question, string op1, string op2, string op3, string op4, string ans)
        {
            _id = id;
            _question = question;
            _option1 = op1;
            _option2 = op2;
            _option3 = op3;
            _option4 = op4;
            _answer = ans;
        }

        public QuizQuestions(string question,string op1,string op2,string op3,string op4,string ans)
        {
            _question = question;
            _option1 = op1;
            _option2 = op2;
            _option3 = op3;
            _option4 = op4;
            _answer = ans;
        }

        public string WriteQuestions()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", _id, _question, _option1, _option2, _option3, _option4, _answer);
        }
    }
}