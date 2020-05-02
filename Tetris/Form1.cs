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

namespace ProjectTet {
public partial class Form1 : Form {
  Game game;
  Timer gameTimer;
  Graphics graphics;
  int size;

  public Form1() {
    InitializeComponent();
    scoreBox.Text = 0.ToString();
    levelBox.Text = 1.ToString();
    linesBox.Text = 0.ToString();
    game = new Game();
    graphics = gameBoard.CreateGraphics();
    size = 20;
  }

  private void DrawBoard() {
    //            Graphics graphics = gameBoard.CreateGraphics();
    //            int size = 20;

    for (int i = 0; i < 20; i++) {
      for (int k = 0; k < 10; k++) {
        if (game.Board[i, k] != 0)
          graphics.FillRectangle(new SolidBrush(Color.Red),
                                 new Rectangle(k * size, i * size, size, size));
        else
          graphics.FillRectangle(new SolidBrush(Color.White),
                                 new Rectangle(k * size, i * size, size, size));
        graphics.DrawRectangle(new Pen(Color.Gray),
                               new Rectangle(k * size, i * size, size, size));
      }
    }
    if (!game.gameCheckBottom())
      game.RemovePiece();
  }

  private void gameBoard_Click(object sender, EventArgs e) {}

  private void pictureBox1_Click(object sender, EventArgs e) {}

  private void nextBox_Click(object sender, EventArgs e) {}

  private void playButton_Click(object sender, EventArgs e) {
    playButton.Hide();
    InitTimer();
  }

  private void InitTimer() {
    gameTimer = new Timer();
    gameTimer.Tick += new EventHandler(gameTick);
    gameTimer.Interval = 1000 / game.Gamespeed;
    gameTimer.Start();
  }

  private void gameTick(object sender, EventArgs e) {
    DrawBoard();
    game.gameTick();
  }
}
}
