using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathquiz
{
    public partial class Form1 : Form
    {
        // Create a Random object to generate random numbers.
        Random randomizer = new Random();


        // These ints will store the numbers
        // for the addition problem.
        int addend1;
        int addend2;


        // These ints will store the numbers
        // for the subtraction problem.
        int minuend;
        int subtrahend;


        // These ints will store the numbers for the multiplication problem.
        int multiplicand;
        int multiplier;


        // These ints will store the numbers for the division problem.
        int dividend;
        int divisor;


        // This int will keep track of the time left.
        int timeLeft;

        /// <summary>
        /// This start the quiz filling all the problems
        /// and start the timer
        /// </summary>
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            LeftPluslabel.Text = addend1.ToString();
            RightPluslabel.Text = addend2.ToString();
            sum.Value = 0;


            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            LeftMinuslabel.Text = minuend.ToString();
            RightMinuslabel.Text = subtrahend.ToString();
            difference.Value = 0;




            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            LeftMultilabel.Text = multiplicand.ToString();
            RightMultilabel.Text = multiplier.ToString();
            product.Value = 0;


            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            LeftDividelabel.Text = dividend.ToString();
            RightDividelable.Text = divisor.ToString();
            quotient.Value = 0;




            // Start the timer.
            timeLeft = 30;
            Timelable.Text = "30 seconds";
            timer1.Start();


        }


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If the user got the answer right, stop the timer 
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations");
                StartGameButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Timelable.Text = timeLeft + " seconds";


            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                Timelable.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                StartGameButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }


        private void StartGameButton_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartGameButton.Enabled = false;
        }
    }
}
