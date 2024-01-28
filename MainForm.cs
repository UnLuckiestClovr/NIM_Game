using NIM_Game.Properties;
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
        string degree = "";

        bool isMathProblem = false;

        int correctAnswer = 5;

        bool inBossFight = false;

        int bossScore = 0;

        bool gameOver = false;

        bool gameWin = false;

        int score = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //generateMathProblem();
            //changeScene(1);
            setDegree();
            panel1.Hide();
            panel1.BackColor = Color.Transparent;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int newWidth = Convert.ToInt32(OptionsTopRow.Width * 0.48);

            OptionBTN1.Width = newWidth;
            OptionBTN2.Width = newWidth;
            OptionBTN3.Width = newWidth;
            OptionBTN4.Width = newWidth;

            Console.WriteLine($"Resize Ran: Size {newWidth}");
        }

        private void OptionBTN1_Click(object sender, EventArgs e)
        {
            if (inBossFight)
            {
                doBossMath(int.Parse(OptionBTN1.Text));
            }
            Console.WriteLine("Option 1 Pressed");
            if (!isMathProblem && degree != "" && !inBossFight)
            {
                sendValue(0);
            }
            else if (degree == "")
            {
                degree = "SE";
                changeScene(1);
            }
            else if (!inBossFight)
            {

                doMath(int.Parse(OptionBTN1.Text), currentFloor);
            }
        }
        private void DialogueLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void OptionBTN2_Click(object sender, EventArgs e)
        {
            if (inBossFight)
            {
                doBossMath(int.Parse(OptionBTN2.Text));
            }
            Console.WriteLine("Option 1 Pressed");
            if (!isMathProblem && degree != "" && !inBossFight)
            {
                sendValue(1);
            }
            else if (degree == "")
            {
                degree = "IS";
                changeScene(1);
            }
            else if (!inBossFight)
            {

                doMath(int.Parse(OptionBTN2.Text), currentFloor);
            }
        }
            

        private void OptionBTN3_Click(object sender, EventArgs e)
        {
            if (inBossFight)
            {
                doBossMath(int.Parse(OptionBTN3.Text));
            }
            Console.WriteLine("Option 1 Pressed");
            if (!isMathProblem && degree != "" && !inBossFight)
            {
                sendValue(2);
            }
            else if (degree == "")
            {
                degree = "GD";
                changeScene(1);
            }
            else if (!inBossFight)
            {

                doMath(int.Parse(OptionBTN3.Text), currentFloor);
            }
        }
            

        private void OptionBTN4_Click(object sender, EventArgs e)
        {
            if (inBossFight)
            {
                doBossMath(int.Parse(OptionBTN4.Text));
            }
            Console.WriteLine("Option 1 Pressed");
            if (!isMathProblem && degree != "" && !inBossFight)
            {
                sendValue(3);
            }
            else if (degree == "" && !isMathProblem)
            {
                degree = "CS";
                changeScene(1);
            }
            else if (!inBossFight)
            {
                doMath(int.Parse(OptionBTN4.Text), currentFloor);
            }
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

        List<Image> images = new List<Image>()
        {
            Resources.Bunker,
            Resources.commons,
            Resources.hallwaylvl2,
            Resources.Third,
            Resources.FourthDown

        };
        List<Image> degreeChairs = new List<Image>()
        {
            Resources.Bunker,
            Resources.commons,
            Resources.hallwaylvl2,
            Resources.Third,
            Resources.FourthDown

        };


        private void changeScene(int floor) // 0 for basement 1 for first floor etc
        {
            
            if (floor == 1 && currentFloor != 1)
            {
                this.BackgroundImage = images[floor];
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
                    floor = 2;
                }
                else if (floor == 2)
                {
                    floor = 3;
                }
                else if (floor == 3)
                {
                    floor = 4;
                }

                currentFloor = floor;
                this.BackgroundImage = images[floor];
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
                isMathProblem = true;
                OptionBTN1.Show();
                OptionBTN2.Show();
                OptionBTN3.Show();
                OptionBTN4.Show();
                if (currentFloor != 4) { 
                    generateMathProblem();
                }
                else
                {
                    doBossFight();
                }
            }
        }

        private void doBossFight()
        {
            panel1.Show();
            switch (degree) {
                case "SE":
                    panel1.BackgroundImage = Resources.AngyCantera;
                    break;
                case "GD":
                    panel1.BackgroundImage = Resources.AngyMaple;
                    break;
                case "IS":
                    panel1.BackgroundImage = Resources.AngyCoreyIS;
                    break;
                case "CS":
                    panel1.BackgroundImage = Resources.AngyPritchardCS;
                    break;
            }
            if (score < 3)
            {
                inBossFight = true;
                generateImpossibleMathProblem();
            } 
            else
            {
                inBossFight = true;
                generateMathProblem();
            } 
        }

        private void doMath(int buttonValue, int floor)
        {
            if (correctAnswer == buttonValue)
            {
                Console.WriteLine("Correct");
                score++;
                AlternateDialogeConditionMet[floor] = true;
                panel1.Hide();
                if (AlternateDialogeConditionMet[0] == true && AlternateDialogeConditionMet[2] == true && AlternateDialogeConditionMet[3] == true)
                {
                    AlternateDialogeConditionMet[1] = true;
                    AlternateDialogeConditionMet[4] = true;
                }
                currentFloor = 1;
                if (floor == 2)
                {
                    floor = 1;
                } 
                else if (floor == 3)
                {
                    floor = 2;
                }
                changeScene(floor);
                isMathProblem = false;
            } 
            else
            {
                panel1.Hide();
                Console.WriteLine("Incorrect");
                AlternateDialogeConditionMet[floor] = true;
                if (AlternateDialogeConditionMet[0] == true && AlternateDialogeConditionMet[2] == true && AlternateDialogeConditionMet[3] == true)
                {
                    AlternateDialogeConditionMet[1] = true;
                    AlternateDialogeConditionMet[4] = true;
                }
                currentFloor = 1;
                if (floor == 2)
                {
                    floor = 1;
                }
                else if (floor == 3)
                {
                    floor = 2;
                }
                changeScene(floor);
                isMathProblem = false;
            }
        }

        private void doBossMath(int buttonValue)
        {
            if (correctAnswer == buttonValue)
            {
                Console.WriteLine("Correct");
                bossScore++;
                if (bossScore < 3)
                {
                    generateMathProblem();
                } 
                else
                {
                    gameOver = true;
                    gameWin = true;
                    inBossFight = false;
                    panel1.Hide();
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
                gameOver = true;
                gameWin = false;
                inBossFight = false;
                panel1.Hide();
            }
        }

        private void setDegree()
        {
            DialogueLabel.Text = "Pick Your Degree";
            OptionBTN1.Text = "SE";
            OptionBTN2.Text = "IS";
            OptionBTN3.Text = "GD";
            OptionBTN4.Text = "CS";

        }

        private void generateImpossibleMathProblem()
        {
            int intOne = random.Next(10000);
            int intTwo = random.Next(10000);
            DialogueLabel.Text = $"What is the answer to the math problem: {intOne} +-*/ {intTwo}";
            correctAnswer = random.Next(10000);
            OptionBTN1.Text = random.Next(10000).ToString();
            OptionBTN2.Text = random.Next(10000).ToString();
            OptionBTN3.Text = random.Next(10000).ToString();
            OptionBTN4.Text = random.Next(10000).ToString();
        }

        private Random random = new Random();
        public void generateMathProblem()
        {
            if (!inBossFight)
            {
                panel1.Show();
                panel1.BackgroundImage = Resources.rat;
            }
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
                    setCorrectAnswer(answerSubtract);
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
        
        public void setCorrectAnswer(int correctAnswerIn) {
            correctAnswer = correctAnswerIn;
            int setButtons = random.Next(4);
            switch (setButtons)
            {
                case 0:
                    OptionBTN1.Text = correctAnswer.ToString();
                    OptionBTN2.Text = random.Next(20).ToString();
                    OptionBTN3.Text = random.Next(20).ToString();
                    OptionBTN4.Text = random.Next(20).ToString();
                    break;
                case 1:

                    OptionBTN2.Text = correctAnswer.ToString();
                    OptionBTN3.Text = random.Next(20).ToString();
                    OptionBTN4.Text = random.Next(20).ToString();
                    OptionBTN1.Text = random.Next(20).ToString();
                    break;
                case 2:

                    OptionBTN3.Text = correctAnswer.ToString();
                    OptionBTN4.Text = random.Next(20).ToString();
                    OptionBTN1.Text = random.Next(20).ToString();
                    OptionBTN2.Text = random.Next(20).ToString();
                    break;
                case 3:

                    OptionBTN4.Text = correctAnswer.ToString();
                    OptionBTN1.Text = random.Next(20).ToString();
                    OptionBTN2.Text = random.Next(20).ToString();
                    OptionBTN3.Text = random.Next(20).ToString();
                    break;
            }
        }
    }
}
