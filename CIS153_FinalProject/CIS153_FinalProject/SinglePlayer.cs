using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class SinglePlayer : Form
    {
        Board board ;
        Cell cell;
        Connect4 connect4;
        public SinglePlayer()
        {
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

        private void SinglePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connect4.Close();
        }

        

        private void onButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            //If a button is clicked it turns green
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
            board.GetCell(int.Parse(btn.Text.ElementAt(0).ToString()), int.Parse(btn.Text.ElementAt(1).ToString())).setP1taken();
            
        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            //Console.WriteLine(sender.ToString());
        }
    }
}
