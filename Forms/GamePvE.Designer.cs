namespace WarShip
{
    partial class GamePvE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePvE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shipPanelPvE = new System.Windows.Forms.Panel();
            this.butShip1 = new System.Windows.Forms.RadioButton();
            this.butShip2 = new System.Windows.Forms.RadioButton();
            this.butShip3 = new System.Windows.Forms.RadioButton();
            this.butShip4 = new System.Windows.Forms.RadioButton();
            this.picPanelPvE = new System.Windows.Forms.Panel();
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
            this.restart = new System.Windows.Forms.Button();
            this.butReady = new System.Windows.Forms.Button();
            this.faseBattle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.shipPanelPvE.SuspendLayout();
            this.picPanelPvE.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::WarShip.Properties.Resources.button1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.faseBattle);
            this.groupBox1.Controls.Add(this.shipPanelPvE);
            this.groupBox1.Controls.Add(this.picPanelPvE);
            this.groupBox1.Controls.Add(this.pause);
            this.groupBox1.Controls.Add(this.restart);
            this.groupBox1.Controls.Add(this.butReady);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 672);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1548, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // shipPanelPvE
            // 
            this.shipPanelPvE.Controls.Add(this.butShip1);
            this.shipPanelPvE.Controls.Add(this.butShip2);
            this.shipPanelPvE.Controls.Add(this.butShip3);
            this.shipPanelPvE.Controls.Add(this.butShip4);
            this.shipPanelPvE.Location = new System.Drawing.Point(57, 77);
            this.shipPanelPvE.Name = "shipPanelPvE";
            this.shipPanelPvE.Size = new System.Drawing.Size(854, 33);
            this.shipPanelPvE.TabIndex = 17;
            // 
            // butShip1
            // 
            this.butShip1.AutoSize = true;
            this.butShip1.Location = new System.Drawing.Point(0, 4);
            this.butShip1.Name = "butShip1";
            this.butShip1.Size = new System.Drawing.Size(183, 29);
            this.butShip1.TabIndex = 0;
            this.butShip1.TabStop = true;
            this.butShip1.Text = "Однопалубный";
            this.butShip1.UseVisualStyleBackColor = true;
            this.butShip1.CheckedChanged += new System.EventHandler(this.butShip1_CheckedChanged);
            // 
            // butShip2
            // 
            this.butShip2.AutoSize = true;
            this.butShip2.Location = new System.Drawing.Point(208, 4);
            this.butShip2.Name = "butShip2";
            this.butShip2.Size = new System.Drawing.Size(180, 29);
            this.butShip2.TabIndex = 1;
            this.butShip2.TabStop = true;
            this.butShip2.Text = "Двухпалубный";
            this.butShip2.UseVisualStyleBackColor = true;
            this.butShip2.CheckedChanged += new System.EventHandler(this.butShip2_CheckedChanged);
            // 
            // butShip3
            // 
            this.butShip3.AutoSize = true;
            this.butShip3.Location = new System.Drawing.Point(406, 4);
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
            this.butShip4.Location = new System.Drawing.Point(608, 4);
            this.butShip4.Name = "butShip4";
            this.butShip4.Size = new System.Drawing.Size(219, 29);
            this.butShip4.TabIndex = 3;
            this.butShip4.TabStop = true;
            this.butShip4.Text = "Четрыёхпалубный";
            this.butShip4.UseVisualStyleBackColor = true;
            this.butShip4.CheckedChanged += new System.EventHandler(this.butShip4_CheckedChanged);
            // 
            // picPanelPvE
            // 
            this.picPanelPvE.Controls.Add(this.pictureBox1);
            this.picPanelPvE.Controls.Add(this.pictureBox10);
            this.picPanelPvE.Controls.Add(this.pictureBox2);
            this.picPanelPvE.Controls.Add(this.pictureBox7);
            this.picPanelPvE.Controls.Add(this.pictureBox3);
            this.picPanelPvE.Controls.Add(this.pictureBox8);
            this.picPanelPvE.Controls.Add(this.pictureBox4);
            this.picPanelPvE.Controls.Add(this.pictureBox9);
            this.picPanelPvE.Controls.Add(this.pictureBox5);
            this.picPanelPvE.Controls.Add(this.pictureBox6);
            this.picPanelPvE.Location = new System.Drawing.Point(98, 116);
            this.picPanelPvE.Name = "picPanelPvE";
            this.picPanelPvE.Size = new System.Drawing.Size(790, 49);
            this.picPanelPvE.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(38, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(716, 9);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 31);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(205, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(672, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 31);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(247, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(630, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 31);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(431, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 31);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(588, 9);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 31);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(389, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 31);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WarShip.Properties.Resources.ship1;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(473, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 31);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pause
            // 
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause.Image = global::WarShip.Properties.Resources.button2;
            this.pause.Location = new System.Drawing.Point(1327, 77);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(150, 70);
            this.pause.TabIndex = 6;
            this.pause.Text = "Меню";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pause_MouseClick);
            // 
            // restart
            // 
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.Image = global::WarShip.Properties.Resources.button2;
            this.restart.Location = new System.Drawing.Point(1122, 77);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(150, 70);
            this.restart.TabIndex = 5;
            this.restart.Text = "Рестарт";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restart_MouseClick);
            // 
            // butReady
            // 
            this.butReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReady.Image = global::WarShip.Properties.Resources.button2;
            this.butReady.Location = new System.Drawing.Point(917, 77);
            this.butReady.Name = "butReady";
            this.butReady.Size = new System.Drawing.Size(150, 70);
            this.butReady.TabIndex = 4;
            this.butReady.Text = "Готов";
            this.butReady.UseVisualStyleBackColor = true;
            this.butReady.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butReady_MouseClick);
            // 
            // faseBattle
            // 
            this.faseBattle.AutoSize = true;
            this.faseBattle.BackColor = System.Drawing.Color.Transparent;
            this.faseBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faseBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faseBattle.Location = new System.Drawing.Point(286, 69);
            this.faseBattle.Name = "faseBattle";
            this.faseBattle.Size = new System.Drawing.Size(416, 76);
            this.faseBattle.TabIndex = 16;
            this.faseBattle.Text = "Фаза битвы";
            // 
            // GamePvE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarShip.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamePvE";
            this.Text = "Морской бой";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePvE_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePvE_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GamePvE_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.shipPanelPvE.ResumeLayout(false);
            this.shipPanelPvE.PerformLayout();
            this.picPanelPvE.ResumeLayout(false);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton butShip3;
        private System.Windows.Forms.RadioButton butShip2;
        private System.Windows.Forms.RadioButton butShip1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button restart;
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
        public System.Windows.Forms.Label faseBattle;
        public System.Windows.Forms.RadioButton butShip4;
        public System.Windows.Forms.Panel picPanelPvE;
        public System.Windows.Forms.Panel shipPanelPvE;
    }
}