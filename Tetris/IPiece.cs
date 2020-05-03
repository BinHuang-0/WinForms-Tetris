using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTet {
class IPiece : Piece {
    private int[, ] _Shape;
    private int _XPosition;
    private int _YPosition;

    public override int[, ] Shape {
        get {
            return _Shape;
        }
    }
    public override int XPosition {
        get {
            return _XPosition;
        }
        set {
            if (RotationValue == 1)
            {
                if (value >= 0 && value < 7)
                    _XPosition = value;
            }
            else {
                if (value >= 0 && value < 10)
                    _XPosition = value;
            }
        }
    }

    public override int YPosition {
        get {
            return _YPosition;
        }
        set {
            if (value >= 0 && value < 20)
                _YPosition = value;
        }
    }

    public IPiece() {
        // set inital rotation state
        RotationValue = 1;
        _Shape =
        new int[, ] {{0, 0, 0, 0}, {0, 0, 0, 0}, {1, 1, 1, 1}, {0, 0, 0, 0}};
        // set position to middle
        _XPosition = 3;
        _YPosition = 0;
        PieceValue = 1;
    }

    public override bool IsBottom(int[,] board) {
        if (RotationValue == 1) {
            //horizontal
            if (_YPosition == 17)
                return true;
            for (int i = 0; i < 4; i++)
            {
                if(board[YPosition + 3, XPosition + i] != 0)
                    return true;
            }
            return false;
        }
        else {
            //vertical
            if (_YPosition == 16)
                return true;
            if(board[YPosition + 4, XPosition] != 0)
                return true;
            return false;
        }
    }

    public override bool CheckWall(int direction, int[,] board) {
        //left
        if (direction == 0) {
            if (RotationValue == 1)
            {
                //horizontal
                if (XPosition == 0 || board[YPosition, XPosition - 1] != 0)
                {
                    return false;
                }
            }
            else {
                //vertical
                if (XPosition == 0 || board[YPosition, XPosition - 1] != 0)
                {
                    return false;
                }
            }
        }
        //right
        else {
            if (RotationValue == 1)
            {
                //horizontal
                if (XPosition == 6 || board[YPosition, XPosition + 4] != 0)
                {
                    return false;
                }
            }
            else {
                //vertical
                for (int i = 0; i < 4; i++)
                {
                    if (XPosition == 9 || board[YPosition + i, XPosition + 1] != 0)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    // see if i can just rotate the array
    public override void RotateRight() {
        Rotate();
    }

    public override void RotateLeft() {
        Rotate();
    }

    private void Rotate() {
        //check if rotate is legal
        RotationValue = RotationValue == 1 ? 2 : 1;
        //change to horizontal
        if(RotationValue == 1) {
            _Shape =
            new int[, ] {{0, 0, 0, 0}, {0, 0, 0, 0}, {1, 1, 1, 1}, {0, 0, 0, 0}};
            while (XPosition > 6)
                MoveLeft();
        }
        //change to vertical
        else {
            _Shape =
            new int[,] { { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 } };
            MoveRight();
        }
    }
}
}
