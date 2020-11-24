namespace WarShip
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.backFromWin = new System.Windows.Forms.Button();
            this.playerWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backFromWin
            // 
            this.backFromWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backFromWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backFromWin.Image = global::WarShip.Properties.Resources.button2;
            this.backFromWin.Location = new System.Drawing.Point(414, 398);
            this.backFromWin.Name = "backFromWin";
            this.backFromWin.Size = new System.Drawing.Size(290, 84);
            this.backFromWin.TabIndex = 0;
            this.backFromWin.Text = "Вернуться в главное меню";
            this.backFromWin.UseVisualStyleBackColor = true;
            this.backFromWin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backFromWin_MouseClick);
            // 
            // playerWin
            // 
            this.playerWin.AutoSize = true;
            this.playerWin.BackColor = System.Drawing.Color.Transparent;
            this.playerWin.Cursor = System.Windows.Forms.Cursors.Default;
            this.playerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerWin.ForeColor = System.Drawing.Color.Cornsilk;
            this.playerWin.Location = new System.Drawing.Point(272, 37);
            this.playerWin.Name = "playerWin";
            this.playerWin.Size = new System.Drawing.Size(597, 76);
            this.playerWin.TabIndex = 1;
            this.playerWin.Text = "Победил Игрок 1!";
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarShip.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1127, 585);
            this.Controls.Add(this.playerWin);
            this.Controls.Add(this.backFromWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Winner";
            this.Text = "Результат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Winner_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backFromWin;
        private System.Windows.Forms.Label playerWin;
    }
}