namespace WarShip
{
    partial class GamePvP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePvP));
            this.boxShips = new System.Windows.Forms.GroupBox();
            this.shipPanelPvP = new System.Windows.Forms.Panel();
            this.butShip1 = new System.Windows.Forms.RadioButton();
            this.butShip2 = new System.Windows.Forms.RadioButton();
            this.butShip3 = new System.Windows.Forms.RadioButton();
            this.butShip4 = new System.Windows.Forms.RadioButton();
            this.picPanelPvP = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.Button();
            this.butReady = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.butHod = new System.Windows.Forms.Button();
            this.faseBattle = new System.Windows.Forms.Label();
            this.boxShips.SuspendLayout();
            this.shipPanelPvP.SuspendLayout();
            this.picPanelPvP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // boxShips
            // 
            this.boxShips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxShips.BackColor = System.Drawing.Color.Transparent;
            this.boxShips.BackgroundImage = global::WarShip.Properties.Resources.button1;
            this.boxShips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxShips.Controls.Add(this.faseBattle);
            this.boxShips.Controls.Add(this.shipPanelPvP);
            this.boxShips.Controls.Add(this.picPanelPvP);
            this.boxShips.Controls.Add(this.pause);
            this.boxShips.Controls.Add(this.butReady);
            this.boxShips.Controls.Add(this.restart);
            this.boxShips.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxShips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxShips.Location = new System.Drawing.Point(-4, 672);
            this.boxShips.Name = "boxShips";
            this.boxShips.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxShips.Size = new System.Drawing.Size(1548, 220);
            this.boxShips.TabIndex = 1;
            this.boxShips.TabStop = false;
            // 
            // shipPanelPvP
            // 
            this.shipPanelPvP.Controls.Add(this.butShip1);
            this.shipPanelPvP.Controls.Add(this.butShip2);
            this.shipPanelPvP.Controls.Add(this.butShip3);
            this.shipPanelPvP.Controls.Add(this.butShip4);
            this.shipPanelPvP.Location = new System.Drawing.Point(16, 70);
            this.shipPanelPvP.Name = "shipPanelPvP";
            this.shipPanelPvP.Size = new System.Drawing.Size(855, 37);
            this.shipPanelPvP.TabIndex = 16;
            // 
            // butShip1
            // 
            this.butShip1.AutoSize = true;
            this.butShip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShip1.Location = new System.Drawing.Point(0, 5);
            this.butShip1.Name = "butShip1";
            this.butShip1.Size = new System.Drawing.Size(183, 29);
            this.butShip1.TabIndex = 0;
            this.butShip1.Text = "Однопалубный";
            this.butShip1.UseVisualStyleBackColor = true;
            this.butShip1.CheckedChanged += new System.EventHandler(this.butShip1_CheckedChanged);
            // 
            // butShip2
            // 
            this.butShip2.AutoSize = true;
            this.butShip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShip2.Location = new System.Drawing.Point(208, 5);
            this.butShip2.Name = "butShip2";
            this.butShip2.Size = new System.Drawing.Size(180, 29);
            this.butShip2.TabIndex = 1;
            this.butShip2.Text = "Двухпалубный";
            this.butShip2.UseVisualStyleBackColor = true;
            this.butShip2.CheckedChanged += new System.EventHandler(this.butShip2_CheckedChanged);
            // 
            // butShip3
            // 
            this.butShip3.AutoSize = true;
            this.butShip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShip3.Location = new System.Drawing.Point(406, 5);
            this.butShip3.Name = "butShip3";
            this.butShip3.Size = new System.Drawing.Size(178, 29);
            this.butShip3.TabIndex = 2;
            this.butShip3.TabStop = true;
            this.butShip3.Text = "Трёхпалубный";
            this.butShip3.UseVisualStyleBackColor = true;
            this.butShip3.CheckedChanged += new System.EventHandler(this.butShip3_CheckedChanged);
            // 
            // butShip4
            // 
            this.butShip4.AutoSize = true;
            this.butShip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShip4.Location = new System.Drawing.Point(608, 5);
            this.butShip4.Name = "butShip4";
            this.butShip4.Size = new System.Drawing.Size(219, 29);
            this.butShip4.TabIndex = 3;
            this.butShip4.TabStop = true;
            this.butShip4.Text = "Четырёхпалубный";
            this.butShip4.UseVisualStyleBackColor = true;
            this.butShip4.CheckedChanged += new System.EventHandler(this.butShip4_CheckedChanged);
            // 
            // picPanelPvP
            // 
            this.picPanelPvP.Controls.Add(this.pictureBox1);
            this.picPanelPvP.Controls.Add(this.pictureBox10);
            this.picPanelPvP.Controls.Add(this.pictureBox2);
            this.picPanelPvP.Controls.Add(this.pictureBox7);
            this.picPanelPvP.Controls.Add(this.pictureBox3);
            this.picPanelPvP.Controls.Add(this.pictureBox8);
            this.picPanelPvP.Controls.Add(this.pictureBox4);
            this.picPanelPvP.Controls.Add(this.pictureBox9);
            this.picPanelPvP.Controls.Add(this.pictureBox5);
            this.picPanelPvP.Controls.Add(this.pictureBox6);
            this.picPanelPvP.Location = new System.Drawing.Point(102, 116);
            this.picPanelPvP.Name = "picPanelPvP";
            this.picPanelPvP.Size = new System.Drawing.Size(769, 49);
            this.picPanelPvP.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(683, 9);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 31);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(167, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(639, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 31);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(209, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(597, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 31);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(399, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 31);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(555, 9);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 31);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(357, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 31);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(441, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 31);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause.Image = global::WarShip.Properties.Resources.button2;
            this.pause.Location = new System.Drawing.Point(1305, 70);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(150, 70);
            this.pause.TabIndex = 3;
            this.pause.Text = "Меню";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pause_MouseClick);
            // 
            // butReady
            // 
            this.butReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReady.Image = global::WarShip.Properties.Resources.button2;
            this.butReady.Location = new System.Drawing.Point(891, 70);
            this.butReady.Name = "butReady";
            this.butReady.Size = new System.Drawing.Size(150, 70);
            this.butReady.TabIndex = 4;
            this.butReady.Text = "Готов";
            this.butReady.UseVisualStyleBackColor = true;
            this.butReady.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butReady_MouseClick);
            // 
            // restart
            // 
            this.restart.BackgroundImage = global::WarShip.Properties.Resources.button2;
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.Image = global::WarShip.Properties.Resources.button2;
            this.restart.Location = new System.Drawing.Point(1098, 70);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(150, 70);
            this.restart.TabIndex = 2;
            this.restart.Text = "Рестарт";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restart_MouseClick);
            // 
            // butHod
            // 
            this.butHod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butHod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butHod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butHod.Image = global::WarShip.Properties.Resources.button2;
            this.butHod.Location = new System.Drawing.Point(418, 718);
            this.butHod.Name = "butHod";
            this.butHod.Size = new System.Drawing.Size(619, 132);
            this.butHod.TabIndex = 2;
            this.butHod.Text = "Передать ход";
            this.butHod.UseVisualStyleBackColor = true;
            this.butHod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butHod_MouseClick);
            // 
            // faseBattle
            // 
            this.faseBattle.AutoSize = true;
            this.faseBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faseBattle.Location = new System.Drawing.Point(69, 78);
            this.faseBattle.Name = "faseBattle";
            this.faseBattle.Size = new System.Drawing.Size(314, 58);
            this.faseBattle.TabIndex = 15;
            this.faseBattle.Text = "Фаза битвы";
            // 
            // GamePvP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WarShip.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.butHod);
            this.Controls.Add(this.boxShips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamePvP";
            this.Text = "Морской бой";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePvP_FormClosing);
            this.Load += new System.EventHandler(this.GamePvP_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePvP_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GamePvP_MouseClick);
            this.boxShips.ResumeLayout(false);
            this.boxShips.PerformLayout();
            this.shipPanelPvP.ResumeLayout(false);
            this.shipPanelPvP.PerformLayout();
            this.picPanelPvP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox boxShips;
        private System.Windows.Forms.RadioButton butShip2;
        private System.Windows.Forms.RadioButton butShip1;
        private System.Windows.Forms.RadioButton butShip4;
        private System.Windows.Forms.RadioButton butShip3;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button butReady;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Panel picPanelPvP;
        public System.Windows.Forms.Panel shipPanelPvP;
        public System.Windows.Forms.Label faseBattle;
        public System.Windows.Forms.Button butHod;
    }
}