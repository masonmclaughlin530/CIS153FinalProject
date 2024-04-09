using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    public class Board
    {

        Cell[,] gameboard = new Cell[6,7];

      

        public Cell GetCell(int r, int c)
        {
            return gameboard[r,c];
        }

        public void setBoardCell(Cell cell)
        {
            gameboard[cell.getRow(), cell.getCol()] = cell;
        }

        //returns the entire gameboard 
        public Cell[,] getGameBoard()
        {
            return gameboard;
        }
    }
}
