using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            scoreBox.Text = 0.ToString();
            levelBox.Text = 1.ToString();
            linesBox.Text = 0.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void draw()
        {
            Graphics graphics = gameBoard.CreateGraphics();

            graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(100,100,2,2));
        }

        private void gameBoard_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
