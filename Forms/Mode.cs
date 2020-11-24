using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarShip
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void ModePvP_Click(object sender, EventArgs e)
        {
            GamePvP formpvp = new GamePvP();
            this.Hide();
            formpvp.Show();
        }

        private void ModePvE_Click(object sender, EventArgs e)
        {
            GamePvE formpve = new GamePvE();
            this.Hide();
            formpve.Show();
        }

        private void backFromMode_Click(object sender, EventArgs e)
        {
            menu formmenu = WarShip.menu.m;
            this.Hide();
            formmenu.Show();
        }

        private void Mode_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
               "Вы действительно хотите выйти?",
               "Выход",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
                WarShip.menu.m.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
