using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class question1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<QuizQuestions> questions = (List<QuizQuestions>)Session["questions"];
                List<int> quesAnswered = (List<int>)Session["quesAnswered"];
                List<string> answers = (List<string>)Session["answers"];                

                if (questions != null && quesAnswered != null)
                {
                    lblQuestion.Text = questions.ElementAt(quesAnswered.ElementAt(0))._question;

                    lstAnswers.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option1, questions.ElementAt(quesAnswered.ElementAt(0))._option1));
                    lstAnswers.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option2, questions.ElementAt(quesAnswered.ElementAt(0))._option2));
                    lstAnswers.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option3, questions.ElementAt(quesAnswered.ElementAt(0))._option3));
                    lstAnswers.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option4, questions.ElementAt(quesAnswered.ElementAt(0))._option4));
                }
                else
                    Response.Redirect("quizSelection.aspx");

                if (answers != null)
                {
                    foreach (ListItem ans in lstAnswers.Items)
                    {
                        if (ans.Value == answers[0])
                            ans.Selected = true;
                    }
                }
            }
        }

        protected void AddAnswer()
        {
            List<string> answers = (List<string>)Session["answers"];

            if (answers == null)
            {
                answers = new List<string>();
                answers.Add(lstAnswers.SelectedValue);
            }
            else
                answers[0] = lstAnswers.SelectedValue;

            Session.Add("answers", answers);
        }

        protected void btnNextQuestion_Click(object sender, EventArgs e)
        {
            AddAnswer();  
            Response.Redirect("question2.aspx");
        }
    }
}