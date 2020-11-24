namespace WarShip
{
    partial class pauseBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pauseBox));
            this.backToMenu = new System.Windows.Forms.Button();
            this.closePause = new System.Windows.Forms.Button();
            this.restartFromPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMenu
            // 
            this.backToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenu.Image = global::WarShip.Properties.Resources.button2;
            this.backToMenu.Location = new System.Drawing.Point(282, 37);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(230, 75);
            this.backToMenu.TabIndex = 0;
            this.backToMenu.Text = "Вернуться в главное меню";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backToMenu_MouseClick);
            // 
            // closePause
            // 
            this.closePause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closePause.Image = global::WarShip.Properties.Resources.button2;
            this.closePause.Location = new System.Drawing.Point(327, 291);
            this.closePause.Name = "closePause";
            this.closePause.Size = new System.Drawing.Size(135, 75);
            this.closePause.TabIndex = 1;
            this.closePause.Text = "Закрыть";
            this.closePause.UseVisualStyleBackColor = true;
            this.closePause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closePause_MouseClick);
            // 
            // restartFromPause
            // 
            this.restartFromPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartFromPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartFromPause.Image = global::WarShip.Properties.Resources.button2;
            this.restartFromPause.Location = new System.Drawing.Point(307, 162);
            this.restartFromPause.Name = "restartFromPause";
            this.restartFromPause.Size = new System.Drawing.Size(180, 75);
            this.restartFromPause.TabIndex = 2;
            this.restartFromPause.Text = "Рестарт";
            this.restartFromPause.UseVisualStyleBackColor = true;
            this.restartFromPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restartFromPause_MouseClick);
            // 
            // pauseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.ControlBox = false;
            this.Controls.Add(this.restartFromPause);
            this.Controls.Add(this.closePause);
            this.Controls.Add(this.backToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pauseBox";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.Button closePause;
        private System.Windows.Forms.Button restartFromPause;
    }
}