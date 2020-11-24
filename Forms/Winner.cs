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
    public partial class Winner : Form
    {
        GamePvP gamePvP;
        GamePvE gamePvE;

        public Winner(GamePvP gamePvP)
        {
            bool w = gamePvP.Win;
            InitializeComponent();
            if (w == true)
            {
               playerWin.Text="Победил Игрок 1";
            }
            else
            {
                playerWin.Text = "Победил Игрок 2";
            }

        }
        public Winner(GamePvE gamePvE)
        {
            bool w = gamePvE.Win;
            InitializeComponent();
            if (w == true)
            {
                playerWin.Text = "Вы победили !";
            }
            else
            {
                playerWin.Text = "Вы проиграли...";
            }

        }

        private void backFromWin_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            menu formmenu = WarShip.menu.m;
            formmenu.Show();
        }

        private void Winner_FormClosing(object sender, FormClosingEventArgs e)
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
