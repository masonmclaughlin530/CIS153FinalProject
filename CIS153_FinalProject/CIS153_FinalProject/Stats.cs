using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class Stats : Form
    {
        Connect4 connect4;
        Stats st;
        public Stats()
        {
            InitializeComponent();
        }

        public Stats(Connect4 c4)
        {
            InitializeComponent();
            readFile();
            connect4 = c4;
        }

        private void p1Wins_lbl_Click(object sender, EventArgs e)
        {

        }
        public void readFile()
        {
            int[] scores = new int[3];

            //Will have to add a file to the gitHub to make sure that it can be used
            using (TextReader reader = File.OpenText("../../Resources/statInfo.txt"))
            {
            int p1 = int.Parse(reader.ReadLine());
            int ai = int.Parse(reader.ReadLine());
            int tie = int.Parse(reader.ReadLine());
                scores[0] = p1;
                scores[1] = ai;
                scores[2] = tie;
            }
            double total;
            total = scores[0] + scores[1] + scores[2];

            p1WinNum_lbl.Text = scores[0].ToString();
            p1WinPercentNum_lbl.Text = ((scores[0] / total) * 100).ToString("0.00") + "%";
            aiWinNum_lbl.Text = scores[1].ToString();
            aiWinPercentNum_lbl.Text = ((scores[1] / total) * 100).ToString("0.00") + "%";
            tiesNum_lbl.Text = scores[2].ToString();
            tiePercent_lbl.Text = ((scores[2] / total) * 100).ToString("0.00") + "%";


            //Console.WriteLine(total);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Connect4 c4 = new Connect4();
            c4.Show();
            this.Hide();
        }

        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connect4.Close();
        }
    }
}
