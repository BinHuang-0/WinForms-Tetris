using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTet
{
    class Game
    {
        //(y,x)
        private int[,] _Board;

        public int[,] Board { get; }
        public Game()
        {
            _Board = new int[20, 10];
            IPiece piece = new IPiece();
            for(int i = 0; i < 4; i++)
            {
                for(int k = 0; k < 4; k++)
                {
                    //_Board[i + piece.YPosition, k + piece.XPosition] = piece.Shape[i, k] * 2;
                }
            }
        }

    }
}
