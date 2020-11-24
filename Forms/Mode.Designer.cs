namespace WarShip
{
    partial class Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode));
            this.ModePvE = new System.Windows.Forms.Button();
            this.ModePvP = new System.Windows.Forms.Button();
            this.backFromMode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModePvE
            // 
            this.ModePvE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModePvE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModePvE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModePvE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModePvE.Image = global::WarShip.Properties.Resources.button2;
            this.ModePvE.Location = new System.Drawing.Point(635, 372);
            this.ModePvE.Name = "ModePvE";
            this.ModePvE.Size = new System.Drawing.Size(200, 100);
            this.ModePvE.TabIndex = 0;
            this.ModePvE.Text = "Игрок VS Компьютера";
            this.ModePvE.UseVisualStyleBackColor = true;
            this.ModePvE.Click += new System.EventHandler(this.ModePvE_Click);
            // 
            // ModePvP
            // 
            this.ModePvP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModePvP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModePvP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModePvP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModePvP.Image = global::WarShip.Properties.Resources.button2;
            this.ModePvP.Location = new System.Drawing.Point(203, 372);
            this.ModePvP.Name = "ModePvP";
            this.ModePvP.Size = new System.Drawing.Size(200, 100);
            this.ModePvP.TabIndex = 1;
            this.ModePvP.Text = "Игрок VS Игрока";
            this.ModePvP.UseVisualStyleBackColor = true;
            this.ModePvP.Click += new System.EventHandler(this.ModePvP_Click);
            // 
            // backFromMode
            // 
            this.backFromMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backFromMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backFromMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backFromMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backFromMode.Image = global::WarShip.Properties.Resources.button2;
            this.backFromMode.Location = new System.Drawing.Point(1080, 372);
            this.backFromMode.Name = "backFromMode";
            this.backFromMode.Size = new System.Drawing.Size(200, 100);
            this.backFromMode.TabIndex = 2;
            this.backFromMode.Text = "Назад";
            this.backFromMode.UseVisualStyleBackColor = true;
            this.backFromMode.Click += new System.EventHandler(this.backFromMode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WarShip.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(353, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 249);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WarShip.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backFromMode);
            this.Controls.Add(this.ModePvP);
            this.Controls.Add(this.ModePvE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mode";
            this.Text = "Режим игры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mode_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModePvE;
        private System.Windows.Forms.Button ModePvP;
        private System.Windows.Forms.Button backFromMode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}