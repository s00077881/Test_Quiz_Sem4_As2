using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Assignment1_Quiz
{
    public partial class quizSelection : System.Web.UI.Page
    {
        //List of currently loaded quizzes // Populate from text file "Quizzes.txt"
        public List<Quiz> quizCurrentList = new List<Quiz>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Fireing everytime there a post back overwriting the value I want .. must fix

            int selectedIndex = 0;
            selectedIndex = lstAddQuiz.SelectedIndex;
            ViewState.Add("quizSelectedIndex", selectedIndex);
        }

        protected void btnCat_Click(object sender, EventArgs e)
        {
            //Button 
            ImageButton btn = (ImageButton)sender;
            Quiz quiz;

            string[] readFile = File.ReadAllLines(Server.MapPath("Quizzes.txt"));
            string[] splitLine;

            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                if (splitLine[2] == btn.AlternateText)
                {
                    quiz = new Quiz(splitLine[0], splitLine[1], splitLine[2]);
                    quizCurrentList.Add(quiz);
                }
            }

            lstQuizSelect.Items.Clear();

            //Add quiz dropdown list
            for (int i = 0; i < quizCurrentList.Count; i++)
            {
                lstQuizSelect.Items.Add(new ListItem(quizCurrentList.ElementAt(i)._quizName, quizCurrentList.ElementAt(i)._quizID));
            }
        }

        protected void startQuiz_Click(object sender, EventArgs e)
        {
            List<QuizQuestions> questions = new List<QuizQuestions>();

            QuizQuestions question;
            string[] readFile = File.ReadAllLines(Server.MapPath("QuizQuestions.txt"));
            string[] splitLine;


            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                if (splitLine[0] == lstQuizSelect.SelectedValue)
                {
                    question = new QuizQuestions(splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6]);
                    questions.Add(question);
                }
            }

            Session.Add("timeStart", DateTime.Now);
            Session.Add("questions", questions);
            Session.Add("quesAnswered", RandomArray());
            Response.Redirect("question1.aspx");
        }

        protected List<int> RandomArray()
        {
            List<int> quesAnswered = new List<int>();
            Random rnd = new Random();
            int num;

            while (quesAnswered.Count < 6)
            {
                num = rnd.Next(0, 6);

                if (!quesAnswered.Contains(num))
                    quesAnswered.Add(num);

            }

            return quesAnswered;
        }

        protected void btnAdQuiz_Click(object sender, EventArgs e)
        {
            /************************************
             Add New Quiz To The Quizes Text File
             ************************************/

            List<Quiz> newQuiz = new List<Quiz>();

            Quiz readQuiz;

            //Get quiz information (name, category)
            string name = tbxCreateName.Text;
            string category = lstCat.SelectedValue;

            //Read in text file
            string[] readFile = File.ReadAllLines(Server.MapPath("Quizzes.txt"));
            string[] splitLine;

            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                readQuiz = new Quiz(splitLine[0], splitLine[1], splitLine[2]);
                newQuiz.Add(readQuiz);
            }

            string id = Convert.ToString(newQuiz.Count + 1);

            //Add new quiz to the newquiz list
            readQuiz = new Quiz(id, name, category);
            newQuiz.Add(readQuiz);

            //Write collection to "Quizzes.txt" file
            string[] writeToFile = new string[newQuiz.Count];

            for (int i = 0; i < newQuiz.Count; i++)
            {
                Quiz currentQuiz = newQuiz.ElementAt(i);
                writeToFile[i] = currentQuiz.WriteFormat();
            }
            File.WriteAllLines((Server.MapPath("Quizzes.txt")), writeToFile);


            /************************************************
             Add New Question To The Quiz Question Text File
             ************************************************/
            List<QuizQuestions> oldQuestions = new List<QuizQuestions>();
            List<QuizQuestions> newQuestions = (List<QuizQuestions>)ViewState["formQuestions"];


            //Read in text file
            readFile = File.ReadAllLines(Server.MapPath("QuizQuestions.txt"));
            QuizQuestions qq;


            //Read in quizQuestion text file
            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                qq = new QuizQuestions(splitLine[0],splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6]);
                oldQuestions.Add(qq);
            }

            for (int i = 0; i < newQuestions.Count; i++)
            {
                 qq = new QuizQuestions(
                     id,
                     newQuestions.ElementAt(i)._question,
                     newQuestions.ElementAt(i)._option1,
                     newQuestions.ElementAt(i)._option2,
                     newQuestions.ElementAt(i)._option3,
                     newQuestions.ElementAt(i)._option4,
                     newQuestions.ElementAt(i)._answer
                     );
                 oldQuestions.Add(qq);
            }

            //Write collection to "QuizQuestions.txt" file
            writeToFile = new string[oldQuestions.Count];


            for (int i = 0; i < oldQuestions.Count; i++)
            {
                QuizQuestions curQuestion = oldQuestions.ElementAt(i);
                writeToFile[i] = curQuestion.WriteQuestions();
            }

            File.WriteAllLines((Server.MapPath("QuizQuestions.txt")), writeToFile);
        }

        protected void lstAddQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Store questions added to quiz form
            List<QuizQuestions> quizQ = new List<QuizQuestions>();
            QuizQuestions curQues = new QuizQuestions();

            //Store new questions in viewstate
            if (ViewState["formQuestions"] != null)
            {
                quizQ = (List<QuizQuestions>)ViewState["formQuestions"];

                //Populate question input boxes with previous answers
                if (quizQ.ElementAt(lstAddQuiz.SelectedIndex) != null)
                {
                    tbxEnterQuestion.Text = quizQ.ElementAt(lstAddQuiz.SelectedIndex)._question;
                    tbxOption1.Text = quizQ.ElementAt(lstAddQuiz.SelectedIndex)._option1;
                    tbxOption2.Text = quizQ.ElementAt(lstAddQuiz.SelectedIndex)._option2;
                    tbxOption3.Text = quizQ.ElementAt(lstAddQuiz.SelectedIndex)._option3;
                    tbxOption4.Text = quizQ.ElementAt(lstAddQuiz.SelectedIndex)._option4;

                    switch (quizQ.ElementAt(lstAddQuiz.SelectedIndex)._answer)
                    {
                        case "Option1":
                            lstSelectAns.SelectedIndex = 0;
                            break;
                        case "Option2":
                            lstSelectAns.SelectedIndex = 1;
                            break;
                        case "Option3":
                            lstSelectAns.SelectedIndex = 2;
                            break;
                        case "Option4":
                            lstSelectAns.SelectedIndex = 3;
                            break;
                    }
                }
                else
                {
                    tbxEnterQuestion.Text = string.Empty;
                    tbxOption1.Text = string.Empty;
                    tbxOption2.Text = string.Empty;
                    tbxOption3.Text = string.Empty;
                    tbxOption4.Text = string.Empty;

                    lstSelectAns.SelectedIndex = 0;
                }
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    quizQ.Insert(i, curQues);
                }
            }



            //Check if postback to stop jQuery animations breaking
            if (IsPostBack)
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "IsPostBack", "var isPostBack = true;", true);
            }

            string selectedAns ="";

            switch(lstSelectAns.SelectedValue)
            {
                case "Option1":
                    selectedAns = tbxOption1.Text;
                    break;
                case "Option2":
                    selectedAns = tbxOption2.Text;
                    break;
                case "Option3":
                    selectedAns = tbxOption3.Text;
                    break;
                case "Option4":
                    selectedAns = tbxOption4.Text;
                    break;
            }
            
            curQues = new QuizQuestions(tbxEnterQuestion.Text, tbxOption1.Text, tbxOption2.Text, tbxOption3.Text, tbxOption4.Text, selectedAns);
            quizQ.RemoveAt(Convert.ToInt32(ViewState["quizSelectedIndex"]));
            quizQ.Insert(Convert.ToInt32(ViewState["quizSelectedIndex"]), curQues);

            ViewState.Add("formQuestions", quizQ);
        }
    }
}