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
    public partial class YoN : Form
    {
        GamePvP gamePvP;
        GamePvE gamePvE;
        public YoN(GamePvP gamePvP)
        {
            InitializeComponent();
           this.gamePvP = gamePvP;
            
        }
        public YoN(GamePvE gamePvE)
        {
            InitializeComponent();
            this.gamePvE = gamePvE;
        }
       
        private void no_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void yes_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            for(int i = 0; i<10; i++)
            {
                for(int j = 0; j<10; j++)
                {
                    if (gamePvP == null)
                    {
                        gamePvE.click = 0;
                        gamePvE.stadia = false;
                        gamePvE.GamePoleFight.pole[i, j] = null;
                        gamePvE.GamePole.pole[i, j] = null;
                        gamePvE.lim1 = 4;
                        gamePvE.lim2 = 3;
                        gamePvE.lim3 = 2;
                        gamePvE.lim4 = 1;
                        gamePvE.faseBattle.Hide();
                        gamePvE.picPanelPvE.Show();
                        gamePvE.shipPanelPvE.Show();

                    }
                    else
                    {
                        gamePvP.click = 0;
                        gamePvP.GamePoleFight.pole[i, j] = null;
                        gamePvP.stadia = false;
                        gamePvP.GamePole.pole[i, j] = null;
                        gamePvP.lim1 = 4;
                        gamePvP.lim2 = 3;
                        gamePvP.lim3 = 2;
                        gamePvP.lim4 = 1;
                        gamePvP.faseBattle.Hide();
                        gamePvP.picPanelPvP.Show();
                        gamePvP.shipPanelPvP.Show();
                        gamePvP.butHod.Hide();
                    }
                }
            }
           

        }
    }
}
