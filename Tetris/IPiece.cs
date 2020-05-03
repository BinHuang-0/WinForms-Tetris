using System;
using System.Collections.Generic;
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
    get { return _Shape; }
  }
  public override int XPosition {
    get { return _XPosition; }
    set {
        // use private function CheckWall to check if x is allowed
      if (value >= 0 && value < 7)
        _XPosition = value;
    }
  }

  public override int YPosition {
    get { return _YPosition; }
    set {
      if (value >= 0 && value < 20)
        _YPosition = value;
    }
  }

  public override int PieceValue { get; set; }
  public IPiece() {
    // set inital rotation state
    _Shape =
        new int[, ]{{0, 0, 0, 0}, {0, 0, 0, 0}, {1, 1, 1, 1}, {0, 0, 0, 0}};
    // set position to middle
    _XPosition = 3;
    _YPosition = 0;
      PieceValue = 1;
  }

  public override bool IsBottom(int[, ] board) {
    if (_YPosition == 17)
      return true;
    for(int i = 0; i < 4; i++)
    {
        if (board[_YPosition + 3, _XPosition + i] != 0)
            return true;
    }
    return false;
  }

        public override bool CheckWall(int direction, int[,] board) {
            //left
            if (direction == 0) {
                //horizontal
                if(XPosition == 0 || board[YPosition, XPosition - 1] != 0) {
                    return false;
                }
                //vertical
            }
            //right
            else{
                //horizontal
                if(XPosition == 6 || board[YPosition, XPosition + 4] != 0) {
                    return false;
                }
                //vertical
            }
            return true;
        }

  // see if i can just rotate the array
  public override void RotateRight() { throw new NotImplementedException(); }

  public override void RotateLeft() { throw new NotImplementedException(); }
}
}
