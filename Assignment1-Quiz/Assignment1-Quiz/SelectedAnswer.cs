using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1_Quiz
{
    public class SelectedAnswer
    {
        public string _answer { get; set; }
        public int _value { get; set; }

        public SelectedAnswer()
        {
        }

        public SelectedAnswer(string answer, int value)
        {
            _answer = answer;
            _value = value;
        }
    }
}