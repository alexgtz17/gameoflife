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

        public void checkNeighbors()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    int count = 0;
                    int left = mod((row - 1), 10);
                    int right = mod((row + 1), 10);
                    int bottom = mod((col - 1), 10);
                    int top = mod((col + 1), 10);

                    if (this.actualStatusGrid[left, top].status) // left top corner
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[row, top].status) // top
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[right, top].status) // top right corner
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[right, col].status) // right
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[right, bottom].status) // right bottom corner
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[row, bottom].status) // bottom
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[left, bottom].status) // left buttom corner
                    {
                        count++;
                    }
                    if (this.actualStatusGrid[left, col].status) // left
                    {
                        count++;
                    }
                    this.actualStatusGrid[row, col].neighbors = count;
                }
            }
        }

        int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

    }
}
