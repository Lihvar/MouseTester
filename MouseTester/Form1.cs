using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTester
{
    public partial class Form1 : Form
    {
        int leftClicks = 0;
        int middleClicks = 0;
        int rightClicks = 0;
        string lblText = "Clicks: ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLeftClick.Text = lblText + leftClicks.ToString();
            lblMiddleClick.Text = lblText + middleClicks.ToString();
            lblRightClick.Text = lblText + rightClicks.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    btnLeftClick.BackColor = Color.Green;
                    leftClicks += 1;
                    lblLeftClick.Text = lblText + leftClicks.ToString();
                    break;
                case MouseButtons.Middle:
                    btnMiddleClick.BackColor = Color.Green;
                    middleClicks += 1;
                    lblMiddleClick.Text = lblText + middleClicks.ToString();
                    break;
                case MouseButtons.Right:
                    btnRightClick.BackColor = Color.Green;
                    rightClicks += 1;
                    lblRightClick.Text = lblText + rightClicks.ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    btnLeftClick.BackColor = Color.Red;
                    break;
                case MouseButtons.Middle:
                    btnMiddleClick.BackColor = Color.Red;
                    break;
                case MouseButtons.Right:
                    btnRightClick.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            leftClicks = 0;
            middleClicks = 0;
            rightClicks = 0;
            lblLeftClick.Text = lblText + leftClicks.ToString();
            lblMiddleClick.Text = lblText + middleClicks.ToString();
            lblRightClick.Text = lblText + rightClicks.ToString();
        }
    }
}
