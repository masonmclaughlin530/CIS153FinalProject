using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class TwoPlayer : Form
    {
        Board board;
        Connect4 connect4;
        Cell cell;
        bool p1Move;
        public TwoPlayer(Connect4 c4)
        {
            InitializeComponent();
            board = new Board();
            connect4 = c4;
            setupBoard();
            p1Move = true;
        }

        private void setupBoard()
        {
            foreach (var btn in this.Controls.OfType<Button>())
            {
                int r = int.Parse(btn.Text.ElementAt(0).ToString());
                int c = int.Parse(btn.Text.ElementAt(1).ToString());

                cell = new Cell(r, c, btn);
                //Console.WriteLine(cell.getRow() + "," + cell.getCol());
                board.setBoardCell(cell);
            }
        }

        private void On_btn_Click(object sender, MouseEventArgs e)
        {
            Console.WriteLine(sender.ToString());
            // if it is player ones turn
            if (p1Move)
            {
                Button btn = sender as Button;
                int r = int.Parse(btn.Text.ElementAt(0).ToString());
                int c = int.Parse(btn.Text.ElementAt(1).ToString());

                int targetrow = 5;
                while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }
                if (!board.GetCell(targetrow, c).isTaken())
                {
                    board.GetCell(targetrow, c).setP1taken();
                    board.GetCell(targetrow, c).getBtn().BackColor = Color.Green;
                    p1Move = false;
                }
                
                if (targetrow  > 0)
                {
                    board.GetCell(targetrow - 1, c).getBtn().BackColor = Color.Blue;
                }

                
            }
            else
            {
                Button btn = sender as Button;
                int r = int.Parse(btn.Text.ElementAt(0).ToString());
                int c = int.Parse(btn.Text.ElementAt(1).ToString());

                int targetrow = 5;
                while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }
                Console.WriteLine(targetrow);
                if (!board.GetCell(targetrow, c).isTaken())
                {
                    board.GetCell(targetrow, c).setP2taken();
                    board.GetCell(targetrow, c).getBtn().BackColor = Color.Red;
                    p1Move = true;
                }
                if (targetrow  > 0)
                {
                    board.GetCell(targetrow - 1, c).getBtn().BackColor = Color.Blue;
                }
               
            }

            
            //randomAIMove();
        }

        private void On_Btn_Enter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());
            int targetrow = 5;

            
            while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }          

            if (!board.GetCell(targetrow, c).isTaken())
                board.GetCell(targetrow, c).getBtn().BackColor = Color.Blue;
            
        }

        private void On_Btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());
            int targetrow = 5;
            
            while (board.GetCell(targetrow, c).isTaken() && targetrow > 0 ) { targetrow--; }
            Console.WriteLine(targetrow);

            if (!board.GetCell(targetrow, c).isTaken()) 
            board.GetCell(targetrow, c).getBtn().BackColor = Color.Gray;
        

        }
    }
}
