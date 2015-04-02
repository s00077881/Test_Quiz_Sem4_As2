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
        //Variable to control the currently displayed question
        public int curIndex;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["QuestionCurIndex"] != null)
                curIndex = (int)Session["QuestionCurIndex"];
            else
                Response.Redirect("quizSelection.aspx");

            if (!IsPostBack)
            {
                //List containg all questions and answers for selected quiz
                List<QuizQuestions> qq = (List<QuizQuestions>)Session["questions"];
                List<int> quesAnswered = (List<int>)Session["quesAnswered"];

                List<SelectedAnswer> answers = (List<SelectedAnswer>)Session["answers"]; 

                if (qq != null && quesAnswered != null)
                {
                    //Pull relivent question & answers from qq object list
                    var quesAns = from item in qq
                                  where item._questionId == quesAnswered[curIndex]
                                  select new
                                  {
                                      _question = item._question,
                                      _answer = item._answers._answer,
                                      _value = item._answers._value.ToString()
                                  };


                    //Variable to prevent question being written to screen 4 times
                    bool stop = false;

                    foreach (var item in quesAns)
                    {
                        //Assign Text and value to list box items // Value of 1 == Correct answer
                        lstAnswers.Items.Add(new ListItem(item._answer, item._answer));

                        if (stop == false)
                        {
                            lblQuestion.Text = item._question;
                            stop = true;
                        }
                    }

                    //Set correct buttons on page // if not on the first page previous button appears etc.
                    if (curIndex > 0)
                        btnPrevQuestion.Visible = true;
                    else
                        btnPrevQuestion.Visible = false;

                    if (curIndex == quesAnswered.Count-1)
                    {
                        btnNextQuestion.Visible = false;
                        btnFinishQuiz.Visible = true;
                    }
                    else
                    {
                        btnNextQuestion.Visible = true;
                        btnFinishQuiz.Visible = false;
                    }
                }
                else
                    Response.Redirect("quizSelection.aspx");

                //Populate the selected value on that question
                if (answers != null && answers.Count > curIndex)
                {
                    foreach (ListItem ans in lstAnswers.Items)
                    {
                        if (ans.Value == answers[curIndex]._answer)
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
            List<QuizQuestions> qq = (List<QuizQuestions>)Session["questions"];
            List<int> quesAnswered = (List<int>)Session["quesAnswered"];

            List<SelectedAnswer> answers = (List<SelectedAnswer>)Session["answers"];
            SelectedAnswer answer = new SelectedAnswer();

            var quesAns = from item in qq
                          where item._questionId == quesAnswered[curIndex]
                          select new
                          {
                              _question = item._question,
                              _answer = item._answers._answer,
                              _value = item._answers._value.ToString()
                          };

            foreach (var item in quesAns)
            {
                if (item._answer == lstAnswers.SelectedValue)
                    answer = new SelectedAnswer(lstAnswers.SelectedValue, Convert.ToInt32(item._value));
            }
            
            if (answers == null)
            {
                answers = new List<SelectedAnswer>();
                answers.Add(answer);
            }
            else if (answers.Count == curIndex)
                answers.Add(answer);
            else if (answers.Count > curIndex)
                answers[curIndex] = answer;

            Session.Add("answers", answers);
        }

        protected void btnNextQuestion_Click(object sender, EventArgs e)
        {
            AddAnswer();

            curIndex++;
            Session.Add("QuestionCurIndex", curIndex);

            Response.Redirect("questions.aspx");
        }

        protected void btnPrevQuestion_Click(object sender, EventArgs e)
        {
            AddAnswer();

            curIndex--;
            Session.Add("QuestionCurIndex", curIndex);

            Response.Redirect("questions.aspx");
        }

        protected void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            AddAnswer();
            Response.Redirect("quizFinish.aspx");
        }     
    }
}