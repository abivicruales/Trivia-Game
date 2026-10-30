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

namespace Soccer_Project___Abi
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Window
    {
        int soccerGamePoints = 0;
        int questionNumber = 1;

        // Tracks which button has the right answer like (1, 2, 3, or 4)
        int correctAnswerNumber = 3; // Question 1 (Zidane) is Button 3 and it knows that if its correcr it will add 1 point +

        public Page1()
        {
            InitializeComponent();
            score.Text = "Score: 0/1";
        }

        private void CheckAnswer(int selectedButtonNumber)
        {
            if (selectedButtonNumber == correctAnswerNumber)
            {
                ResultText.Text = "Correct!";
                soccerGamePoints = soccerGamePoints + 1;
            }
            else
            {
                ResultTextIncorrect.Text = "Incorrect!";
            }

            score.Text = "Score: " + soccerGamePoints + "/" + questionNumber;
            DisableAllAnswerButtons();
        }

        private void Answer1Button_Click(object sender, RoutedEventArgs e) => CheckAnswer(1);
        private void Answer2Button_Click(object sender, RoutedEventArgs e) => CheckAnswer(2);
        private void Answer3Button_Click(object sender, RoutedEventArgs e) => CheckAnswer(3);
        private void Answer4Button_Click(object sender, RoutedEventArgs e) => CheckAnswer(4);

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // If the game is already over make the Next button close the app
            if (questionNumber >= 10)
            {
                this.Close();
                return;
            }

            questionNumber = questionNumber + 1;

            ResultText.Text = "";
            ResultTextIncorrect.Text = "";
            EnableAllAnswerButtons();

            // Part 2
            if (questionNumber == 2)
            {
                QuestionText.Text = "Who is Real Madrid's Top scorer?";
                Answer1Button.Content = "Ronaldo";
                Answer2Button.Content = "Di Stéfano";
                Answer3Button.Content = "Benzema";
                Answer4Button.Content = "Mbappe";
                correctAnswerNumber = 1; // Correct: Ronaldo
                score.Text = "Score: " + soccerGamePoints + "/2";
            }
            // SLOT 3
            else if (questionNumber == 3)
            {
                QuestionText.Text = "What minute did S.Ramos score his legendary goal for Real Madrid?";
                Answer1Button.Content = "93'";
                Answer2Button.Content = "93:48'";
                Answer3Button.Content = "94:38";
                Answer4Button.Content = "92:48'";
                correctAnswerNumber = 4; // Correct: 92:48'
                score.Text = "Score: " + soccerGamePoints + "/3";
            }
            // SLOT 4
            else if (questionNumber == 4)
            {
                QuestionText.Text = "Which manager led Real Madrid to three consecutive Champions League titles?";
                Answer1Button.Content = "Ancelotti";
                Answer2Button.Content = "Zidane";
                Answer3Button.Content = "Muñoz";
                Answer4Button.Content = "Mourinho";
                correctAnswerNumber = 2; // Correct: Zidane
                score.Text = "Score: " + soccerGamePoints + "/4";
            }
            // SLOT 5
            else if (questionNumber == 5)
            {
                QuestionText.Text = "How many El Clásico wins does Real Madrid have?";
                Answer1Button.Content = "98";
                Answer2Button.Content = "105";
                Answer3Button.Content = "106";
                Answer4Button.Content = "102";
                correctAnswerNumber = 3; // Correct: 106
                score.Text = "Score: " + soccerGamePoints + "/5";
            }
            // SLOT 6
            else if (questionNumber == 6)
            {
                QuestionText.Text = "When was Real Madrid founded?";
                Answer1Button.Content = "March 6, 1902";
                Answer2Button.Content = "March 16, 1902";
                Answer3Button.Content = "May 6, 1903";
                Answer4Button.Content = "March 6, 1903";
                correctAnswerNumber = 1; // Correct: March 6, 1902
                score.Text = "Score: " + soccerGamePoints + "/6";
            }
            // SLOT 7
            else if (questionNumber == 7)
            {
                QuestionText.Text = "Who was the famous Real Madrid attacking trio known as 'BBC'?";
                Answer1Button.Content = "Brahim, Bellingham, Camavinga";
                Answer2Button.Content = "Bale, Benzema, Cristiano";
                Answer3Button.Content = "Beckham, Bale, Cristiano";
                Answer4Button.Content = "Bernardo, Brahim, Cucurella";
                correctAnswerNumber = 2; //Correct: Bale, Benzema, Cristiano
                score.Text = "Score: " + soccerGamePoints + "/7";
            }
            // SLOT 8
            else if (questionNumber == 8)
            {
                QuestionText.Text = "How many Champions League titles has Real Madrid won?";
                Answer1Button.Content = "8";
                Answer2Button.Content = "16";
                Answer3Button.Content = "13";
                Answer4Button.Content = "15";
                correctAnswerNumber = 4; // Correct: 15
                score.Text = "Score: " + soccerGamePoints + "/8";
            }
            // SLOT 9
            else if (questionNumber == 9)
            {
                QuestionText.Text = "Which manager led Real Madrid to 'La Décima' in 2014";
                Answer1Button.Content = "Vincente Del Bosque";
                Answer2Button.Content = "Mourinho";
                Answer3Button.Content = "Ancelotti";
                Answer4Button.Content = "Zidane";
                correctAnswerNumber = 3; // Correct: Ancelotti
                score.Text = "Score: " + soccerGamePoints + "/9";
            }
            // SLOT 10 (Final Question)
            else if (questionNumber == 10)
            {
                QuestionText.Text = "Who did Real Madrid beat in 2022 UCL after having a 1% chance to win?";
                Answer1Button.Content = "Arsenal";
                Answer2Button.Content = "Manchester United";
                Answer3Button.Content = "Chelsea";
                Answer4Button.Content = "Manchester City";
                correctAnswerNumber = 4;
                score.Text = "Score: " + soccerGamePoints + "/10"; // Correct: Manchester City

                // Change button text to indicate the quiz is ending
                NextButton.Content = "Finish Quiz";
            }
        }

        // Helps things
        private void DisableAllAnswerButtons()
        {
            Answer1Button.IsEnabled = false;
            Answer2Button.IsEnabled = false;
            Answer3Button.IsEnabled = false;
            Answer4Button.IsEnabled = false;
        }

        private void EnableAllAnswerButtons()
        {
            Answer1Button.IsEnabled = true;
            Answer2Button.IsEnabled = true;
            Answer3Button.IsEnabled = true;
            Answer4Button.IsEnabled = true;
        }

        private void ScoreText_ContextMenuClosing(object sender, ContextMenuEventArgs e) { }
        private void ResultTextIncorrect_ContextMenuClosing(object sender, ContextMenuEventArgs e) { }
    }
}
