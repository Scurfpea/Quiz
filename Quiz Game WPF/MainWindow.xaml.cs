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

namespace Quiz_Game_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionsNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        int qNum = 0;

        int i;

        int score;
        
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }
            scoreText.Content = "Answered correctly " + score + "/" + questionsNumbers.Count;
        
            NextQuestion();
        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1; //player will have to double click to start game.
            i = 0;
            StartGame();
        }

        private void NextQuestion()
        {
            if(qNum < questionsNumbers.Count)
            {
                i = questionsNumbers[qNum];
            }
            else
            {
                RestartGame();
            }
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i) 
            {
                case 1:

                    txtQuestion.Text = "Question 1";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1"; //which of the ans is correct if ans2 is correct write ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/1.PNG"));

                    break;
                case 2:

                    txtQuestion.Text = "Question 2";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/2.PNG"));

                    break;

                case 3:

                    txtQuestion.Text = "Question 3";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/3.PNG"));

                    break;
                case 4:

                    txtQuestion.Text = "Question 4";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/4.PNG"));

                    break;

                case 5:

                    txtQuestion.Text = "Question 5";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/5.PNG"));

                    break;

                case 6:

                    txtQuestion.Text = "Question 6";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/6.PNG"));

                    break;

                case 7:

                    txtQuestion.Text = "Question 7";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/7.PNG"));

                    break;

                case 8:

                    txtQuestion.Text = "Question 8";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/8.PNG"));

                    break;

                case 9:

                    txtQuestion.Text = "Question 9";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/9.PNG"));

                    break;

                case 10:

                    txtQuestion.Text = "Question 10";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/10.PNG"));

                    break;

                case 11:

                    txtQuestion.Text = "Question 11";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/11.PNG"));

                    break;

                case 12:

                    txtQuestion.Text = "Question 12";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/12.PNG"));

                    break;

            }



        }
        private void StartGame()
        {
            var randomList = questionsNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionsNumbers = randomList;

            questionOrder.Content = null;

            for (int i = 0; i < questionsNumbers.Count; i++)
            {
                questionOrder.Content += "" + questionsNumbers[i].ToString();   //randomizing the order         }
            }
        }
    }
}
