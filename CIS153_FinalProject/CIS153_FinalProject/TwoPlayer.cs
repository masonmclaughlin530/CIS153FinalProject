using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            lbl_turnIndicator.Text = "Player 1's Turn";
            lbl_turnIndicator.ForeColor = Color.Green;
        }

        private void setupBoard()
        {
            foreach (var btn in this.Controls.OfType<Button>())
            {
                int r = int.Parse(btn.Text.ElementAt(0).ToString());
                int c = int.Parse(btn.Text.ElementAt(1).ToString());

                cell = new Cell(r, c, btn);
                
                board.setBoardCell(cell);
            }
        }

        private void checkIfGameOver()
        {
            bool gameOver = false;
            //vertical winsates=========================================================
            for (int c = 0; c < 7; c++)// checks for every colloum
            {
                for (int o = 0; o < 3; o++)// checks for every offset row position
                {

                    if (board.GetCell(5 - o, c).isP1Taken() && board.GetCell(4 - o, c).isP1Taken() && board.GetCell(3 - o, c).isP1Taken() && board.GetCell(2 - o, c).isP1Taken())
                    {
                        Console.WriteLine("GameOver Player one wins");
                        p1Wins();
                        gameOver = true;
                    }
                    if (board.GetCell(5 - o, c).isP2Taken() && board.GetCell(4 - o, c).isP2Taken() && board.GetCell(3 - o, c).isP2Taken() && board.GetCell(2 - o, c).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player Two wins");
                        p2Wins();
                        gameOver = true;
                    }
                }
            }
            //horizontal winstates=======================================================
            for (int r = 0; r < 6; r++)// checks for every row
            {
                for (int o = 0; o < 4; o++)// checks for every offset coloum position
                {
                    if (board.GetCell(r, 0 + o).isP1Taken() && board.GetCell(r, 1 + o).isP1Taken() && board.GetCell(r, 2 + o).isP1Taken() && board.GetCell(r, 3 + o).isP1Taken())
                    {
                        Console.WriteLine("GameOver Player one wins");
                        p1Wins();
                        gameOver = true;
                    }
                    if (board.GetCell(r, 0 + o).isP2Taken() && board.GetCell(r, 1 + o).isP2Taken() && board.GetCell(r, 2 + o).isP2Taken() && board.GetCell(r, 3 + o).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player two wins");
                        p2Wins();
                        gameOver = true;
                    }
                }
                
            }
            //slanted winstates=====================================================
            for (int r = 0; r < 3; r++)//row offsets
            {
                for (int c = 0; c < 4; c++)//coloum offsets
                {
                    if (board.GetCell(5 - r, 0 + c).isP1Taken() && board.GetCell(4 - r, 1 + c).isP1Taken() && board.GetCell(3 - r, 2 + c).isP1Taken() && board.GetCell(2 - r, 3 + c).isP1Taken())
                    {
                        Console.WriteLine("GameOver Player one wins");
                        p1Wins();
                        gameOver = true;
                    }
                    if (board.GetCell(5 - r, 0 + c).isP2Taken() && board.GetCell(4 - r, 1 + c).isP2Taken() && board.GetCell(3 - r, 2 + c).isP2Taken() && board.GetCell(2 - r, 3 + c).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player two wins");
                        p2Wins();
                        gameOver = true;
                    }
                    if (board.GetCell(2 - r, 0 + c).isP1Taken() && board.GetCell(3 - r, 1 + c).isP1Taken() && board.GetCell(4 - r, 2 + c).isP1Taken() && board.GetCell(5 - r, 3 + c).isP1Taken())
                    {
                        Console.WriteLine("GameOver Player one wins");
                        p1Wins();
                        gameOver = true;
                    }
                    if (board.GetCell(2 - r, 0 + c).isP2Taken() && board.GetCell(3 - r, 1 + c).isP2Taken() && board.GetCell(4 - r, 2 + c).isP2Taken() && board.GetCell(5 - r, 3 + c).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player two wins");
                        p2Wins();
                        gameOver = true;
                    }
                }
            }

            bool allCellsTaken = true;
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (!board.GetCell(r, c).isTaken())
                    {
                        allCellsTaken = false;
                        break;
                    }
                }
                if (!allCellsTaken) break;
            }

            if (allCellsTaken)
            {
                Console.WriteLine("The game is a draw.");
                Tie();
                gameOver = true;
            }
            if (gameOver)
            {
                disableBoard();
                lbl_turnIndicator.Text = "Game Over";
                lbl_turnIndicator.ForeColor = Color.Black;
            }

        }
        private void On_btn_Click(object sender, MouseEventArgs e)
        {
            
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
                    lbl_turnIndicator.Text = "Player 2's Turn";
                    lbl_turnIndicator.ForeColor = Color.Red;
                    p1Move = false;
                }
                
                if (targetrow  > 0)
                {
                    board.GetCell(targetrow - 1, c).getBtn().BackColor = Color.Blue;
                }

                checkIfGameOver();
            }
            else//player twos turn
            {
                Button btn = sender as Button;
                int r = int.Parse(btn.Text.ElementAt(0).ToString());
                int c = int.Parse(btn.Text.ElementAt(1).ToString());

                int targetrow = 5;
                while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }
                
                if (!board.GetCell(targetrow, c).isTaken())
                {
                    board.GetCell(targetrow, c).setP2taken();
                    board.GetCell(targetrow, c).getBtn().BackColor = Color.Red;
                    lbl_turnIndicator.Text = "Player 1's Turn";
                    lbl_turnIndicator.ForeColor = Color.Green;
                    p1Move = true;
                }
                if (targetrow  > 0)
                {
                    board.GetCell(targetrow - 1, c).getBtn().BackColor = Color.Blue;
                }
                checkIfGameOver();

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
            

            if (!board.GetCell(targetrow, c).isTaken()) 
            board.GetCell(targetrow, c).getBtn().BackColor = Color.Gray;
        

        }

        private void TwoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connect4.Close();
        }

        private void p1Wins()
        {
            bool askAgain = true;
            while (askAgain == true)
            {
                var result = MessageBox.Show("Want to leave?", "Player 1 Won!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    askAgain = false;
                    connect4.Show();
                    this.Hide();
                    return;
                }
                //Task.Delay(10000);
                Thread.Sleep(3000);
            }
        }

        private void p2Wins()
        {
            bool askAgain = true;
            while (askAgain == true)
            {
                var result = MessageBox.Show("Want to leave?", "Player 2 Won!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    askAgain = false;
                    connect4.Show();
                    this.Hide();
                    return;
                }
                //Task.Delay(10000);
                Thread.Sleep(3000);
            }
        }

        private void Tie()
        {
            bool askAgain = true;
            while (askAgain == true)
            {
                var result = MessageBox.Show("Want to leave?", "Nobody Wins!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    askAgain = false;
                    connect4.Show();
                    this.Hide();
                    return;
                }
                //Task.Delay(10000);
                Thread.Sleep(3000);
            }
        }

        private void disableBoard()
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Cell cell = board.GetCell(r, c);
                    if (cell != null)
                    {
                        Button btn = cell.getBtn();
                        if (btn != null)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}
