using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTet
{
    class JPiece : Piece
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
                switch(RotationValue) {
                    case 1:
                        if(value >= 0 && value < 9)
                            _XPosition = value;
                        break;
                    case 2:
                        if (value >= 0 && value < 8)
                            _XPosition = value;
                        break;
                    case 3:
                        if (value >= 0 && value < 9)
                            _XPosition = value;
                        break;
                    case 4:
                        if (value >= 0 && value < 8)
                            _XPosition = value;
                        break;
                }
            }
        }

        public override int YPosition { 
            get {
                return _YPosition;
            }
            set {
                switch(RotationValue) {
                    case 1:
                        if (value >= 0 && value < 18)
                            _YPosition = value;
                        break;
                    case 2:
                        if (value >= 0 && value < 19)
                            _YPosition = value;
                        break;
                    case 3:
                        if (value >= 0 && value < 18)
                            _YPosition = value;
                        break;
                    case 4:
                        if (value >= 0 && value < 19)
                            _YPosition = value;
                        break;
                }
            }
        }

        public JPiece() {
            // set inital rotation state
            RotationValue = 2;
            _ChangeRotation();
            // set position to middle
            _XPosition = 3;
            _YPosition = 1;
            PieceValue = 7;
        }

        public override bool CheckWall(int direction, int[,] board)
        {
            if(direction == 0) {
                switch(RotationValue) {
                    case 1:
                        if (XPosition == 0 || board[YPosition, XPosition] != 0 || board[YPosition + 1, XPosition] != 0 || board[YPosition + 2, XPosition -1] != 0)
                            return false;
                        break;
                    case 2:
                        if (XPosition == 0 || board[YPosition, XPosition - 1] != 0 || board[YPosition + 1, XPosition - 1] != 0)
                            return false;
                        break;
                    case 3:
                        if (XPosition == 0 || board[YPosition, XPosition - 1] != 0 || board[YPosition + 1, XPosition - 1] != 0 || board[YPosition + 2, XPosition - 1] != 0)
                            return false;
                        break;
                    case 4:
                        if (XPosition == 0 || board[YPosition, XPosition - 1] != 0 || board[YPosition + 1, XPosition + 1] != 0)
                            return false;
                        break;
                }           
            }
            else {
                switch(RotationValue) {
                    case 1:
                        if (XPosition == 8 || board[YPosition, XPosition + 2] != 0 || board[YPosition + 1, XPosition + 2] != 0 || board[YPosition + 2, XPosition + 2] != 0)
                            return false;
                        break;
                    case 2:
                        if(XPosition == 7 || board[YPosition, XPosition + 1] != 0 || board[YPosition + 1, XPosition + 3] != 0)
                            return false;
                        break;
                    case 3:
                        if (XPosition == 8 || board[YPosition, XPosition + 2] != 0 || board[YPosition + 1, XPosition + 1] != 0 || board[YPosition + 2, XPosition + 1] != 0)
                            return false;
                        break;
                    case 4:
                        if(XPosition == 7 || board[YPosition, XPosition + 3] != 0 || board[YPosition + 1, XPosition + 3] != 0)
                            return false;
                        break;
                }           
            }
            return true;
        }

        public override bool IsBottom(int[,] board)
        {
            if (RotationValue == 1 && YPosition == 17)
                return true;
            if (RotationValue == 2 && YPosition == 18)
                return true;
            if (RotationValue == 3 && YPosition == 17)
                return true;
            if (RotationValue == 4 && YPosition == 18)
                return true;

            switch(RotationValue) {
                case 1:
                    if (board[YPosition + 3, XPosition] != 0 || board[YPosition + 3, XPosition + 1] != 0)
                        return true;
                    break;
                case 2:
                    if (board[YPosition + 2, XPosition] != 0 || board[YPosition + 2, XPosition + 1] != 0 || board[YPosition + 2, XPosition + 2] != 0)
                        return true;
                    break;
                case 3:
                    if (board[YPosition + 3, XPosition] != 0 || board[YPosition + 1, XPosition + 1] != 0)
                        return true;
                    break;
                case 4:
                    if (board[YPosition + 1, XPosition] != 0 || board[YPosition + 1, XPosition + 1] != 0 || board[YPosition + 2, XPosition + 2] != 0)
                        return true;
                    break;
            }
            return false;
        }

        public override void RotateLeft()
        {
            //make sure to handle changing at the edges
            if(RotationValue == 1) {
                RotationValue = 4;
            }
            else {
                RotationValue--;
            }
            _ChangeRotation();
        }

        public override void RotateRight()
        {
            //make sure to handle changing at the edges
            if(RotationValue == 4) {
                RotationValue = 1;
            }
            else {
                RotationValue++;
            }
            _ChangeRotation();
        }

        private void _ChangeRotation() {
            switch(RotationValue) {
                case 1:
                    _Shape =
                        new int[, ]{{0, 1, 0, 0}, {0, 1, 0, 0}, {1, 1, 0, 0}, {0, 0, 0, 0}};
                    break;
                case 2:
                    _Shape =
                        new int[, ]{{1, 0, 0, 0}, {1, 1, 1, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}};
                    break;
                case 3:
                    _Shape =
                        new int[, ]{{1, 1, 0, 0}, {1, 0, 0, 0}, {1, 0, 0, 0}, {0, 0, 0, 0}};
                    break;
                case 4:
                    _Shape =
                        new int[, ]{{1, 1, 1, 0}, {0, 0, 1, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}};
                    break;
            }
        }
    }
}
