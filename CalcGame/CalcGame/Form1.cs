using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGame
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        private Random random;
        private Timer countdownTimer;
        private TimeSpan remainingTime;
        private List<TimeSpan> capturedTimes;

        private double elapsedTime;
        public double value1, value2;
        private double timeLength;

        private IMathOperation activeOperation;
        private IEnumerator<(int, int)> randomNumberEnumerator;

        private int numberRange = 2;
        private int correctAnswerCount;
        private int amountOfQuestions;
        
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator(new Addition());
            random = new Random();

            this.AcceptButton = AnswerButton;
            AnswerButton.Enabled = false;
            
            countdownTimer = new Timer();
            capturedTimes = new List<TimeSpan>();

            countdownTimer.Interval = 1000; // 1 second interval
            countdownTimer.Tick += CountdownTimer_Tick;
            
            remainingTime = TimeSpan.FromMinutes(30);
            timeLength = remainingTime.TotalSeconds;
            
            UpdateTimerLabel();
        }

       

        public IEnumerable<(int, int)> GetRandomPairs(int minValue, int maxValue)
            {

            while (true)
                {
                    yield return (random.Next(minValue, maxValue), random.Next(minValue, maxValue));
                }
            }
        
        public bool GetNextRandomInput()
        {
            if (randomNumberEnumerator == null)
            {
                // Initialize the enumerator with a range
                randomNumberEnumerator = GetRandomPairs(1, numberRange).GetEnumerator(); 
            }

            if (randomNumberEnumerator.MoveNext())
            {
                (value1, value2) = randomNumberEnumerator.Current;
                amountOfQuestions++;
                //MessageBox.Show($"The result is: {value1} {value2}");
                textBox1.Text = value1.ToString();
                textBox2.Text = value2.ToString();
                return true;
            }

            MessageBox.Show("Could not generate random numbers.");
            return false;
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Reduce the remaining time by 1 second
            remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));

            
            UpdateTimerLabel();

            // Check if time is up
            if (remainingTime.TotalSeconds <= 0)
            {
                countdownTimer.Stop();
                Reset_Click(this, null);
                MessageBox.Show("Time's up!", "Timer Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void UpdateTimerLabel()
        {
            labelTimer.Text = remainingTime.ToString(@"mm\:ss");
        }
        public interface IMathOperation
        {
            double Execute(double a, double b);
        }
        public class Addition : IMathOperation
        {
            public double Execute(double a, double b) => a + b;
        }
        
        public class Minus : IMathOperation
        {
            public double Execute(double a, double b) => a - b;
        }

        public class Division : IMathOperation
        {
            public double Execute(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
        }

        public class Multiplication : IMathOperation
        {
            public double Execute(double a, double b) => a * b;
        }
        public class SquareRoot : IMathOperation
        {
            public double Execute(double a, double b = 0) // b is ignored
            {
                if (a < 0)
                {
                    throw new ArgumentException("Cannot calculate the square root of a negative number.");
                }
                return Math.Sqrt(a);
            }
        }

        public class Calculator
        {
            private IMathOperation _operation;

            public Calculator(IMathOperation operation)
            {
                _operation = operation;
            }

            public void SetOperation(IMathOperation operation)
            {
                _operation = operation;
            }

            public double Calculate(double a, double b)
            {
                return _operation.Execute(a, b);
            }
        }
        

        
        

    

        private void Reset_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            remainingTime = TimeSpan.FromMinutes(30);

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            PlayButton.Enabled = true;
            AnswerButton.Enabled = false;

            textBox1.Text = "";
            textBox2.Text = "";
            amountOfQuestions = 0;
            UpdateTimerLabel();
        }

        private void MultiplicationButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiplicationButton.Checked) 
            {
                activeOperation = new Multiplication();
            }
        }

        private void DivisionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DivisionButton.Checked)
            {
                activeOperation = new Division();
            }
        }

        private void SquareRootButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SquareRootButton.Checked)
            {
                activeOperation = new SquareRoot();
            }
        }

        private void MinusButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MinusButton.Checked)
            {
                activeOperation = new Minus();
            }
        }

        private void PlusButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PlusButton.Checked)
            {
                activeOperation = new Addition();
            }
        }

        

        private void TensRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TensRadioButton.Checked)
            {
                numberRange = 10;
                randomNumberEnumerator = null;
            }
        }
        private void HundredsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HundredsRadioButton.Checked)
            {
                numberRange = 100;
                randomNumberEnumerator = null;
            }
        }
        private void ThousandsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ThousandsRadioButton.Checked)
            {
                numberRange = 1000;
                randomNumberEnumerator = null;
            }
        }

        private void HundredThousandsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HundredThousandsRadioButton.Checked)
            {
                numberRange = 10000;
                randomNumberEnumerator = null;
            }

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(numberRange < 10 || activeOperation == null)
            {
                MessageBox.Show("Please select a difficulty first, and the operation first");
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                PlayButton.Enabled = false;
                AnswerButton.Enabled = true;
                
                GetNextRandomInput();
                countdownTimer.Start(); // Start the timer
            }
            
        }

        private void AnswerButton_Click(object sender, EventArgs e) //SUBMIT BUTTON
        {

            
            double result = activeOperation.Execute(value1, value2);
            

            
            AmountOfQuestionsAnsweredLabel.Text = amountOfQuestions.ToString();

            RealRightAnswerLabel.Text = result.ToString();
            CheckResult(result);
            GetNextRandomInput();

        }
        private double TruncateToThreeDecimals(double value)
        {
            return Math.Truncate(value * 1000) / 1000;
        }
        private double CheckResult(double result)
        {
            double userAnswer;
            //MessageBox.Show($"{timeLength}");
            capturedTimes.Add(remainingTime);
            elapsedTime = timeLength - remainingTime.TotalSeconds;
            
            // Check if elapsedTime is non-zero to avoid division by zero
            if (elapsedTime > 0)
            {
                // Average events per minute
                double averagePerMinute = elapsedTime / capturedTimes.Count;

                // Update the label with the average value
                labelAvgTime.Text = $"{averagePerMinute} seconds";
            }
            else
            {
                labelAvgTime.Text = "No elapsed time yet.";
            }
            if (double.TryParse(AnswerTextBox.Text, out userAnswer))
            {
                // Truncate both result and userAnswer to 3 decimal places
                double truncatedResult = TruncateToThreeDecimals(result);
                double truncatedUserAnswer = TruncateToThreeDecimals(userAnswer);

                if (truncatedResult == truncatedUserAnswer)
                {
                    //MessageBox.Show("Correct Answer!");
                    AnswerTextBox.Text = "";
                
                    correctAnswerCount++;
                    labelTotalRightAnswers.Text = correctAnswerCount.ToString();

                }
                else
                {
                    //MessageBox.Show($"Incorrect Answer! The correct answer is {truncatedResult}.");
                    
                    AnswerTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }

            return userAnswer;
        }

    }
}
