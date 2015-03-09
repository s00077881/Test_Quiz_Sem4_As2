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
            /************************************************************
            * If questions or questions answered exists in the session
            * Pull the question for this page and place in the label
            * Then pull the answers and populate the radio button list
            *
            * If answers is not null then run through the radio button
            * list and select the appropriate button if that answer is in
            * the array in the correct position
            * 
            * This is the same code used on the remaining question pages
            * with the exception of the ElemantAt() being the correct
            * value for the specific page
            ************************************************************/
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

        /************************************************************
        * AddAnswer method is used to populate the answers list with
        * selected answer and store in the session
        * 
        * Again this code is the same on every question page, with the
        * exception of checking if the count is greater than the specific
        * page
        ************************************************************/

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