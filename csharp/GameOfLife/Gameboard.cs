using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Gameboard
    {
        public Cell[,] actualStatusGrid { set; get; }

        public Gameboard()
        {
            actualStatusGrid = new Cell[10,10];

            for (int rows = 0; rows < 10; rows++)
            {
                for (int cols = 0; cols < 10; cols++)
                {
                    actualStatusGrid[rows, cols] = new Cell();
                }
            }
        }
    }
}
