using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTet {
    class Game {
        //(y,x)
        private int[, ] _Board;
        private int _Gamespeed;
        private int _Score;
        private Piece _curPiece;
        private int _Lines;
        private Random _Random;

        public int[, ] Board {
            get { return _Board; }
        }
        public int Gamespeed {
            get { return _Gamespeed; }
            set { _Gamespeed = value; }
        }

        public int Score {
            get {
                return _Score;
            }
        }
        public int Lines {
            get{
                return _Lines;
            }
        }
        public bool IsOver{ get; set; }

        public Game() {
            _Random = new Random();
            _Board = new int[20, 10];
            _Gamespeed = 20;
            _NewPiece();
        }

        public void gameTick() {
            _curPiece.RemovePiece(_Board);
            if (!_curPiece.IsBottom(_Board)) {
                _curPiece.MoveDown();
                _curPiece.WritePiece(Board);
            } else {
                _curPiece.PieceValue -= 8;
                _curPiece.WritePiece(Board);
                _LineClear();
                this.IsOver = _IsLose();
                this._NewPiece();
            }
        }

        private bool _IsLose() {
            for(int i = 0; i < 10; i++) {
                if (Board[2, i] != 0)
                    return true;
            }
            return false;
        }

        private void _LineClear() {
            bool clear;
            for(int i = 0; i < 20; i++) {
                clear = true;
                for(int k = 0; k < 10; k++) {
                    if (Board[i, k] == 0)
                        clear = false;
                }
                if(clear) {
                    //add score
                    _Score += 10 * _Gamespeed;
                    _Lines++;
                    //move everything down
                    for(int j = i; j > 0; j--) {
                        for(int k = 0; k < 10; k++) {
                            Board[j, k] = Board[j - 1, k];
                        }
                    }
                    for(int k = 0; k < 10; k++) {
                        Board[0, k] = 0;
                    }
                }
            }
        }

        private void _NewPiece()
        {
            switch(_Random.Next(1,8)) {
                case 1:
                    _curPiece = new IPiece();
                    break;
                case 2:
                    _curPiece = new OPiece();
                    break;
                case 3:
                    _curPiece = new TPiece();
                    break;
                case 4:
                    _curPiece = new ZPiece();
                    break;
                case 5:
                    _curPiece = new SPiece();
                    break;
                case 6:
                    _curPiece = new LPiece();
                    break;
                case 7:
                    _curPiece = new JPiece();
                    break;
            }
            _curPiece.PieceValue += 8;
        }

//  public void RemovePiece() { _curPiece.RemovePiece(_Board); }
//
//  public bool gameCheckBottom() { return _curPiece.IsBottom(_Board); }

        private void printBoard() {
            for(int i = 0; i < 20; i++) {
                for(int k = 0; k < 10; k++) {
                    Debug.Write(Board[i, k]);
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("");
        }

        public void ButtonPress(object sender, KeyEventArgs e) {
            switch(e.KeyData) {
                case Keys.A:
                    if(_curPiece.CheckWall(0,Board))
                        _curPiece.MoveLeft();
                    break;
                case Keys.D:
                    if(_curPiece.CheckWall(1,Board))
                        _curPiece.MoveRight();
                    break;
                case Keys.S:
                    _curPiece.MoveDown();
                    break;
                case Keys.Left:
                    _curPiece.RotateLeft();
                    break;
                case Keys.Right:
                    _curPiece.RotateRight();
                    break;
            }
        }
    }
}
