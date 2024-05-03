using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CIS153_FinalProject
{
    public partial class SinglePlayer : Form
    {
        Board board;
        Cell cell;
        Connect4 connect4;
        Stats st;
        int numberOfMove;
        int column;
        SinglePlayer sp;
        bool playerCanPlay;
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
            playerCanPlay = true;

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
            bool gameOver = false;
            //vertical winsates=========================================================
            for (int c = 0; c < 7; c++)// checks for every colloum
            {
                for (int o = 0; o < 3; o++)// checks for every offset row position
                {

                    if (board.GetCell(5 - o, c).isP1Taken() && board.GetCell(4 - o, c).isP1Taken() && board.GetCell(3 - o, c).isP1Taken() && board.GetCell(2 - o, c).isP1Taken())
                    {
                        Console.WriteLine("GameOver Player one wins");

                        //This is where we will add to the stats p1 win
                        addP1Win();
                        gameOver = true;
                    }
                    if (board.GetCell(5 - o, c).isP2Taken() && board.GetCell(4 - o, c).isP2Taken() && board.GetCell(3 - o, c).isP2Taken() && board.GetCell(2 - o, c).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player Two wins");

                        //This is where we will add to the stats ai win
                        addAIWin();
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

                        //This is where we will add to the stats p1 win
                        addP1Win();
                        gameOver = true;
                    }
                    if (board.GetCell(r, 0 + o).isP2Taken() && board.GetCell(r, 1 + o).isP2Taken() && board.GetCell(r, 2 + o).isP2Taken() && board.GetCell(r, 3 + o).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player two wins");

                        //This is where we will add to the stats ai win
                        addAIWin();
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

                        //This is where we will add to the stats p1 win
                        addP1Win();
                        gameOver = true;
                    }
                    if (board.GetCell(5 - r, 0 + c).isP2Taken() && board.GetCell(4 - r, 1 + c).isP2Taken() && board.GetCell(3 - r, 2 + c).isP2Taken() && board.GetCell(2 - r, 3 + c).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player two wins");

                        //This is where we will add to the stats ai win
                        addAIWin();
                        gameOver = true;
                    }
                    if (board.GetCell(2 - r, 0 + c).isP1Taken() && board.GetCell(3 - r, 1 + c).isP1Taken() && board.GetCell(4 - r, 2 + c).isP1Taken() && board.GetCell(5 - r, 3 + c).isP1Taken())
                    {
                        Console.WriteLine("GameOver Player one wins");

                        //This is where we will add to the stats p1 win
                        addP1Win();
                        gameOver = true;
                    }
                    if (board.GetCell(2 - r, 0 + c).isP2Taken() && board.GetCell(3 - r, 1 + c).isP2Taken() && board.GetCell(4 - r, 2 + c).isP2Taken() && board.GetCell(5 - r, 3 + c).isP2Taken())
                    {
                        Console.WriteLine("GameOver Player two wins");

                        //This is where we will add to the stats ai win
                        addAIWin();
                        gameOver = true;
                    }
                }
            }
            // check for a draw =======================================================
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
                addTiePoint();
                gameOver = true;
            }
            if (gameOver)
            {
                disableBoard();
                lbl_TurnIndicator.Text = "Game Over";
                lbl_TurnIndicator.ForeColor = Color.Black;
                return "gameOver";
            }

            return null;
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
        private void SinglePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connect4.Close();
        }


        //form functions

        //if a button is clicked it is set as "p1Taken" and turns green
        private async void onButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());

            if (!playerCanPlay)
            {
                return;
            }

            int targetrow = 5;
            while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }
            if (!board.GetCell(targetrow, c).isTaken())
            {
                board.GetCell(targetrow, c).setP1taken();
                board.GetCell(targetrow, c).getBtn().BackColor = Color.Green;
                
            }

            if (targetrow > 0)
            {
                board.GetCell(targetrow - 1, c).getBtn().BackColor = Color.Blue;
            }


            if (numberOfMove == 0)
            {
                column = c;
            }
            checkIfGameOver();
            lbl_TurnIndicator.Text = "Computer's Turn";
            lbl_TurnIndicator.ForeColor = Color.Red;
            //needed a delay because the AI was moving too fast to show label change
            //tried using a timer but couldn't get it right, tried thread sleep and it just made it feel laggy
            //this still seems to get stuck sometimes on computers turn so may need adjusting or if someone can figure out a better method
            playerCanPlay = false;
            await Task.Delay(1000);

            if (checkIfGameOver() != "gameOver")
            {
                moveAI();
                checkIfGameOver();
            }
            
            
            //randomAIMove();
            playerCanPlay = true;
        }

        //highlights potential button as grey on mouse leave
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());
            int targetrow = 5;

            while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }
            //Console.WriteLine(targetrow);

            if (!board.GetCell(targetrow, c).isTaken())
                board.GetCell(targetrow, c).getBtn().BackColor = Color.Gray;



        }

        //highlights potential button as blue on mouse enter
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int r = int.Parse(btn.Text.ElementAt(0).ToString());
            int c = int.Parse(btn.Text.ElementAt(1).ToString());
            int targetrow = 5;


            while (board.GetCell(targetrow, c).isTaken() && targetrow > 0) { targetrow--; }

            if (!board.GetCell(targetrow, c).isTaken())
                board.GetCell(targetrow, c).getBtn().BackColor = Color.Blue;
        }
        //========================================================================================
        //AI blocking logic - if you don't like this or have a better solution feel free to change
        //========================================================================================

        //Vertical Block
        private bool tryVerticalBlock()
        {
            //for (int col = 0; col < 7; col++)
            //{
            //    for (int row = 0; row < 3; row++)
            //    {
            //        int p1Count = 0;
            //        for (int i = row; i < row + 4; i++)
            //        {
            //            if (board.GetCell(i, col).isP1Taken()) p1Count++;
            //        }
            //        if (p1Count == 3 && board.GetCell(row + 3, col).isTaken() == false)
            //        {
            //            board.GetCell(row + 3, col).setP2taken();
            //            board.GetCell(row + 3, col).getBtn().BackColor = Color.Red;
            //            return true;
            //        }
            //    }
            //}
            //return false;


            //vertical block did not work whene I tested it so I switched it to this
            
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (board.GetCell(row, col).isP1Taken())
                    {
                        if (blockVerticalCheck(row, col))
                        {
                            if (row - 1 < 0)
                            {
                                return false;
                            }
                            if (!board.GetCell(row - 1, col).isTaken() && row != 0)
                            { 
                                board.GetCell(row - 1, col).setP2taken();
                                board.GetCell(row - 1, col).getBtn().BackColor = Color.Red;
                                return true;
                            }
                        }
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
                        if (board.GetCell(row, i).isP1Taken())
                        {
                            p1Count++;
                        }
                    }
                    if (p1Count == 3)
                    {
                        for (int i = col; i < col + 4; i++)
                        {
                            if (!board.GetCell(row, i).isTaken())
                            {
                                //this should work everytime probably needs a little more testing
                                //before this change it would just place even if there was no piece below
                                //now will only place if there is a piece below it
                                if(row == 5)
                                {
                                    board.GetCell(row, i).setP2taken();
                                    board.GetCell(row,i).getBtn().BackColor = Color.Red;
                                    return true;
                                }
                                else if (!board.GetCell(row + 1, i).isTaken())
                                {
                                    return false;
                                }

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
            //Descending still will place a piece in the air, ascending seems to have stopped (at least it did not during my testing)
            // I think an out of bounds check needs to be added but I'm not sure
            // Ascending diagonal check
            for (int row = 3; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p1Count = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (board.GetCell(row - i, col + i).isP1Taken())
                        { 
                            p1Count++;                          

                        }
                    }
                    if (p1Count == 3)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            //this is also checking the spot below the cell so that it doesn't just place it in the air
                            //if (!board.GetCell(row - i, col + i).isTaken())
                            //{
                               // if (!board.GetCell(row - (i - 1), col + i).isTaken())
                               // {
                               //     Console.WriteLine("ascending block false");
                               //     return false;
                               // }
                               // else
                               if (!board.GetCell(row - i, col + i).isTaken() &&
                                  (row - i == 5 || board.GetCell(row - i + 1, col + i).isTaken()))
                                {
                                    Console.WriteLine("ascending block true");
                                    board.GetCell(row - i, col + i).setP2taken();
                                    board.GetCell(row - i, col + i).getBtn().BackColor = Color.Red;
                                    return true;
                                }
                            }
                        }
                    }
                }
            
            // More testing needed
            // Descending diagonal block
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p1Count = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (board.GetCell(row + i, col + i).isP1Taken())
                        {
                            p1Count++;
                        }
                    }
                    if (p1Count == 3)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            //ensuring support directly under the block position or it's the bottom row
                            //preventing floating - needs some testing - hoping this will work for the floating pieces
                            if (!board.GetCell(row + i, col + i).isTaken() &&
                                (row + i == 5 || board.GetCell(row + i + 1, col + i).isTaken()))
                            {
                                board.GetCell(row + i, col + i).setP2taken();
                                board.GetCell(row + i, col + i).getBtn().BackColor = Color.Red;
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
            
            if (!verticalWin() && !horizontalWin() && !diagonalWin() && !tryVerticalBlock() && !tryHorizontalBlock() && !tryDiagonalBlock())
            {
                bool moveMade = false;
                int attempts = 0;
                Random rnd = new Random();

                while (!moveMade && attempts < 7)
                {
                    int c = rnd.Next(0, 7);
                    int targetRow = 5;

                    // Find the lowest available row in the selected column
                    while (targetRow >= 0 && board.GetCell(targetRow, c).isTaken())
                    {
                        targetRow--;
                    }

                    // Check if an available cell was found in the column
                    if (targetRow >= 0)
                    {
                        board.GetCell(targetRow, c).setP2taken();
                        board.GetCell(targetRow, c).getBtn().BackColor = Color.Red;
                        moveMade = true;
                    }
                    //for (int targetRow = 5; targetRow >= 0; targetRow--)
                    //{
                    //    if (!board.GetCell(targetRow, c).isTaken())
                    //    {
                    //        board.GetCell(targetRow, c).setP2taken();
                    //        board.GetCell(targetRow, c).getBtn().BackColor = Color.Red;
                    //        moveMade = true;
                    //        break;
                    //    }
                    //}
                    attempts++;
                }
                if (moveMade)
                {
                    lbl_TurnIndicator.Text = "Player 1's Turn";
                    lbl_TurnIndicator.ForeColor = Color.Green;
                }
                    numberOfMove++;
            }
        }

        private bool verticalWin()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (board.GetCell(row, col).isP2Taken())
                    {
                        if (winVerticalCheck(row, col))
                        {
                            if (row > 0 && !board.GetCell(row - 1, col).isTaken())
                            {
                                board.GetCell(row - 1, col).setP2taken();
                                board.GetCell(row - 1, col).getBtn().BackColor = Color.Red;
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool horizontalWin()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p2Count = 0;
                    for (int i = col; i < col + 4; i++)
                    {
                        if (board.GetCell(row, i).isP2Taken())
                        {
                            p2Count++;
                        }
                    }
                    if (p2Count == 3)
                    {
                        for (int i = col; i < col + 4; i++)
                        {
                            if (!board.GetCell(row, i).isTaken())
                            {
                                if (row == 5)
                                {
                                    board.GetCell(row, i).setP2taken();
                                    board.GetCell(row, i).getBtn().BackColor = Color.Red;
                                    return true;
                                }
                                else if (!board.GetCell(row + 1, i).isTaken())
                                {
                                    return false;
                                }

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
        //Added a diagonalWin, I know you said you were working on it but thought i'd try to help
        //Feel free to delete or change with your own, not sure if it's right
        //I changed this so that it was placing a piece for the AI rather than checking for a win as that was my original intention
        //I'm going to leave the code because it could be used to check for a win
        private bool diagonalWin()
        {
            // Check ascending diagonals (bottom-left to top-right)
            //for (int row = 3; row < 6; row++)
            //{
            //    for (int col = 0; col < 4; col++)
            //    {
            //        if (board.GetCell(row, col).isP2Taken() &&
            //            board.GetCell(row - 1, col + 1).isP2Taken() &&
            //            board.GetCell(row - 2, col + 2).isP2Taken() &&
            //            board.GetCell(row - 3, col + 3).isP2Taken())
            //        {
            //            return true;
            //        }
            //    }
            //}

            //for (int row = 3; row < 6; row++)
            //{
            //    for (int col = 0;col < 4; col++)
            //    {
            //        if(board.GetCell(row,col).isP2Taken() &&  
            //           board.GetCell(row - 1,col + 1).isP2Taken() &&  
            //           board.GetCell(row - 2,col + 2).isP2Taken() )
            //        {
            //            if (row != 5 && col != 0)
            //            {
            //                if (row == 4)
            //                {
            //                    if (!board.GetCell(row + 1, col - 1).isTaken())
            //                    {
            //                        board.GetCell(row + 1, col - 1).setP2taken();
            //                        board.GetCell(row + 1, col - 1).getBtn().BackColor = Color.Red;
            //                        return true;
            //                    }
            //                }
            //                else if (!board.GetCell(row+1, col-1).isTaken() && board.GetCell(row + 2, col-1).isTaken())
            //                {
            //                    board.GetCell(row + 1, col - 1).setP2taken();
            //                    board.GetCell(row + 1, col - 1).getBtn().BackColor = Color.Red;
            //                    return true;
            //                }
            //            }
            //            else if (!board.GetCell(row - 3,col + 3).isTaken() && board.GetCell(row-2,col+3).isTaken())
            //            {
            //                board.GetCell(row - 3, col + 3).setP2taken();
            //                board.GetCell(row - 3, col + 3).getBtn().BackColor = Color.Red;
            //                return true;
            //            }
            //        }
            //    }
            //}

            for (int row = 3; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p2Count = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (board.GetCell(row - i, col + i).isP2Taken())
                        {
                            p2Count++;

                        }
                    }
                    if (p2Count == 3)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!board.GetCell(row - i, col + i).isTaken() &&
                               (row - i == 5 || board.GetCell(row - i + 1, col + i).isTaken()))
                            {
                                Console.WriteLine("Diagonal Win Check");
                                board.GetCell(row - i, col + i).setP2taken();
                                board.GetCell(row - i, col + i).getBtn().BackColor = Color.Red;
                                return true;
                            }
                        }
                    }
                }
            }

            // Check descending diagonals (top-left to bottom-right)
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int p2Count = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (board.GetCell(row + i, col + i).isP2Taken())
                        {
                            p2Count++;
                        }
                    }
                    if (p2Count == 3)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!board.GetCell(row + i, col + i).isTaken() &&
                                (row + i == 5 || board.GetCell(row + i + 1, col + i).isTaken()))
                            {
                                board.GetCell(row + i, col + i).setP2taken();
                                board.GetCell(row + i, col + i).getBtn().BackColor = Color.Red;
                                return true;

                            }
                        }
                    }
                }
            }

            return false; // No diagonal wins found
        }

        private bool blockVerticalCheck(int row, int col)
        {
            if(board.GetCell(row+1, col).isP1Taken() && board.GetCell(row+2,col).isP1Taken()) 
            {
                return true;
            }
            return false;
        }

        private bool winVerticalCheck(int row, int col)
        {
            if (board.GetCell(row + 1, col).isP2Taken() && board.GetCell(row + 2, col).isP2Taken())
            {
                return true;
            }
            return false;
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {

        }

        public void addP1Win()
        {
            int p1;
            int ai;
            int tie;
            string file = "../../Resources/statInfo.txt";
            using (TextReader reader = File.OpenText(file))
            {
                p1 = int.Parse(reader.ReadLine());
                ai = int.Parse(reader.ReadLine());
                tie = int.Parse(reader.ReadLine());

                p1++;
            }

            System.IO.File.WriteAllText(file, string.Empty);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(p1.ToString());
                writer.WriteLine(ai.ToString());
                writer.WriteLine(tie.ToString());
            }

            bool askAgain = true;
            while (askAgain == true)
            {
                var result = MessageBox.Show("Want to leave?", "You Won!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    askAgain = false;
                    connect4.Show();
                    this.Hide();
                    return;
                }
                //Task.Delay(10000);
                Thread.Sleep(1000);
            }
        }

        public void addAIWin()
        {
            int p1;
            int ai;
            int tie;
            string file = "../../Resources/statInfo.txt";
            using (TextReader reader = File.OpenText(file))
            {
                p1 = int.Parse(reader.ReadLine());
                ai = int.Parse(reader.ReadLine());
                tie = int.Parse(reader.ReadLine());

                ai++;
            }

            System.IO.File.WriteAllText(file, string.Empty);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(p1.ToString());
                writer.WriteLine(ai.ToString());
                writer.WriteLine(tie.ToString());
            }

            bool askAgain = true;
            while (askAgain == true)
            {
                var result = MessageBox.Show("Want to leave?", "You Lost!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    askAgain = false;
                    connect4.Show();
                    this.Hide();
                    return;
                }
                //Task.Delay(10000);
                Thread.Sleep(1000);
            }
        }

        public async void addTiePoint()
        {
            int p1;
            int ai;
            int tie;
            string file = "../../Resources/statInfo.txt";
            using (TextReader reader = File.OpenText(file))
            {
                p1 = int.Parse(reader.ReadLine());
                ai = int.Parse(reader.ReadLine());
                tie = int.Parse(reader.ReadLine());

                tie++;
            }

            System.IO.File.WriteAllText(file, string.Empty);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(p1.ToString());
                writer.WriteLine(ai.ToString());
                writer.WriteLine(tie.ToString());
            }

            bool askAgain = true;
            while (askAgain == true)
            {
                var result = MessageBox.Show("Want to leave?", "It's a Tie!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    askAgain = false;
                    connect4.Show();
                    this.Hide();
                    return;
                }
                await Task.Delay(4500);
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




    
