using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class quizFinish : System.Web.UI.Page
    {
        List<QuizQuestions> qq;
        List<int> quesAnswered;
        List<SelectedAnswer> answers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                qq = (List<QuizQuestions>)Session["questions"];
                quesAnswered = (List<int>)Session["quesAnswered"];
                answers = (List<SelectedAnswer>)Session["answers"];

                if (answers != null)
                {
                    for (int i = 0; i < answers.Count; i++)
                    {
                        ShowQuestionResults(i);
                    }
                }
            }
        }

        private void ShowQuestionResults(int index)
        {
            Panel div = new Panel();
            div.CssClass = "spacer";

            Label lblQuestion = new Label();
            lblQuestion.Attributes["style"] = "font-weight: bold";
            RadioButtonList lstAnswers = new RadioButtonList();
            lstAnswers.Enabled = false;

            var quesAns = from item in qq
                          where item._questionId == quesAnswered[index]
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

            foreach (ListItem ans in lstAnswers.Items)
            {
                if (ans.Value == answers[index]._answer)
                    ans.Selected = true;

                if (ans.Selected == true && answers[index]._value == 1)
                {
                    ans.Attributes["style"] = "color:green";
                }
                else if (ans.Selected == true && answers[index]._value == 0)
                    ans.Attributes["style"] = "color:red";
                else
                    ans.Attributes["style"] = "color:black";
            }


            div.Controls.Add(lblQuestion);
            div.Controls.Add(lstAnswers);
            divLeftColumn.Controls.Add(div);
        }
    }
}