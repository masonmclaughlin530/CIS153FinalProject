using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public class Cell
    {
        private int row;
        private int col;
        Button btn;
        //for single player lets use player 1 as the human player and player 2 as the AI
        private bool player1Taken;
        private bool player2Taken;
        public Cell(int r, int c, Button b) 
        {
            row = r; 
            col = c;
            btn = b;
        }

        public int getRow() { return row; }
        public int getCol() { return col; }
        public Button getBtn() { return btn; }


    }
}
