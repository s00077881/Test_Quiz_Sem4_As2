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
        public List<Quiz> QuizCurrentList = new List<Quiz>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PullCat(object sender, EventArgs e)
        {
        }

        private void ReadTextFile(string p)
        {
            throw new NotImplementedException();
        }

        protected void btnSportCat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Quiz quiz;

            string path = Server.MapPath("Quizzes.txt");
            string[] readFile = File.ReadAllLines(path);
            string[] splitLine;

            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                if (splitLine[2] == btn.Text)
                {
                    quiz = new Quiz(splitLine[0], splitLine[1], splitLine[2]);
                    QuizCurrentList.Add(quiz);
                }
            }

            for (int i = 0; i < QuizCurrentList.Count; i++)
            {
                lstQuizSelect.Items.Add(QuizCurrentList.ElementAt(i)._quizName);
            }
        }
    }
}