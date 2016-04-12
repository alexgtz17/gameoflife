using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public bool status { get; set; }

        public Cell()
        {
            status = false;
        }
    }
}
