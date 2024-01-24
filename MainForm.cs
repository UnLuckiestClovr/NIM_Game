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
    }
}
