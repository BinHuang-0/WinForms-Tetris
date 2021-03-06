﻿using System;
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
            gameBoard.KeyDown += new KeyEventHandler(GameBoard_KeyPress);
        }

        private void DrawBoard() {
        //            Graphics graphics = gameBoard.CreateGraphics();
        //            int size = 20;

            for (int i = 0; i < 20; i++) {
                for (int k = 0; k < 10; k++) {
                    switch(game.Board[i,k] % 8) {
                        case 0:
                            graphics.FillRectangle(new SolidBrush(Color.White),
                                     new Rectangle(k * size, i * size, size, size));
                            break;
                        case 1:
                            graphics.FillRectangle(new SolidBrush(Color.Aquamarine),
                                     new Rectangle(k * size, i * size, size, size));
                            break;
                        case 2:
                            graphics.FillRectangle(new SolidBrush(Color.Gold),
                                     new Rectangle(k * size, i * size, size, size));
                            break;
                        case 3:
                            graphics.FillRectangle(new SolidBrush(Color.DarkMagenta),
                                     new Rectangle(k * size, i * size, size, size));
                            break;
                        case 4:
                            graphics.FillRectangle(new SolidBrush(Color.Crimson),
                                     new Rectangle(k * size, i * size, size, size));
                            break;
                        case 5:
                            graphics.FillRectangle(new SolidBrush(Color.LimeGreen),
                                     new Rectangle(k * size, i * size, size, size));
                            break;
                        case 6:
                            graphics.FillRectangle(new SolidBrush(Color.Blue),
                                     new Rectangle(k * size, i * size, size, size)); ;
                            break;
                        case 7:
                            graphics.FillRectangle(new SolidBrush(Color.Orange),
                                     new Rectangle(k * size, i * size, size, size)); ;
                            break;
                    }
            graphics.DrawRectangle(new Pen(Color.Gray),
                                   new Rectangle(k * size, i * size, size, size));
                }
            }
    //    if (!game.gameCheckBottom())
    //      game.RemovePiece();
        }

        private void gameBoard_Click(object sender, EventArgs e) {}

        private void pictureBox1_Click(object sender, EventArgs e) {}

        private void nextBox_Click(object sender, EventArgs e) {}

        private void playButton_Click(object sender, EventArgs e) {
            playButton.Hide();
            InitTimer();
            gameBoard.Select();
            GameOverLabel.Hide();
            game = new Game();
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
            scoreBox.Text = game.Score.ToString();
            linesBox.Text = game.Lines.ToString();
            if(game.IsOver) {
                gameTimer.Stop();
                playButton.Show();
                GameOverLabel.Show();
            }
        }

        private void GameBoard_KeyPress(object sender, KeyEventArgs e) {
            game.ButtonPress(sender, e);
            gameTick(sender, e);
        }
    }
}
