using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTet
{
    class IPiece : Piece
    {
        private int[,] _Shape;
        private int _XPosition;
        private int _YPosition;

        public override int[,] Shape {
            get {
                return _Shape;
            }
        }
        public override int XPosition {
            get {
                return _XPosition;
            }
            set {
                if (value >= 0 && value < 10)
                    _XPosition = value;
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

        public override int PieceValue {
            get {
                return 1;
            }
        }
        public IPiece()
        {
            //set inital rotation state
            _Shape = new int[,] {   {0,0,0,0},
                                    {0,0,0,0},
                                    {1,1,1,1},
                                    {0,0,0,0} };
            //set position to middle
            _XPosition = 3;
            _YPosition = 0;
        }

        public override bool IsBottom(int[,] board)
        {
            if (_YPosition == 19)
                return true;
            for(int i = 0; i < 4; i++)
            {
                if (board[_YPosition + 1, (_XPosition - 2) + i] != 0)
                    return true;
            }
            return false;
        }

        public override bool CheckWall(int pos)
        {
            throw new NotImplementedException();
        }

        //see if i can just rotate the array
        public override void RotateRight()
        {
            throw new NotImplementedException();
        }

        public override void RotateLeft()
        {
            throw new NotImplementedException();
        }
    }
}
