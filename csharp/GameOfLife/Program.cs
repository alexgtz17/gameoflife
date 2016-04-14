using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameboard = new Gameboard();
            gameboard.actualStatusGrid[5, 5].status = true;
            gameboard.actualStatusGrid[6, 5].status = true;
            gameboard.actualStatusGrid[7, 5].status = true;
            gameboard.actualStatusGrid[7, 4].status = true;
            gameboard.actualStatusGrid[6, 3].status = true;

            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.WriteLine(gameboard.convertGridToString());
                gameboard.checkNeighbors();
                Thread.Sleep(500);
                gameboard.nextGen();
            }           

        }
    }
}
