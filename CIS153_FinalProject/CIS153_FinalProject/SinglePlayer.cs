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
        Board board;
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
        }

        private void SinglePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connect4.Close();
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {

        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            //If a button is clicked it turns green
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
            
            //creates a new cell
            cell = new Cell(int.Parse(btn.Text.ElementAt(0).ToString()), int.Parse(btn.Text.ElementAt(1).ToString()), btn);
            
            //Adds the cell to the gameboard
            board.setBoardCell(cell);
        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
