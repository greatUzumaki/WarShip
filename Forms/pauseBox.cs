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
    public partial class pauseBox : Form
    {
        GamePvP gamePvP;
        GamePvE gamePvE;
        YoN restartbox;


        public pauseBox(GamePvP gamePvP)
        {
            InitializeComponent();
            this.gamePvP = gamePvP;
        }
        public pauseBox(GamePvE gamePvE)
        {
            InitializeComponent();
            this.gamePvE = gamePvE;
        }

        private void restartFromPause_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (gamePvP != null)
            {
                restartbox = new YoN(gamePvP);
            }
            else
            {
                restartbox = new YoN(gamePvE);
            }
            restartbox.Show();
            this.Hide();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (gamePvP == null)
                    {
                        gamePvE.click = 0;
                        gamePvE.stadia = false;
                        gamePvE.GamePoleFight.pole[i, j] = null;
                        this.gamePvE.GamePole.pole[i, j] = null;
                        this.gamePvE.lim1 = 4;
                        this.gamePvE.lim2 = 3;
                        this.gamePvE.lim3 = 2;
                        this.gamePvE.lim4 = 1;
                        
                    }
                    else
                    {
                        gamePvP.click = 0;
                        gamePvP.GamePoleFight.pole[i, j] = null;
                        this.gamePvP.stadia = false;
                        this.gamePvP.GamePole.pole[i, j] = null;
                        this.gamePvP.lim1 = 4;
                        this.gamePvP.lim2 = 3;
                        this.gamePvP.lim3 = 2;
                        this.gamePvP.lim4 = 1;
                        
                    }
                }
            }
        }

        private void closePause_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void backToMenu_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            if (gamePvE == null)
                gamePvP.Hide();
            else gamePvE.Hide();
            menu formmenu = WarShip.menu.m;
            formmenu.Show();
        }

    }
}
