using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1_Quiz
{
    [Serializable]
    public class QuizQuestions
    {
        public int _questionId { get; set; }
        public string _question { get; set; }
        public int _quizId { get; set; }
        public QuizAnswers _answers { get; set; }

        public QuizQuestions(){}

        public QuizQuestions(int questionId,string questions, int quizId, QuizAnswers answers)
        {
            _questionId = questionId;
            _question = questions;
            _quizId = quizId;
            _answers = answers;
        }

        public QuizQuestions(string question,string ans)
        {
            //_question = question;
        }
    }
}