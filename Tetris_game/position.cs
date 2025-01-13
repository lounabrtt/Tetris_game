using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_game
{
    internal class position
    {

        public int Row { get; set; }

        public int Column { get; set; }


        public position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
