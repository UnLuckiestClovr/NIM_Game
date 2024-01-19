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

        }

        private void OptionBTN1_Click(object sender, EventArgs e)
        {
            DialogueLabel.Text = "Clicked BTN1";
        }

        private void OptionBTN2_Click(object sender, EventArgs e)
        {
            DialogueLabel.Text = "Clicked BTN2";
        }

        private void OptionBTN3_Click(object sender, EventArgs e)
        {

            DialogueLabel.Text = "Clicked BTN3";
        }

        private void OptionBTN4_Click(object sender, EventArgs e)
        {
            DialogueLabel.Text = "Clicked BTN4";
        }
    }
}
