using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class quizFinish : System.Web.UI.Page
    {
        List<QuizQuestions> questions;
        List<int> quesAnswered;
        List<string> answers;
        int score = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                questions = (List<QuizQuestions>)Session["questions"];
                quesAnswered = (List<int>)Session["quesAnswered"];
                answers = (List<string>)Session["answers"];

                if (questions != null && quesAnswered != null)
                {
                    DisplayAnswers(0, lblQuestion1, lstAnswers1);
                    DisplayAnswers(1, lblQuestion2, lstAnswers2);
                    DisplayAnswers(2, lblQuestion3, lstAnswers3);
                    DisplayAnswers(3, lblQuestion4, lstAnswers4);
                    DisplayAnswers(4, lblQuestion5, lstAnswers5);
                    DisplayAnswers(5, lblQuestion6, lstAnswers6);

                    lblScore.Text = string.Format("Your score: {0}/6", score);

                    DateTime timeStart = (DateTime)Session["timeStart"];
                    TimeSpan timeTaken = DateTime.Now.Subtract(timeStart);
                    lblTimeTaken.Text = string.Format("Time taken: {0:hh\\:mm\\:ss}", timeTaken);
                }
                else
                    Response.Redirect("quizSelection.aspx");
            }
        }

        protected void DisplayAnswers(int index, Label lblID, RadioButtonList lstID)
        {
            lblID.Text = questions.ElementAt(quesAnswered.ElementAt(index))._question.ToString();

            lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(index))._option1.ToString()));
            lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(index))._option2.ToString()));
            lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(index))._option3.ToString()));
            lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(index))._option4.ToString()));

            foreach (ListItem ans in lstID.Items)
            {
                if (ans.Value == answers[index])
                    ans.Selected = true;

                if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(index))._answer.ToString())
                {
                    ans.Attributes["style"] = "color:green";
                    score += 1;
                }
                else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(index))._answer.ToString())
                    ans.Attributes["style"] = "color:red";
                else
                    ans.Attributes["style"] = "color:black";
            }
        }
    }
}