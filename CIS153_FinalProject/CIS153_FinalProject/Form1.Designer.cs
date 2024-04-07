namespace CIS153_FinalProject
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.loadedPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loading_lbl = new System.Windows.Forms.Label();
            this.Connect4_title = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 20;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // loadedPanel
            // 
            this.loadedPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.loadedPanel.Location = new System.Drawing.Point(3, 0);
            this.loadedPanel.Name = "loadedPanel";
            this.loadedPanel.Size = new System.Drawing.Size(10, 31);
            this.loadedPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.loadedPanel);
            this.panel2.Location = new System.Drawing.Point(-4, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 31);
            this.panel2.TabIndex = 1;
            // 
            // loading_lbl
            // 
            this.loading_lbl.AutoSize = true;
            this.loading_lbl.BackColor = System.Drawing.Color.Transparent;
            this.loading_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loading_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_lbl.Location = new System.Drawing.Point(12, 387);
            this.loading_lbl.Name = "loading_lbl";
            this.loading_lbl.Size = new System.Drawing.Size(151, 31);
            this.loading_lbl.TabIndex = 2;
            this.loading_lbl.Text = "LOADING...";
            // 
            // Connect4_title
            // 
            this.Connect4_title.AutoSize = true;
            this.Connect4_title.BackColor = System.Drawing.Color.Transparent;
            this.Connect4_title.Font = new System.Drawing.Font("Palatino Linotype", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Connect4_title.Location = new System.Drawing.Point(12, 9);
            this.Connect4_title.Name = "Connect4_title";
            this.Connect4_title.Size = new System.Drawing.Size(450, 128);
            this.Connect4_title.TabIndex = 5;
            this.Connect4_title.Text = "Connect4";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::CIS153_FinalProject.Properties.Resources.train;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.Connect4_title);
            this.Controls.Add(this.loading_lbl);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel loadedPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loading_lbl;
        public System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Label Connect4_title;
    }
}

