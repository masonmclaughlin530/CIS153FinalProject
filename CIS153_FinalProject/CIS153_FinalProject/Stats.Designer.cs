namespace CIS153_FinalProject
{
    partial class Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameStats_lbl = new System.Windows.Forms.Label();
            this.p1Wins_lbl = new System.Windows.Forms.Label();
            this.p1WinPercent_lbl = new System.Windows.Forms.Label();
            this.aiWInPercent_lbl = new System.Windows.Forms.Label();
            this.aiWins_lbl = new System.Windows.Forms.Label();
            this.ties_lbl = new System.Windows.Forms.Label();
            this.p1WinNum_lbl = new System.Windows.Forms.Label();
            this.p1WinPercentNum_lbl = new System.Windows.Forms.Label();
            this.aiWinPercentNum_lbl = new System.Windows.Forms.Label();
            this.aiWinNum_lbl = new System.Windows.Forms.Label();
            this.tiesNum_lbl = new System.Windows.Forms.Label();
            this.tiePercent_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameStats_lbl
            // 
            this.gameStats_lbl.AutoSize = true;
            this.gameStats_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gameStats_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStats_lbl.Location = new System.Drawing.Point(8, 6);
            this.gameStats_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameStats_lbl.Name = "gameStats_lbl";
            this.gameStats_lbl.Size = new System.Drawing.Size(289, 46);
            this.gameStats_lbl.TabIndex = 0;
            this.gameStats_lbl.Text = "Game Statistics";
            // 
            // p1Wins_lbl
            // 
            this.p1Wins_lbl.AutoSize = true;
            this.p1Wins_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p1Wins_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Wins_lbl.Location = new System.Drawing.Point(12, 79);
            this.p1Wins_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1Wins_lbl.Name = "p1Wins_lbl";
            this.p1Wins_lbl.Size = new System.Drawing.Size(115, 22);
            this.p1Wins_lbl.TabIndex = 1;
            this.p1Wins_lbl.Text = "Player Wins: ";
            this.p1Wins_lbl.Click += new System.EventHandler(this.p1Wins_lbl_Click);
            // 
            // p1WinPercent_lbl
            // 
            this.p1WinPercent_lbl.AutoSize = true;
            this.p1WinPercent_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p1WinPercent_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1WinPercent_lbl.Location = new System.Drawing.Point(12, 112);
            this.p1WinPercent_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1WinPercent_lbl.Name = "p1WinPercent_lbl";
            this.p1WinPercent_lbl.Size = new System.Drawing.Size(127, 22);
            this.p1WinPercent_lbl.TabIndex = 2;
            this.p1WinPercent_lbl.Text = "Player Win %: ";
            // 
            // aiWInPercent_lbl
            // 
            this.aiWInPercent_lbl.AutoSize = true;
            this.aiWInPercent_lbl.BackColor = System.Drawing.Color.Transparent;
            this.aiWInPercent_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiWInPercent_lbl.Location = new System.Drawing.Point(287, 112);
            this.aiWInPercent_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aiWInPercent_lbl.Name = "aiWInPercent_lbl";
            this.aiWInPercent_lbl.Size = new System.Drawing.Size(94, 22);
            this.aiWInPercent_lbl.TabIndex = 4;
            this.aiWInPercent_lbl.Text = "AI Win %: ";
            // 
            // aiWins_lbl
            // 
            this.aiWins_lbl.AutoSize = true;
            this.aiWins_lbl.BackColor = System.Drawing.Color.Transparent;
            this.aiWins_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiWins_lbl.Location = new System.Drawing.Point(287, 79);
            this.aiWins_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aiWins_lbl.Name = "aiWins_lbl";
            this.aiWins_lbl.Size = new System.Drawing.Size(82, 22);
            this.aiWins_lbl.TabIndex = 3;
            this.aiWins_lbl.Text = "AI Wins: ";
            // 
            // ties_lbl
            // 
            this.ties_lbl.AutoSize = true;
            this.ties_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ties_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ties_lbl.Location = new System.Drawing.Point(12, 210);
            this.ties_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ties_lbl.Name = "ties_lbl";
            this.ties_lbl.Size = new System.Drawing.Size(52, 22);
            this.ties_lbl.TabIndex = 5;
            this.ties_lbl.Text = "Ties: ";
            // 
            // p1WinNum_lbl
            // 
            this.p1WinNum_lbl.AutoSize = true;
            this.p1WinNum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p1WinNum_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1WinNum_lbl.Location = new System.Drawing.Point(141, 79);
            this.p1WinNum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1WinNum_lbl.Name = "p1WinNum_lbl";
            this.p1WinNum_lbl.Size = new System.Drawing.Size(0, 22);
            this.p1WinNum_lbl.TabIndex = 6;
            // 
            // p1WinPercentNum_lbl
            // 
            this.p1WinPercentNum_lbl.AutoSize = true;
            this.p1WinPercentNum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p1WinPercentNum_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1WinPercentNum_lbl.Location = new System.Drawing.Point(141, 112);
            this.p1WinPercentNum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1WinPercentNum_lbl.Name = "p1WinPercentNum_lbl";
            this.p1WinPercentNum_lbl.Size = new System.Drawing.Size(0, 22);
            this.p1WinPercentNum_lbl.TabIndex = 7;
            // 
            // aiWinPercentNum_lbl
            // 
            this.aiWinPercentNum_lbl.AutoSize = true;
            this.aiWinPercentNum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.aiWinPercentNum_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiWinPercentNum_lbl.Location = new System.Drawing.Point(383, 112);
            this.aiWinPercentNum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aiWinPercentNum_lbl.Name = "aiWinPercentNum_lbl";
            this.aiWinPercentNum_lbl.Size = new System.Drawing.Size(0, 22);
            this.aiWinPercentNum_lbl.TabIndex = 8;
            // 
            // aiWinNum_lbl
            // 
            this.aiWinNum_lbl.AutoSize = true;
            this.aiWinNum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.aiWinNum_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiWinNum_lbl.Location = new System.Drawing.Point(383, 79);
            this.aiWinNum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aiWinNum_lbl.Name = "aiWinNum_lbl";
            this.aiWinNum_lbl.Size = new System.Drawing.Size(0, 22);
            this.aiWinNum_lbl.TabIndex = 9;
            // 
            // tiesNum_lbl
            // 
            this.tiesNum_lbl.AutoSize = true;
            this.tiesNum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tiesNum_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesNum_lbl.Location = new System.Drawing.Point(67, 210);
            this.tiesNum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tiesNum_lbl.Name = "tiesNum_lbl";
            this.tiesNum_lbl.Size = new System.Drawing.Size(0, 22);
            this.tiesNum_lbl.TabIndex = 10;
            // 
            // tiePercent_lbl
            // 
            this.tiePercent_lbl.AutoSize = true;
            this.tiePercent_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tiePercent_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiePercent_lbl.Location = new System.Drawing.Point(80, 232);
            this.tiePercent_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tiePercent_lbl.Name = "tiePercent_lbl";
            this.tiePercent_lbl.Size = new System.Drawing.Size(0, 22);
            this.tiePercent_lbl.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tie %: ";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(475, 280);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(88, 31);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS153_FinalProject.Properties.Resources.moon_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 323);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.tiePercent_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tiesNum_lbl);
            this.Controls.Add(this.aiWinNum_lbl);
            this.Controls.Add(this.aiWinPercentNum_lbl);
            this.Controls.Add(this.p1WinPercentNum_lbl);
            this.Controls.Add(this.p1WinNum_lbl);
            this.Controls.Add(this.ties_lbl);
            this.Controls.Add(this.aiWInPercent_lbl);
            this.Controls.Add(this.aiWins_lbl);
            this.Controls.Add(this.p1WinPercent_lbl);
            this.Controls.Add(this.p1Wins_lbl);
            this.Controls.Add(this.gameStats_lbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stats";
            this.Text = "Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameStats_lbl;
        private System.Windows.Forms.Label p1Wins_lbl;
        private System.Windows.Forms.Label p1WinPercent_lbl;
        private System.Windows.Forms.Label aiWInPercent_lbl;
        private System.Windows.Forms.Label aiWins_lbl;
        private System.Windows.Forms.Label ties_lbl;
        private System.Windows.Forms.Label p1WinNum_lbl;
        private System.Windows.Forms.Label p1WinPercentNum_lbl;
        private System.Windows.Forms.Label aiWinPercentNum_lbl;
        private System.Windows.Forms.Label aiWinNum_lbl;
        private System.Windows.Forms.Label tiesNum_lbl;
        private System.Windows.Forms.Label tiePercent_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
    }
}