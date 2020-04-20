using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTet
{
    public abstract class Piece
    {
        public int[,] Shape { get; }
        public virtual int XPosition { get; set; }
        public virtual int YPosition { get; set; }
        public virtual int PieceValue { get; } 

        //check bottom
        public abstract bool IsBottom(bool[,] board);
        //check wall
        public abstract bool CheckWall(int pos);
        //rotate
        public abstract void RotateRight();
        public abstract void RotateLeft();
    }
}
