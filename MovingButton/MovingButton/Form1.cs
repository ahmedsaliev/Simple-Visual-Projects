using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Rand = new Random();

        private void moveButtonTimer_Tick(object sender, EventArgs e)
        {
            clickMeButton.Left = Rand.Next(0, 250);
            clickMeButton.Top = Rand.Next(0, 250);
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            moveButtonTimer.Enabled = !moveButtonTimer.Enabled;
            clickMeButton.Text = "Catch Me!";
        }
    }
}
