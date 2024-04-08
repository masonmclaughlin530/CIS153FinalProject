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
        private bool p1Taken;
        private bool p2Taken;
        public Cell(int r, int c, Button b) 
        {
            row = r; 
            col = c;
            btn = b;
        }
        //getters
        public int getRow() { return row; }
        public int getCol() { return col; }
        public Button getBtn() { return btn; }

        public bool isP1Taken() {  return p1Taken; }
        public bool isP2Taken() {  return p2Taken; }
        //setters
        public void setP1taken() { p1Taken = true; }
        public void setP2taken() {  p2Taken = true; }
    }
}
