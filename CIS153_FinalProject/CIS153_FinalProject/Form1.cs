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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            loadedPanel.Width += 43;

            if (loadedPanel.Width > 903)
            {
                loadingTimer.Stop();
                loadGame();
            }
        }

        public void loadGame()
        {
            Connect4 connect4 = new Connect4(this);
            connect4.Show();
            this.Hide();
        }
    }
}
