namespace WarShip
{
    partial class YoN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoN));
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.AutoEllipsis = true;
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yes.Image = global::WarShip.Properties.Resources.imgonline_com_ua_AutoEnrich_7m715k31IcjGpo;
            this.yes.Location = new System.Drawing.Point(68, 132);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(120, 50);
            this.yes.TabIndex = 0;
            this.yes.Text = "Да";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yes_MouseClick);
            // 
            // no
            // 
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no.Image = global::WarShip.Properties.Resources.imgonline_com_ua_AutoEnrich_7m715k31IcjGpo;
            this.no.Location = new System.Drawing.Point(258, 132);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(120, 50);
            this.no.TabIndex = 1;
            this.no.Text = "Нет";
            this.no.UseVisualStyleBackColor = true;
            this.no.MouseClick += new System.Windows.Forms.MouseEventHandler(this.no_MouseClick);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.BackColor = System.Drawing.Color.Transparent;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sure.Location = new System.Drawing.Point(51, 55);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(343, 39);
            this.sure.TabIndex = 2;
            this.sure.Text = "Начать игру заного?";
            this.sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YoN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WarShip.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(462, 238);
            this.ControlBox = false;
            this.Controls.Add(this.sure);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoN";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рестарт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label sure;
    }
}