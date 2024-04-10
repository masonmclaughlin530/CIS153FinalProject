using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class SinglePlayer : Form
    {
        Board board;
        Cell cell;
        Connect4 connect4;
        int numberOfMove;
        int column;
        public SinglePlayer()
        {
            numberOfMove = 0;
            InitializeComponent();

        }

        public SinglePlayer(Connect4 c4)
        {
            InitializeComponent();
            connect4 = c4;
            board = new Board();
            setupBoard();

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

        private void randomAIMove()
        {
            Random rnd = new Random();
            int c = rnd.Next(0, 6);
            int targetrow = 5;
            while (board.GetCell(targetrow, c).isTaken()) { targetrow--; }

            if (board.GetCell(targetrow, c).isTaken())
            {
                randomAIMove();
            }
            else
            {
                board.GetCell(targetrow, c).setP2taken();
                board.GetCell(targetrow, c).getBtn().BackColor = Color.Red;
            }
        }

        private string checkIfGameOver()
        {
            int horP1Pieaces = 0;
            int horP2Pieaces = 0;
            //checks for vertical winning states
            for (int i = 0; i < 7; i++)
                if (board.GetCell(5, i).isP1Taken() && board.GetCell(4, i).isP1Taken() && board.GetCell(3, i).isP1Taken() && board.GetCell(2, i).isP1Taken())
                {
                    Console.WriteLine("GameOver");
                    return null;
                }
            //return null;

            for (int i = 0; i < 6; i++)
            {
                horP1Pieaces = 0;
                horP2Pieaces = 0;
                for (int ii = 0; ii < 7; ii++)
                {
                    if (board.GetCell(i, ii).isP1Taken())
                    {
                        horP1Pieaces++;
                    }
                    if (board.GetCell(i, ii).isP2Taken())
                    {
                        horP2Pieaces++;
                    }

                    if (horP1Pieaces == 4)
                    {
                        Console.WriteLine("Player One Wins");
                    }
                    if (horP2Pieaces == 4)
                    {
                        Console.WriteLine("The Computer Wins");
                    }
                }
            }
            return null;
        }

        private void SinglePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connect4.Close();
        }


        //form functions

        //if a button is clicked it is set as "p1Taken" and turns green
        private void onButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());

            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());

            int targetrow = 5;
            while (board.GetCell(targetrow, c).isTaken()) { targetrow--; }

            board.GetCell(targetrow, c).setP1taken();
            board.GetCell(targetrow, c).getBtn().BackColor = Color.Green;
            board.GetCell(targetrow - 1, c).getBtn().BackColor = Color.Blue;


            if (numberOfMove == 0)
            {
                column = c;
            }



            moveAI();
            checkIfGameOver();
            //randomAIMove();
        }

        //highlights potential button as grey on mouse leave
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());
            int targetrow = 5;

            while (board.GetCell(targetrow, c).isTaken()) { targetrow--; }

            board.GetCell(targetrow, c).getBtn().BackColor = Color.Gray;



        }

        //highlights potential button as blue on mouse enter
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());
            int targetrow = 5;


            while (board.GetCell(targetrow, c).isTaken()) { targetrow--; }

            Console.WriteLine(targetrow);

            board.GetCell(targetrow, c).getBtn().BackColor = Color.Blue;
        }
        //========================================================================================
        //AI blocking logic - if you don't like this or have a better solution feel free to change
        //========================================================================================

        //Vertical Block
        private bool tryVerticalBlock()
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    int p1Count = 0;
                    for (int i = row; i < row + 4; i++)
                    {
                        if (board.GetCell(i, col).isP1Taken()) p1Count++;
                    }
                    if (p1Count == 3 && board.GetCell(row + 3, col).isTaken() == false)
                    {
                        board.GetCell(row + 3, col).setP2taken();
                        board.GetCell(row + 3, col).getBtn().BackColor = Color.Red;
                        return true;
                    }
                }
            }
            return false;
        }
        //Horizontal Block
        private bool tryHorizontalBlock()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p1Count = 0;
                    for (int i = col; i < col + 4; i++)
                    {
                        if (board.GetCell(row, i).isP1Taken()) p1Count++;
                    }
                    if (p1Count == 3)
                    {
                        for (int i = col; i < col + 4; i++)
                        {
                            if (!board.GetCell(row, i).isTaken())
                            {
                                board.GetCell(row, i).setP2taken();
                                board.GetCell(row, i).getBtn().BackColor = Color.Red;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        //Ascending diagonal block
        private bool tryDiagonalBlock()
        {
            // Ascending diagonal check
            for (int row = 3; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p1Count = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (board.GetCell(row - i, col + i).isP1Taken()) p1Count++;
                    }
                    if (p1Count == 3)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!board.GetCell(row - i, col + i).isTaken())
                            {
                                board.GetCell(row - i, col + i).setP2taken();
                                board.GetCell(row - i, col + i).getBtn().BackColor = Color.Red;
                                return true;
                            }
                        }
                    }
                }
            }

            // Descending diagonal block
            for (int row = 3; row < 6; row++)
            {
                for (int col = 3; col < 7; col++)
                {
                    int p1Count = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (board.GetCell(row - i, col - i).isP1Taken()) p1Count++;
                    }
                    if (p1Count == 3)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!board.GetCell(row - i, col - i).isTaken())
                            {
                                board.GetCell(row - i, col - i).setP2taken();
                                board.GetCell(row - i, col - i).getBtn().BackColor = Color.Red;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        //Also, if you figure out a better solution for this feel free to change.
        //couldn't figure out how to get my blocking methods to work with the other moveAI
        //Instead of deleting it I just commented it out if you still wanted to try to implement the blocking methods with the previous moveAI method
        private void moveAI()
        {
            if (!tryVerticalBlock() && !tryHorizontalBlock() && !tryDiagonalBlock())
            {
                bool moveMade = false;
                int attempts = 0;
                Random rnd = new Random();

                while (!moveMade && attempts < 7)
                {
                    int c = rnd.Next(0, 7);
                    for (int targetRow = 5; targetRow >= 0; targetRow--)
                    {
                        if (!board.GetCell(targetRow, c).isTaken())
                        {
                            board.GetCell(targetRow, c).setP2taken();
                            board.GetCell(targetRow, c).getBtn().BackColor = Color.Red;
                            moveMade = true;
                            break;
                        }
                    }
                    attempts++;
                }

                numberOfMove++;
            }
        }
    }
}
        //if (!tryVerticalBlock() && !tryHorizontalBlock() && !tryDiagonalBlock())
        //{
        //    int c;
        //    int targetrow;
        //    int p1Pieces = 0;
        //    int p2Pieces = 0;
        //    bool endTurn = false;
        //    while (!endTurn)
        //    {

        //        if (numberOfMove == 0)
        //        {
        //            c = 6 - column;

        //            if (column == 3)
        //            {
        //                Random rnd = new Random();
        //                c = column + rnd.Next(-1, 1);
        //            }
        //            targetrow = 5;
        //            while (board.GetCell(targetrow, c).isTaken()) { targetrow--; }

        //            if (board.GetCell(targetrow, c).isTaken())
        //            {
        //                randomAIMove();
        //            }
        //            else
        //            {
        //                board.GetCell(targetrow, c).setP2taken();
        //                board.GetCell(targetrow, c).getBtn().BackColor = Color.Red;
        //            }

        //            column = c;
        //            numberOfMove++;
        //            endTurn = true;
        //        }
        //        else if (numberOfMove == 1)
        //        {
        //            Random rnd = new Random();
        //            c = column + rnd.Next(-1, 1);
        //            targetrow = 5;
        //            while (board.GetCell(targetrow, c).isTaken()) { targetrow--; }

        //            if (board.GetCell(targetrow, c).isTaken())
        //            {
        //                randomAIMove();
        //            }
        //            else
        //            {
        //                board.GetCell(targetrow, c).setP2taken();
        //                board.GetCell(targetrow, c).getBtn().BackColor = Color.Red;
        //            }

        //            numberOfMove++;
        //            endTurn = true;
        //        }
        //        else
        //        {
        //            for (int i = 0; i < 6; i++)
        //            {
        //                p1Pieces = 0;
        //                p2Pieces = 0;
        //                for (int ii = 0; ii < 7; ii++)
        //                {
        //                    if (board.GetCell(i, ii).isP1Taken())
        //                    {
        //                        p1Pieces++;
        //                    }

        //                    if (board.GetCell(i, ii).isP2Taken())
        //                    {
        //                        p2Pieces++;
        //                    }

        //                    if (p2Pieces == 3)
        //                    {
        //                        if (ii == 6)
        //                        {
        //                            board.GetCell(i, ii - 2).setP2taken();
        //                        }
        //                        else
        //                        {
        //                            board.GetCell(i, ii + 1).setP2taken();
        //                        }
        //                    }


        //                }
        //            }
        //            endTurn = true;
        //        }
        //    }
        //}


    
