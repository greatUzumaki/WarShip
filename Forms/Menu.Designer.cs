namespace WarShip
{
    partial class menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.Mode = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.Color.Transparent;
            this.Mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mode.Image = global::WarShip.Properties.Resources.button2;
            this.Mode.Location = new System.Drawing.Point(503, 421);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(200, 100);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Играть";
            this.Mode.UseVisualStyleBackColor = false;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // Author
            // 
            this.Author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Author.Image = global::WarShip.Properties.Resources.button2;
            this.Author.Location = new System.Drawing.Point(200, 421);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(200, 100);
            this.Author.TabIndex = 1;
            this.Author.Text = "Об авторе";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // butExit
            // 
            this.butExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butExit.Image = global::WarShip.Properties.Resources.button2;
            this.butExit.Location = new System.Drawing.Point(1097, 421);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(200, 100);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "Выйти";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butExit_MouseClick);
            // 
            // butHelp
            // 
            this.butHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butHelp.Image = global::WarShip.Properties.Resources.button2;
            this.butHelp.Location = new System.Drawing.Point(803, 421);
            this.butHelp.Name = "butHelp";
            this.butHelp.Size = new System.Drawing.Size(200, 100);
            this.butHelp.TabIndex = 4;
            this.butHelp.Text = "Помощь";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WarShip.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(353, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 249);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WarShip.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Mode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Морской бой";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mode;
        private System.Windows.Forms.Button Author;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

