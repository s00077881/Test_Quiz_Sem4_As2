﻿using System;
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
            curIndex = (int)Session["QuestionCurIndex"];

            if (!IsPostBack)
            {
                //List containg all questions and answers for selected quiz
                List<QuizQuestions> qq = (List<QuizQuestions>)Session["questions"];
                List<int> quesAnswered = (List<int>)Session["quesAnswered"];

                List<string> answers = (List<string>)Session["answers"]; 

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
                        if (ans.Value == answers[curIndex])
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
            else if (answers.Count == curIndex)
                answers.Add(lstAnswers.SelectedValue);
            else if (answers.Count > curIndex)
                answers[curIndex] = lstAnswers.SelectedValue;

            Session.Add("answers", answers);
        }

        protected void btnNextQuestion_Click(object sender, EventArgs e)
        {
            AddAnswer();

            curIndex++;
            Session.Add("QuestionCurIndex", curIndex);

            Response.Redirect("question1.aspx");
        }

        protected void btnPrevQuestion_Click(object sender, EventArgs e)
        {
            AddAnswer();

            curIndex--;
            Session.Add("QuestionCurIndex", curIndex);

            Response.Redirect("question1.aspx");
        }

        protected void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            AddAnswer();
            Response.Redirect("quizFinish.aspx");
        }     
    }
}