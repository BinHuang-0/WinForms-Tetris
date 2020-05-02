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
  public virtual int[, ] Shape { get; }
  public virtual int XPosition {
    get;
    set;
  }
  public virtual int YPosition {
    get;
    set;
  }
  public virtual int PieceValue { get; set; }

  // check bottom
  public abstract bool IsBottom(int[, ] board);
  // check wall
  public abstract bool CheckWall(int pos);
  // rotate
  public abstract void RotateRight();
  public abstract void RotateLeft();
  // move left and right
  public void MoveLeft() { XPosition++; }
  public void MoveRight() { XPosition--; }

  // move down
  public void MoveDown() { YPosition++; }

  // put piece onto board
  public void WritePiece(int[, ] board) {
    for (int i = 0; i < 4; i++) {
      for (int k = 0; k < 4; k++) {
        if (YPosition + i < 20 && board[YPosition + i, XPosition + k] == 0 && Shape[i,k] != 0) {
          board[YPosition + i, XPosition + k] = PieceValue;
        }
      }
    }
  }

  public void RemovePiece(int[, ] board) {
    for (int i = 0; i < 4; i++) {
      for (int k = 0; k < 4; k++) {
        if (YPosition + i < 20 &&
            board[YPosition + i, XPosition + k] == PieceValue) {
          board[YPosition + i, XPosition + k] = 0;
        }
      }
    }
  }
}
}
