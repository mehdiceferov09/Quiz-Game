using System;

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> questions = new Dictionary<string, string>
        {
            { "What has keys but can’t open locks?", "piano" }, //1
            { "Which planet is known as the Red Planet?", "mars" }, //2
            { "What runs but never walks?", "water" }, //3
            { "How many continents are there on Earth?", "7" }, //4
            { "What has a face and two hands \n but no arms or legs?", "clock" }, //5
            { "What goes up but never comes down?", "age" }, //6
            { "Which metal is liquid at room temperature?", "mercury" }, //7
            { "What has a neck but no head?", "bottle" }, //8
            { "Which animal is known as the King of the Jungle?", "lion" }, //9
            { "What has many teeth but cannot bite?", "comb" } //10
        };

        List<string> questionsList = new List<string>()
        {
            "What has keys but can’t open locks?",
            "Which planet is known as the Red Planet?",
            "What runs but never walks?",
            "How many continents are there on Earth?",
            "What has a face and two hands \n but no arms or legs?",
            "What goes up but never comes down?",
            "Which metal is liquid at room temperature?",
            "What has a neck but no head?",
            "Which animal is known as the King of the Jungle?",
            "What has many teeth but cannot bite?"
        };

        List<int> usedQuestions = new List<int>();

        Random random = new Random();

        int index;

        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewQuestionBtn_Click(object sender, EventArgs e)
        {
            scoreNum.Text = score.ToString();

            do {
                index = random.Next(questionsList.Count);
            } while (usedQuestions.Contains(index));

            usedQuestions.Add(index);

            QuestionTxt.Text = questionsList[index];

            AnswerBox.Focus();
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            string answer = questions[questionsList[index]];

            if (usedQuestions.Count == 0)
            {
                MessageBox.Show("Please get a question first.");
                return;
            }

            if (string.Equals(AnswerBox.Text.Trim(), answer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Correct answer!");
                score++;
                scoreNum.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("Wrong answer!");
            }

            if (usedQuestions.Count == questionsList.Count)
            {
                MessageBox.Show($"You have answered all the questions.\nYour score is {score}");

                QuestionTxt.Text = "";
                AnswerBox.Text = "";
                usedQuestions.Clear();
                score = 0;
                scoreNum.Text = "0";
            }

            AnswerBox.Text = string.Empty;
        }
    }
}
