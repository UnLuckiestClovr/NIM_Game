using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIM_Game
{
    public partial class MainForm : Form
    {
        int currentFloor = 2;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateMathProblem();
            changeScene(1);
        }

        private void OptionBTN1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Option 1 Pressed");

        }
        private void DialogueLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void OptionBTN2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Option 2 Pressed");
        }

        private void OptionBTN3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Option 3 Pressed");
        }

        private void OptionBTN4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Option 4 Pressed");
        }

        List<string> mainDialogue = new List<string>() {
        "You are in the basement. You have not studied with the coach on this floor yet",
        "You are in the neumont commons. You should study with the coaches on each floor or if you are feeling ready you can head to the fourth floor and take on the degree coach",
        "You are on the second floor. You have not studied with the coach on this floor yet",
        "You are on the third floor. You have not studied with the coach on this floor yet",
        "You are on the fourth floor and you haven't studied that much. Are you going to take on the degree chair?",
        };
        List<string> floorImages = new List<string>();
        List<bool> AlternateDialogeConditionMet = new List<bool>() { false, false, false, false, false };
        List<string> alternateDialogue = new List<string>() { "You are in the basement. You have already studied with the coach on this floor",
        "You are in the neumont commons. You are done studying and should be ready to take on the degree coach on the fourth floor",
        "You are on the second floor. You have already studied with the coach on this floor",
        "You are on the third floor. You have already studied with the coach on this floor",
        "You are on the fourth floor and have studied all you can. Are you going to take on the degree chair?"};
        List<List<string>> buttonOptions = new List<List<string>>() { new List<string>() { "Return to the commons", "Study with the coach" },
        new List<string>() { "Go to the basement", "Go to the second floor", "Go to the third floor","Go to the fourth floor" },
        new List<string>() { "Return to the commons", "Study with the coach", "",""},
        new List<string>() { "Return to the commons", "Study with the coach", "","" },
        new List<string>() { "Return to the commons", "Take on the degree chair", "","" }};


        private void changeScene(int floor) // 0 for basement 1 for first floor etc
        {

            // set background image
            if (floor == 1 && currentFloor != 1)
            {
                currentFloor = floor;
                OptionBTN1.Show();
                OptionBTN2.Show();
                OptionBTN3.Show();
                OptionBTN4.Show();
                OptionBTN1.Text = buttonOptions[floor][0];
                OptionBTN2.Text = buttonOptions[floor][1];
                OptionBTN3.Text = buttonOptions[floor][2];
                OptionBTN4.Text = buttonOptions[floor][3];
                if (!AlternateDialogeConditionMet[floor])
                {
                    DialogueLabel.Text = mainDialogue[floor];
                }
                else
                {
                    DialogueLabel.Text = alternateDialogue[floor];
                }
            }
            else
            {
                if (floor == 1)
                {
                    floor = 3;
                }
                else if (floor == 3)
                {
                    floor = 4;
                }

                currentFloor = floor;
                OptionBTN3.Hide();
                OptionBTN4.Hide();
                OptionBTN2.Show();
                OptionBTN1.Text = buttonOptions[floor][0];
                OptionBTN2.Text = buttonOptions[floor][1];
                if (AlternateDialogeConditionMet[floor] && floor != 4)
                {
                    OptionBTN2.Hide();
                }
                if (!AlternateDialogeConditionMet[floor])
                {
                    DialogueLabel.Text = mainDialogue[floor];
                }
                else
                {
                    DialogueLabel.Text = alternateDialogue[floor];
                }



            }


        }

        private void sendValue(int value)
        {
            Console.WriteLine("value sent:" + value);
            // if inMathPuzzle = false
            if (currentFloor == 1)
            {
                changeScene(value);
            }
            else if (value == 0)
            {
                changeScene(1);
            }
            else
            {
                // math game stuff
                //inMathPuzzle = true;
            }
        }

        private Random random = new Random();
        public void generateMathProblem()
        {
            int intOne = random.Next(10);
            int intTwo = random.Next(10);
            int mathType = random.Next(4);
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
                    break;
                case 3:
                    //division
                    DialogueLabel.Text = $"What is the answer to the math problem: {intOne} / {intTwo}";
                    float answerDivide = intOne / intTwo;
                    setCorrectAnswer(answerDivide);
                    break;
                default:
                    DialogueLabel.Text = "Something Is Broken In The Math Switch Statement";
                    break;
            }
        }
        
        public void setCorrectAnswer(float correctAnswer) { 
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
