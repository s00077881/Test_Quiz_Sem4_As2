using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1_Quiz
{
    public class QuizAnswers
    {
        public int _questionId { get; set; }
        public string _answer { get; set; }
        public bool _value { get; set; }

        public QuizAnswers(int questionId, string answer, bool value)
        {
            _questionId = questionId;
            _answer = answer;
            _value = value;
        }
    }
}