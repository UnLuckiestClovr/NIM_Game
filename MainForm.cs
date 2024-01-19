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
            OptionBTN1.Text = "BTN1 Clicked";
        }

        private void OptionBTN2_Click(object sender, EventArgs e)
        {
            OptionBTN2.Text = "BTN2 Clicked";
        }

        private void OptionBTN3_Click(object sender, EventArgs e)
        {
            OptionBTN3.Text = "BTN3 Clicked";
        }

        private void OptionBTN4_Click(object sender, EventArgs e)
        {
            OptionBTN4.Text = "BTN4 Clicked";
        }
    }
}
