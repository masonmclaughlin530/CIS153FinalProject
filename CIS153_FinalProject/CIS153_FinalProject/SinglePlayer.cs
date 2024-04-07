using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class SinglePlayer : Form
    {
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
    }
}
