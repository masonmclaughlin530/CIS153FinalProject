namespace CIS153_FinalProject
{
    partial class Connect4
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
            this.selection_picbox = new System.Windows.Forms.PictureBox();
            this.single_btn = new System.Windows.Forms.Button();
            this.twoPlayer_btn = new System.Windows.Forms.Button();
            this.stats_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.gameTitle_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selection_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // selection_picbox
            // 
            this.selection_picbox.Image = global::CIS153_FinalProject.Properties.Resources.movin;
            this.selection_picbox.Location = new System.Drawing.Point(-277, 12);
            this.selection_picbox.Name = "selection_picbox";
            this.selection_picbox.Size = new System.Drawing.Size(1377, 646);
            this.selection_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selection_picbox.TabIndex = 0;
            this.selection_picbox.TabStop = false;
            // 
            // single_btn
            // 
            this.single_btn.BackColor = System.Drawing.Color.DarkGray;
            this.single_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.single_btn.Location = new System.Drawing.Point(12, 324);
            this.single_btn.Name = "single_btn";
            this.single_btn.Size = new System.Drawing.Size(132, 46);
            this.single_btn.TabIndex = 1;
            this.single_btn.Text = "Single Player";
            this.single_btn.UseVisualStyleBackColor = false;
            this.single_btn.Click += new System.EventHandler(this.single_btn_Click);
            // 
            // twoPlayer_btn
            // 
            this.twoPlayer_btn.BackColor = System.Drawing.Color.DarkGray;
            this.twoPlayer_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayer_btn.Location = new System.Drawing.Point(222, 324);
            this.twoPlayer_btn.Name = "twoPlayer_btn";
            this.twoPlayer_btn.Size = new System.Drawing.Size(132, 46);
            this.twoPlayer_btn.TabIndex = 2;
            this.twoPlayer_btn.Text = "Two Player";
            this.twoPlayer_btn.UseVisualStyleBackColor = false;
            this.twoPlayer_btn.Click += new System.EventHandler(this.twoPlayer_btn_Click);
            // 
            // stats_btn
            // 
            this.stats_btn.BackColor = System.Drawing.Color.DarkGray;
            this.stats_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_btn.Location = new System.Drawing.Point(448, 324);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(132, 46);
            this.stats_btn.TabIndex = 3;
            this.stats_btn.Text = "Statistics";
            this.stats_btn.UseVisualStyleBackColor = false;
            this.stats_btn.Click += new System.EventHandler(this.stats_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.DarkGray;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.exit_btn.Location = new System.Drawing.Point(656, 324);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(132, 46);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // gameTitle_lbl
            // 
            this.gameTitle_lbl.AutoSize = true;
            this.gameTitle_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle_lbl.Font = new System.Drawing.Font("Palatino Linotype", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle_lbl.ForeColor = System.Drawing.Color.Black;
            this.gameTitle_lbl.Location = new System.Drawing.Point(296, -12);
            this.gameTitle_lbl.Name = "gameTitle_lbl";
            this.gameTitle_lbl.Size = new System.Drawing.Size(450, 128);
            this.gameTitle_lbl.TabIndex = 5;
            this.gameTitle_lbl.Text = "Connect4";
            // 
            // Connect4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS153_FinalProject.Properties.Resources.movin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameTitle_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.stats_btn);
            this.Controls.Add(this.twoPlayer_btn);
            this.Controls.Add(this.single_btn);
            this.Controls.Add(this.selection_picbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Connect4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect4";
            ((System.ComponentModel.ISupportInitialize)(this.selection_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox selection_picbox;
        private System.Windows.Forms.Button single_btn;
        private System.Windows.Forms.Button twoPlayer_btn;
        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label gameTitle_lbl;
    }
}