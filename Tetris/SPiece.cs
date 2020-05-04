using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTet
{
    class SPiece : Piece
    {
        private int[,] _Shape;
        private int _XPosition;
        private int _YPosition;

        public override int[,] Shape {
            get{
                return _Shape;
            }
        }

        public override int XPosition { 
            get {
                return _XPosition;
            }
            set {
                if(RotationValue % 2 == 1) {
                    if (value >= 0 && value < 8)
                        _XPosition = value;
                }
                else {
                    if (value >= 0 && value < 9)
                        _XPosition = value;
                }
            }
        }

        public override int YPosition {
            get {
                return _YPosition;
            }
            set {
                if (RotationValue % 2 == 1)
                {
                    if (value >= 0 && value < 19)
                    {
                        _YPosition = value;
                    }
                }
                else {
                    if(value >= 0 && value < 18) {
                        _YPosition = value;
                    }
                }
            }
        }

        public SPiece() {
            // set inital rotation state
            RotationValue = 1;
            _Shape =
                new int[, ]{{0, 1, 1, 0}, {1, 1, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}};
            // set position to middle
            _XPosition = 3;
            _YPosition = 1;
            PieceValue = 5;
        }

        public override bool CheckWall(int direction, int[,] board)
        {
            if(direction == 0) {
                switch(RotationValue) {
                    case 1:
                        if (XPosition == 0 || board[YPosition, XPosition] != 0 || board[YPosition + 1, XPosition - 1] != 0)
                            return false;
                        break;
                    case 2:
                        if (XPosition == 0 || board[YPosition, XPosition - 1] != 0 || board[YPosition + 1, XPosition - 1] != 0|| board[YPosition + 2, XPosition] != 0)
                            return false;
                        break;
                }
            }
            else {
                switch(RotationValue) {
                    case 1:
                        if (XPosition == 7 || board[YPosition, XPosition + 3] != 0 || board[YPosition + 1, XPosition + 2] != 0)
                            return false;
                        break;
                    case 2:
                        if (XPosition == 8 || board[YPosition, XPosition + 1] != 0 || board[YPosition + 1, XPosition + 2] != 0|| board[YPosition + 2, XPosition + 2] != 0)
                            return false;
                        break;
                }
            }
            return true;
        }

        public override bool IsBottom(int[,] board)
        {
            if (RotationValue == 1 && YPosition == 18)
                return true;
            if (RotationValue == 2 && YPosition == 17)
                return true;

            switch(RotationValue) {
                case 1:
                    if (board[YPosition + 2, XPosition] != 0 || board[YPosition + 2, XPosition + 1] != 0 || board[YPosition + 1, XPosition + 2] != 0)
                        return true;
                    break;
                case 2:
                    if (board[YPosition + 2, XPosition] != 0 || board[YPosition + 3, XPosition + 1] != 0)
                        return true;
                    break;
            }
            return false;
        }

        public override void RotateLeft()
        {
            Rotate();
        }
        public override void RotateRight()
        {
            Rotate();
        }

        private void Rotate() {
            RotationValue = RotationValue == 1 ? 2 : 1;         

            if(RotationValue == 1) {
                _Shape =
                    new int[, ]{{0, 1, 1, 0}, {1, 1, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}};
            }
            else {
                _Shape =
                    new int[, ]{{1, 0, 0, 0}, {1, 1, 0, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}};
            }
        }
    }
}
