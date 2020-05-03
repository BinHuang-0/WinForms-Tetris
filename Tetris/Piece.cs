using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTet {
public abstract class Piece {
    public virtual int[, ] Shape {
        get;
    }

    private int _XPosition;
    public virtual int XPosition {
        get {
            return _XPosition;
        }
        set {
            if (value >= 0 && value < 10)
                _XPosition = value;
        }
    }

    private int _YPosition;

    public virtual int YPosition {
        get {
            return _YPosition;
        }
        set {
            if (value >= 0 && value < 20)
                _XPosition = value;
        }
    }
    public virtual int PieceValue {
        get;
        set;
    }
    public virtual int RotationValue {
        get;
        set;
    }

    // check bottom
    public abstract bool IsBottom(int[, ] board);
    // check wall
    // 0 = left 1 = right
    public abstract bool CheckWall(int direction, int [,] board);
    // rotate
    public abstract void RotateRight();
    public abstract void RotateLeft();
    // move left and right
    public void MoveLeft() {
        XPosition--;
    }
    public void MoveRight() {
        XPosition++;
    }

    // move down
    public void MoveDown() {
        YPosition++;
    }

    // put piece onto board
    public void WritePiece(int[, ] board) {
        for (int i = 0; i < 4; i++) {
            for (int k = 0; k < 4; k++) {
                if (YPosition + i < 20 && XPosition + k < 10 && board[YPosition + i, XPosition + k] == 0 && Shape[i,k] != 0) {
                    board[YPosition + i, XPosition + k] = PieceValue;
                }
            }
        }
    }

    public void RemovePiece(int[, ] board) {
        for (int i = 0; i < 20; i++) {
            for (int k = 0; k < 10; k++) {
                if (board[i, k] == PieceValue) {
                    board[i, k] = 0;
                }
            }
        }
    }
}
}
