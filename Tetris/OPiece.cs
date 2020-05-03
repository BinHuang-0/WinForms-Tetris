using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTet
{
    class OPiece : Piece
    {
        private int[, ] _Shape;
        private int _XPosition;
        private int _YPosition;

        public override int[, ] Shape {
            get { return _Shape; }
        }

        public override int XPosition {
            get {
                return _XPosition;
            }
            set {
                if(value >= 0 && value <= 8) {
                    _XPosition = value;
                }
            }
        }      

        public override int YPosition {
            get {
                return _YPosition;
            }
            set {
                if (value >= 0 && value < 20) {
                    _YPosition = value;
                }
            }
        }

        public OPiece() {
            // set inital rotation state
            RotationValue = 1;
            _Shape =
                new int[, ]{{1, 1, 0, 0}, {1, 1, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}};
            // set position to middle
            _XPosition = 4;
            _YPosition = 1;
            PieceValue = 2;
        }

        public override bool CheckWall(int direction, int[,] board)
        {
            if (direction == 0)
            {
                if (XPosition == 0 || board[YPosition, XPosition - 1] != 0 || board[YPosition + 1, XPosition - 1] != 0)
                    return false;
            }
            else {
                if (XPosition == 8 || board[YPosition, XPosition + 2] != 0 || board[YPosition + 1, XPosition + 2] != 0)
                    return false;
            }
            return true;
        }

        public override bool IsBottom(int[,] board)
        {
            if (YPosition == 18)
                return true;
            if (board[YPosition + 1, XPosition] != 0 || board[YPosition + 1, XPosition + 1] != 0)
                return true;
            return false;
        }

        public override void RotateLeft()
        {
        }

        public override void RotateRight()
        {
        }
    }
}
