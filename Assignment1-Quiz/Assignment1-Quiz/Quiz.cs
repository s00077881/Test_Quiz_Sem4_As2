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
        public int _timeTaken { get; set; }
        public int _totalScore { get; set; }

        public Quiz(string id, string name, string cat)
        {
            _quizID = id;
            _quizName = name;
            _quizCategory = cat;
        }

        public Quiz(string id, string name, string cat, int time, int total)
        {
            _quizID = id;
            _quizName = name;
            _quizCategory = cat;
            _timeTaken = time;
            _totalScore = total;
        }

        public string WriteFormat()
        {
            return string.Format("{0},{1},{2},0,0",_quizID,_quizName,_quizCategory);
        }

        public string WriteScoreTotal()
        {
            return string.Format("{0},{1},{2},{3},{4}", _quizID, _quizName, _quizCategory, _timeTaken, _totalScore);
        }
    }
}