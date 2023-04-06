using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        string[] yogaPositions = {"Three Legged Downward Facing Dog", "Lotus Pose", "Downward Facing Dog", "Tree Poses", "Garland Yogi Squat", "Wide Child's Poses", "Upward Dog", "Pigeon Pose", "Cow Pose", "Bound Angle", "Flower Pose", "Seated Meditation Pose" };

        int qNum = 0;

        int i;

        int score;

        int ansNum1 = 0;
        int ansNum2 = 0;
        int ansNum3 = 0;
        int ansNum4 = 0;
        
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

        
        private void RandomizeAnswer1()
        {
            Random random = new Random();
            do
            {
                ansNum1 = random.Next(1, 12);
                ans1.Content = yogaPositions[ansNum1];
            }
            while (ansNum1 == i-1 || ansNum1 == ansNum3 || ansNum1 == ansNum2 || ansNum1 == ansNum4);//minus 1 because the arrays starts at 0                    
        }

        private void RandomizeAnswer2()
        {
            Random random = new Random();
            do
            {
                ansNum2 = random.Next(1, 12);
                ans2.Content = yogaPositions[ansNum2];
            }
            while (ansNum2 == i-1 || ansNum2 == ansNum1 || ansNum2 == ansNum3 || ansNum2 == ansNum4);                              
        }

        private void RandomizeAnswer3()
        {            
            Random random = new Random();
            do
            {
                ansNum3 = random.Next(1, 12);
                ans3.Content = yogaPositions[ansNum3];
            }
            while (ansNum3 == i-1 || ansNum3 == ansNum1 || ansNum3 == ansNum2 || ansNum3 == ansNum4); //i is current question                    
        }
        private void RandomizeAnswer4()
        {
            Random random = new Random();
            do
            {
                ansNum4 = random.Next(1, 12);
                ans4.Content = yogaPositions[ansNum4];
            }
            while (ansNum4 == i-1 || ansNum4 == ansNum1 || ansNum4 == ansNum2 || ansNum4 == ansNum3);
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

                    RandomizeAnswer1();
                    ans2.Content = "Three Legged Downward Facing Dog";
                    RandomizeAnswer3();
                    RandomizeAnswer4();                    
                   
               
                    ans2.Tag = "1"; //which of the ans is correct if ans2 is correct write ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/1.PNG"));

                    break;
                case 2:

                    txtQuestion.Text = "Question 2";

                    RandomizeAnswer1();
                    RandomizeAnswer2();
                    RandomizeAnswer3();                    
                    ans4.Content = "Lotus Pose";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/2.PNG"));

                    break;

                case 3:

                    txtQuestion.Text = "Question 3";

                    ans1.Content = "Downward Facing Dog";                  
                    RandomizeAnswer2();
                    RandomizeAnswer3();
                    RandomizeAnswer4();

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/3.PNG"));

                    break;
                case 4:

                    txtQuestion.Text = "Question 4";

                    RandomizeAnswer1();
                    RandomizeAnswer2();
                    ans3.Content = "Tree Poses";
                    RandomizeAnswer4();

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/4.PNG"));

                    break;

                case 5:

                    txtQuestion.Text = "Question 5";

                    RandomizeAnswer1();
                    RandomizeAnswer2();
                    RandomizeAnswer3();                    
                    ans4.Content = "Garland  Yogi Squat";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/5.PNG"));

                    break;

                case 6:

                    txtQuestion.Text = "Question 6";

                    ans1.Content = "Wide Childs Poses";
                    RandomizeAnswer2();
                    RandomizeAnswer3();
                    RandomizeAnswer4();

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/6.PNG"));

                    break;

                case 7:

                    txtQuestion.Text = "Question 7";

                    RandomizeAnswer1();                    
                    ans2.Content = "Upward Dog";                    
                    RandomizeAnswer3();
                    RandomizeAnswer4();

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/7.PNG"));

                    break;

                case 8:

                    txtQuestion.Text = "Question 8";

                    RandomizeAnswer1();
                    RandomizeAnswer2();
                    RandomizeAnswer3();
                    ans4.Content = "Pigeon Pose";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/8.PNG"));

                    break;

                case 9:

                    txtQuestion.Text = "Question 9";

                    RandomizeAnswer1();
                    RandomizeAnswer2();                    
                    ans3.Content = "Cow Pose";
                    RandomizeAnswer4();

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/9.PNG"));

                    break;

                case 10:

                    txtQuestion.Text = "Question 10";

                    ans1.Content = "Bound Angle";
                    RandomizeAnswer2();
                    RandomizeAnswer3();
                    RandomizeAnswer4();

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/10.PNG"));

                    break;

                case 11:

                    txtQuestion.Text = "Question 11";

                    RandomizeAnswer1();
                    RandomizeAnswer2();
                    RandomizeAnswer3();
                    ans4.Content = "Flower Pose";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/11.PNG"));

                    break;

                case 12:

                    txtQuestion.Text = "Question 12";

                    RandomizeAnswer1();                    
                    ans2.Content = "Seated Meditation Pose";
                    RandomizeAnswer3();
                    RandomizeAnswer4();

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
