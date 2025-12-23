using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dylan Burnham
// Simple class to represent the state of a board square. Includes the pressed state, flagged state, and value of the tile

namespace MineSweeper
{
    
    internal class BoardSquare
    {
        public int Value { get; set; }
        public bool Pressed { get; set; }
        public bool Flagged { get; set; }

        // Default constructor to initialize the board square class
        public BoardSquare()
        {
            Value = 0;
            Pressed = false;
            Flagged = false;
        }
    }
}
