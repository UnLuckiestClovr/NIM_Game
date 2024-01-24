using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIM_Game
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateMathProblem();
        }

        private void OptionBTN1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Option 1 Pressed");
        }

        private void OptionBTN2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Option 3 Pressed");
        }

        private void DialogueLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void OptionBTN2_Click_1(object sender, EventArgs e)
        {
            DialogueLabel.Text = "Clicked BTN2";
        }

        private void OptionBTN4_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Option 4 Pressed");
        }

        private Random random = new Random();
        public void generateMathProblem()
        {
            int intOne = random.Next(10);
            int intTwo = random.Next(10);
            int mathType = random.Next(3);
            switch (mathType)
            {
                case 0:
                    //addition
                    DialogueLabel.Text = $"What is the answer to the math problem: {intOne} + {intTwo}";
                    int answerAdd = intOne + intTwo;
                    setCorrectAnswer(answerAdd);
                    break;
                case 1:
                    //subtration
                    DialogueLabel.Text = $"What is the answer to the math problem: {intOne} - {intTwo}";
                    int answerSubtract = intOne - intTwo;
                    setCorrectAnswer(-answerSubtract);
                    break;
                case 2:
                    //multiplication
                    DialogueLabel.Text = $"What is the answer to the math problem: {intOne} * {intTwo}";
                    int answerMultiply = intOne * intTwo;
                    setCorrectAnswer(answerMultiply);
                    break;
                default:
                    DialogueLabel.Text = "Something Is Broken In The Math Switch Statement";
                    break;
            }

        }

        public void setCorrectAnswer(int correctAnswer)
        {
            int answerButton = random.Next(4);
            switch (answerButton)
            {
                case 0:
                    OptionBTN1.Text = correctAnswer.ToString();
                    OptionBTN2.Text = random.Next(10).ToString();
                    OptionBTN3.Text = random.Next(10).ToString();
                    OptionBTN4.Text = random.Next(10).ToString();
                    break;
                case 1:
                    OptionBTN2.Text = correctAnswer.ToString();
                    OptionBTN3.Text = random.Next(10).ToString();
                    OptionBTN4.Text = random.Next(10).ToString();
                    OptionBTN1.Text = random.Next(10).ToString();
                    break;
                case 2:
                    OptionBTN3.Text = correctAnswer.ToString();
                    OptionBTN4.Text = random.Next(10).ToString();
                    OptionBTN1.Text = random.Next(10).ToString();
                    OptionBTN2.Text = random.Next(10).ToString();
                    break;
                case 3:
                    OptionBTN4.Text = correctAnswer.ToString();
                    OptionBTN1.Text = random.Next(10).ToString();
                    OptionBTN2.Text = random.Next(10).ToString();
                    OptionBTN3.Text = random.Next(10).ToString();
                    break;
            }
        }
    }
}
