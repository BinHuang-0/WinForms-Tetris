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
    private Piece _curPiece;

    public int[, ] Board {
        get {
            return _Board;
        }
    }
    public int Gamespeed {
        get {
            return _Gamespeed;
        }
        set {
            _Gamespeed = value;
        }
    }
    public Game() {
        _Board = new int[20, 10];
        _Gamespeed = 100;
        _NewPiece();
    }

    public void gameTick() {
        _curPiece.RemovePiece(_Board);
//    _curPiece.WritePiece(Board);
        if (!_curPiece.IsBottom(_Board)) {
            _curPiece.MoveDown();
            _curPiece.WritePiece(Board);
        } else {
            _curPiece.PieceValue -= 7;
            _curPiece.WritePiece(Board);
//        printBoard();
            this._NewPiece();
        }

    }

    private void _NewPiece()
    {
        _curPiece = new IPiece();
        _curPiece.PieceValue += 7;
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
        case Keys.Left:
            if(_curPiece.CheckWall(0,Board))
                _curPiece.MoveLeft();
            break;
        case Keys.Right:
            if(_curPiece.CheckWall(1,Board))
                _curPiece.MoveRight();
            break;
        case Keys.Down:
            _curPiece.MoveDown();
            break;
        }
    }
}
}
