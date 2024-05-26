using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TriviaApiLibrary;
using QuestionnaireLibrary;
using ScoreBoardLibrary;

namespace Questionnaire_The_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Question> questions = new List<Question>();
        private static List<Answer> answers = new List<Answer>();
        private static int amountOfQuestions = 12;
        private static int currentQuestion = 1;
        private static int maxScore = amountOfQuestions;
        private static int currentScore = 0;
        private static Scoreboard scoreboard = new Scoreboard();
        private static string correctAnswer;
        private static int currentQuestionIndex = 0;
        private static Question CurrentQuestion => questions[currentQuestionIndex];



        public MainWindow()
        {
            InitializeComponent();

            
            answer1.Visibility = Visibility.Hidden;
            answer2.Visibility = Visibility.Hidden;
            answer3.Visibility = Visibility.Hidden;
            answer4.Visibility = Visibility.Hidden;
            question.Visibility = Visibility.Hidden;
            submitName.Visibility = Visibility.Hidden;
            name.Visibility = Visibility.Hidden;


        }

        private void NextQuestion(object sender, RoutedEventArgs e)
        {
            

            if (currentQuestion != amountOfQuestions)
            {
                
                
                currentQuestion++;

                LoadQuestion();

            }
            else
            {
                question.Visibility = Visibility.Hidden;
                answer1.Visibility = Visibility.Hidden;
                answer2.Visibility = Visibility.Hidden;
                answer3.Visibility = Visibility.Hidden;
                answer4.Visibility = Visibility.Hidden;
                scoreboardButton.Visibility = Visibility.Visible;
                result.Visibility = Visibility.Visible;
                name.Visibility = Visibility.Visible;
                submitName.Visibility = Visibility.Visible;
                result.Text = "Well done your score is: " + currentScore + "/" + amountOfQuestions.ToString() + " Please give your name for in the scoreboard";
            }


        }

        private void answer1_Click(object sender, RoutedEventArgs e)
        {
            string answered = Convert.ToString(answer1.Content);
            if (answered == correctAnswer)
            {
                score.Text = "Score: " + (currentScore + 1) + "/" + maxScore;
                currentScore++;
            }
            
            if (currentQuestion != amountOfQuestions)
            {
                
                currentQuestion++;
                LoadQuestion();

            }
            else
            {
                question.Visibility = Visibility.Hidden;
                answer1.Visibility = Visibility.Hidden;
                answer2.Visibility = Visibility.Hidden;
                answer3.Visibility = Visibility.Hidden;
                answer4.Visibility = Visibility.Hidden;
                result.Visibility = Visibility.Visible;
                name.Visibility = Visibility.Visible;
                scoreboardButton.Visibility = Visibility.Visible;
                submitName.Visibility = Visibility.Visible;
                result.Text = "Well done your score is: " + currentScore + "/" + amountOfQuestions.ToString() + " Please give your name for in the scoreboard";
            }
        }

        private void answer2_Click(object sender, RoutedEventArgs e)
        {
            string answered = Convert.ToString(answer2.Content);
            if (answered == correctAnswer)
            {
                score.Text = "Score: " + (currentScore + 1) + "/" + maxScore;
                currentScore++;
            }
            
            if (currentQuestion != amountOfQuestions)
            { 
                

                currentQuestion++;

                LoadQuestion();

            }
            else
            {
                question.Visibility = Visibility.Hidden;
                answer1.Visibility = Visibility.Hidden;
                answer2.Visibility = Visibility.Hidden;
                answer3.Visibility = Visibility.Hidden;
                answer4.Visibility = Visibility.Hidden;
                result.Visibility = Visibility.Visible;
                name.Visibility = Visibility.Visible;
                scoreboardButton.Visibility = Visibility.Visible;
                submitName.Visibility = Visibility.Visible;
                result.Text = "Well done your score is: " + currentScore + "/" + amountOfQuestions.ToString() + " Please give your name for in the scoreboard";
            }
        }

        private void answer3_Click(object sender, RoutedEventArgs e)
        {
            string answered = Convert.ToString(answer3.Content);
            if (answered == correctAnswer)
            {
                score.Text = "Score: " + (currentScore + 1) + "/" + maxScore;
                currentScore++;
            }
            if (currentQuestion != amountOfQuestions)
            {
                

                currentQuestion++;

                LoadQuestion();

            }
            else
            {
                question.Visibility = Visibility.Hidden;
                answer1.Visibility = Visibility.Hidden;
                answer2.Visibility = Visibility.Hidden; 
                answer3.Visibility = Visibility.Hidden;
                answer4.Visibility = Visibility.Hidden;
                result.Visibility = Visibility.Visible;
                name.Visibility = Visibility.Visible;
                submitName.Visibility = Visibility.Visible;

                scoreboardButton.Visibility = Visibility.Visible;
                result.Text = "Well done your score is: " + currentScore + "/" + amountOfQuestions.ToString() + " Please give your name for in the scoreboard";
            }
        }

        private void answer4_Click(object sender, RoutedEventArgs e)
        {
            string answered = Convert.ToString(answer4.Content);
            if (answered == correctAnswer)
            {
                score.Text = "Score: " + (currentScore + 1) + "/" + maxScore;
                currentScore++;
            }
            if (currentQuestion != amountOfQuestions)
            {

                currentQuestion++;

                LoadQuestion();

            }
            else
            {
                question.Visibility = Visibility.Hidden;
                answer1.Visibility = Visibility.Hidden;
                answer2.Visibility = Visibility.Hidden;
                answer3.Visibility = Visibility.Hidden;
                answer4.Visibility = Visibility.Hidden;
                result.Visibility = Visibility.Visible;
                submitName.Visibility = Visibility.Visible;
                scoreboardButton.Visibility = Visibility.Visible;
                name.Visibility = Visibility.Visible;
                result.Text = "Well done your score is: " + currentScore + "/" + amountOfQuestions.ToString() + " Please give your name for in the scoreboard";
            }
        }

        private void submitName_Click(object sender, RoutedEventArgs e)
        {
            if(name.Text == null)
            {
                MessageBox.Show("You need to fill a name in");
            }
            else
            {
                scoreboard.AddPlayer(name.Text, currentScore);
            }
            
        }

        private void scoreboardButton_Click(object sender, RoutedEventArgs e)
        {
            
            ScoreboardWindow scoreboardwindow = new ScoreboardWindow(scoreboard);
                
            this.Visibility = Visibility.Hidden;
            scoreboardwindow.Show();
            currentQuestion = 1;
            currentScore = 0;
        }
    
    

        

        private void start_Click(object sender, RoutedEventArgs e) {

            start.Visibility = Visibility.Hidden;
            scoreboardButton.Visibility = Visibility.Hidden;
            aboutButton.Visibility = Visibility.Hidden;


            LoadQuestion();
            answer1.Visibility = Visibility.Visible;
            answer2.Visibility = Visibility.Visible;
            answer3.Visibility = Visibility.Visible;
            answer4.Visibility = Visibility.Visible;
            question.Visibility = Visibility.Visible;
            
        }



        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            this.Visibility = Visibility.Hidden;
            aboutWindow.Show();
        }




        public static List<T> Shuffle<T>(List<T> list)
        {
            Random rnd = new();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]);
            }
            return list;
        }
        private class Questionhandler : IQuestionHandler
        {
            public void ProcessQuestion(TriviaMultipleChoiceQuestion question)
            {
                if (question == null) { return; }
                else
                {
                    Question newQuestion = new Question(question.Question.Text);

                    newQuestion.Add(new Answer(question.CorrectAnswer, true));
                    correctAnswer = question.CorrectAnswer;
                    foreach (string incorrectAnswer in question.IncorrectAnswers)
                    {
                        newQuestion.Add(new Answer(incorrectAnswer, false));
                    }
                    questions.Add(newQuestion);

                }
            }
        }


        private async void LoadQuestion()
        {
            IQuestionHandler handler = new Questionhandler();

            await TriviaApiRequester.RequestRandomQuestion(handler);

            foreach (Question question in questions)
            {
                PromptQuestion(question);
                DisplayAnswers(question);

            }
            QuestionIndex.Text = $"Question {currentQuestion} out of {amountOfQuestions}";
        }
        
        private void PromptQuestion(Question newQuestion)
        {
            question.Text = newQuestion.Text;
        }

        private void DisplayAnswers(Question question)
        {

          var answers = new List<string>
          {
          question.GetAnswer(1).ToString(),
          question.GetAnswer(2).ToString(),
          question.GetAnswer(3).ToString(),
          question.GetAnswer(4).ToString()
          };
          
            var random = new Random();
            answers = answers.OrderBy(a => random.Next()).ToList();

            answer1.Content = answers[0];
            answer2.Content = answers[1];
            answer3.Content = answers[2];
            answer4.Content = answers[3];

            
        }
        
    }
  }
