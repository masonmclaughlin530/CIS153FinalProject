using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//=============================================================================================
// Andrew Taylor
//
//
//
//=============================================================================================

namespace CIS153_FinalProject
{
    public partial class Connect4 : Form
    {
        Connect4 c4;
        LoadingForm load;
        public Connect4()
        {
            InitializeComponent();
        }
        public Connect4(LoadingForm l)
        {
            InitializeComponent();
            load = l;
            //this.BackgroundImage = Image.FromFile("movin.gif");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void single_btn_Click(object sender, EventArgs e)
        {
            //Open a form that play against an AI
            openSinglePlayer();
        }

        private void twoPlayer_btn_Click(object sender, EventArgs e)
        {
            //Open a different form that pits player against player
            openTwoPlayer(); 
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            //Go to a statistics form
            Stats st = new Stats(this);
            st.StartPosition = FormStartPosition.Manual;
            st.Location = this.Location;
            st.Show();
            this.Hide();
        }

        public void openTwoPlayer()
        {
            TwoPlayer tp = new TwoPlayer(this);
            tp.StartPosition = FormStartPosition.Manual;
            tp.Location = this.Location;
            tp.Show();
            this.Hide();
        }

        public void openSinglePlayer()
        {
            SinglePlayer sp = new SinglePlayer(this);
            sp.StartPosition = FormStartPosition.Manual;
            sp.Location = this.Location;
            sp.Show();
            this.Hide();
        }

        private void Connect4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.load.Close();
            this.load = null;
        }
    }
}
