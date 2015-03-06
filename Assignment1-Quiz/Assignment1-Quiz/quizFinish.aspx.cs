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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<QuizQuestions> questions = (List<QuizQuestions>)Session["questions"];
                List<int> quesAnswered = (List<int>)Session["quesAnswered"];
                List<string> answers = (List<string>)Session["answers"];

                if (questions != null && quesAnswered != null)
                {
                    lblQuestion1.Text = questions.ElementAt(quesAnswered.ElementAt(0))._question.ToString();

                    lstAnswers1.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(0))._option1.ToString()));
                    lstAnswers1.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(0))._option2.ToString()));
                    lstAnswers1.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(0))._option3.ToString()));
                    lstAnswers1.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(0))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(0))._option4.ToString()));

                    foreach (ListItem ans in lstAnswers1.Items)
                    {
                        if (ans.Value == answers[0])
                            ans.Selected = true;

                        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(0))._answer.ToString())
                            ans.Attributes["style"] = "color:green";
                        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(0))._answer.ToString())
                            ans.Attributes["style"] = "color:red";
                        else
                            ans.Attributes["style"] = "color:black";
                    }

                    lblQuestion2.Text = questions.ElementAt(quesAnswered.ElementAt(1))._question.ToString();

                    lstAnswers2.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(1))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(1))._option1.ToString()));
                    lstAnswers2.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(1))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(1))._option2.ToString()));
                    lstAnswers2.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(1))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(1))._option3.ToString()));
                    lstAnswers2.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(1))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(1))._option4.ToString()));

                    foreach (ListItem ans in lstAnswers2.Items)
                    {
                        if (ans.Value == answers[1])
                            ans.Selected = true;

                        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(1))._answer.ToString())
                            ans.Attributes["style"] = "color:green";
                        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(1))._answer.ToString())
                            ans.Attributes["style"] = "color:red";
                        else
                            ans.Attributes["style"] = "color:black";
                    }

                    lblQuestion3.Text = questions.ElementAt(quesAnswered.ElementAt(2))._question.ToString();

                    lstAnswers3.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(2))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(2))._option1.ToString()));
                    lstAnswers3.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(2))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(2))._option2.ToString()));
                    lstAnswers3.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(2))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(2))._option3.ToString()));
                    lstAnswers3.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(2))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(2))._option4.ToString()));

                    foreach (ListItem ans in lstAnswers3.Items)
                    {
                        if (ans.Value == answers[2])
                            ans.Selected = true;

                        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(2))._answer.ToString())
                            ans.Attributes["style"] = "color:green";
                        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(2))._answer.ToString())
                            ans.Attributes["style"] = "color:red";
                        else
                            ans.Attributes["style"] = "color:black";
                    }

                    lblQuestion4.Text = questions.ElementAt(quesAnswered.ElementAt(3))._question.ToString();

                    lstAnswers4.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(3))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(3))._option1.ToString()));
                    lstAnswers4.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(3))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(3))._option2.ToString()));
                    lstAnswers4.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(3))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(3))._option3.ToString()));
                    lstAnswers4.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(3))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(3))._option4.ToString()));

                    foreach (ListItem ans in lstAnswers4.Items)
                    {
                        if (ans.Value == answers[3])
                            ans.Selected = true;

                        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(3))._answer.ToString())
                            ans.Attributes["style"] = "color:green";
                        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(3))._answer.ToString())
                            ans.Attributes["style"] = "color:red";
                        else
                            ans.Attributes["style"] = "color:black";
                    }

                    lblQuestion5.Text = questions.ElementAt(quesAnswered.ElementAt(4))._question.ToString();

                    lstAnswers5.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(4))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(4))._option1.ToString()));
                    lstAnswers5.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(4))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(4))._option2.ToString()));
                    lstAnswers5.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(4))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(4))._option3.ToString()));
                    lstAnswers5.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(4))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(4))._option4.ToString()));

                    foreach (ListItem ans in lstAnswers5.Items)
                    {
                        if (ans.Value == answers[4])
                            ans.Selected = true;

                        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(4))._answer.ToString())
                            ans.Attributes["style"] = "color:green";
                        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(4))._answer.ToString())
                            ans.Attributes["style"] = "color:red";
                        else
                            ans.Attributes["style"] = "color:black";
                    }

                    lblQuestion6.Text = questions.ElementAt(quesAnswered.ElementAt(5))._question.ToString();

                    lstAnswers6.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(5))._option1.ToString(), questions.ElementAt(quesAnswered.ElementAt(5))._option1.ToString()));
                    lstAnswers6.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(5))._option2.ToString(), questions.ElementAt(quesAnswered.ElementAt(5))._option2.ToString()));
                    lstAnswers6.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(5))._option3.ToString(), questions.ElementAt(quesAnswered.ElementAt(5))._option3.ToString()));
                    lstAnswers6.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(5))._option4.ToString(), questions.ElementAt(quesAnswered.ElementAt(5))._option4.ToString()));

                    foreach (ListItem ans in lstAnswers6.Items)
                    {
                        if (ans.Value == answers[5])
                            ans.Selected = true;

                        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(5))._answer.ToString())
                            ans.Attributes["style"] = "color:green";
                        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(5))._answer.ToString())
                            ans.Attributes["style"] = "color:red";
                        else
                            ans.Attributes["style"] = "color:black";
                    }

                }
            }
        }
    }
}