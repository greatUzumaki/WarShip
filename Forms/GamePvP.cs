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

    public partial class GamePvP : Form
    
    {
        private bool win;
        public bool Win 
        {
            get
            {
                return win;
            }
            set
            {
                win = value;
            }
        }
        public int deathCount , deathCount2;
        public int click;
        public bool switchHod;
        public bool hod;
        public bool stadia;
        public int lim1, lim2, lim3, lim4, lim1p, lim2p, lim3p, lim4p;
        private Graphics g;
        Image pole = Image.FromFile(@"img\\pole.png");

        private Pole gamePole;
        private Pole gamePoleFight;
        ShipName shipname;
        List<int> x1;
        List<int> y1;

        internal Pole GamePole { get => gamePole; set => gamePole = value; }
        internal Pole GamePoleFight { get => gamePoleFight; set => gamePoleFight = value; }

        public GamePvP()
        {
            click = 0;
            deathCount = 0;
            deathCount2 = 0;
            switchHod = false;
            hod = true;
            GamePoleFight = new Pole();
            stadia = false;
            x1 = new List<int>();
            y1 = new List<int>();
            GamePole = new Pole();
            InitializeComponent();
            g = this.CreateGraphics();
            lim1 = 4;
            lim1p = 4;
            lim2 = 3;
            lim2p = 3;
            lim3 = 2;
            lim3p = 2;
            lim4 = 1;
            lim4p = 1;
            butReady.Hide();
            butHod.Hide();
            faseBattle.Hide();
        }

        private void Check()
        {
            if (hod)
            {
                if (lim1 == 0 && lim2 == 0 && lim3 == 0 && lim4 == 0)
                    butReady.Show();
            } else
            {
                if (lim1p == 0 && lim2p == 0 && lim3p == 0 && lim4p == 0)
                    butReady.Show();
            }
        }

        void paint()
        {
            g.DrawImage(pole, new Rectangle(0, 0, 1000, 550));
            for (int  i = 0; i<10; i++)
            {
                for (int j = 0; j<10; j++)
                {
                    if (hod) 
                    {
                        if (GamePole.pole[i, j] != null)
                        {
                            g.DrawImage(GamePole.pole[i, j].ShipImg, new Rectangle(i * 40 + 47, j * 41 + 125, 38, 35));
                        }
                        if (GamePoleFight.pole[i, j] != null)
                        {
                            if (GamePoleFight.pole[i, j].GetType() == new Miss().GetType() || GamePoleFight.pole[i, j].GetType() == new Death().GetType())
                                g.DrawImage(GamePoleFight.pole[i, j].ShipImg, new Rectangle(i * 40 + 570, j * 41 + 125, 38, 35));
                        }
                    }else
                    {
                        if (GamePoleFight.pole[i, j] != null)
                        {
                            g.DrawImage(GamePoleFight.pole[i, j].ShipImg, new Rectangle(i * 40 + 47, j * 41 + 125, 38, 35));
                        }
                        if (GamePole.pole[i, j] != null)
                        {
                            if (GamePole.pole[i, j].GetType() == new Miss().GetType() || GamePole.pole[i, j].GetType() == new Death().GetType())
                                g.DrawImage(GamePole.pole[i, j].ShipImg, new Rectangle(i * 40 + 570, j * 41 + 125, 38, 35));
                        }
                    }
                }
            }
            if(click < 2)
            Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GamePvP_Load(object sender, EventArgs e)
        {
        
        }

        private void GamePvP_Paint(object sender, PaintEventArgs e)
        {
            paint();
        }

         void GamePvP_MouseClick(object sender, MouseEventArgs e)
        {

            int x;
            int y;
            x = (e.X - 43) / 40;
            y = (e.Y - 119) / 41;
            this.Text = "Координаты клетки : " + x + " " + y + " ";
            if (!stadia && hod)
            {
              
                if (e.X > 42 && e.X < 447 && e.Y > 117 && e.Y < 533)
                if (GamePole.pole[x, y] == null)
                {
                    switch (shipname)
                    {
                        case ShipName.Ship1:
                            if (lim1 > 0)
                                if (x == 0 && y == 0)
                                {
                                    if (GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (x == 0 && y > 0 && y < 9)
                                {
                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (y == 9 && x == 0)
                                {
                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (y == 0 && x > 0 && x < 9)
                                {
                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (y == 9 && x == 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (x == 9 && y > 0 && y < 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                    && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (x == 9 && y == 0)
                                {
                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                        && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (y == 9 && x > 0 && x < 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        lim1 = lim1 - 1;
                                        GamePole.SetShip(x, y, ShipName.Ship1);
                                    }
                                }
                                else if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                  && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                  && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                  && GamePole?.pole[x + 1, y - 1] == null && GamePole?.pole[x - 1, y + 1] == null)
                                {
                                    lim1 = lim1 - 1;
                                    GamePole.SetShip(x, y, ShipName.Ship1);
                                }

                            break;

                        case ShipName.Ship2:
                            if (lim2 > 0)
                                if (x == 0 && y == 0)
                                {
                                    if (GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 0 && y > 0 && y < 9)
                                {
                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 0)
                                {
                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 0 && x > 0 && x < 9)
                                {
                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y > 0 && y < 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                    && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y == 0)
                                {
                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                        && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x > 0 && x < 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                  && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                  && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                  && GamePole?.pole[x + 1, y - 1] == null && GamePole?.pole[x - 1, y + 1] == null)
                                {
                                    x1.Add(x);
                                    y1.Add(y);
                                }
                            if (x1.Count > 1)
                            {
                                if (x1.ElementAt(0) != x1.ElementAt(1) || y1.ElementAt(0) != y1.ElementAt(1))
                                {
                                    lim2 = lim2 - 1;
                                    GamePole.SetShip(x1.ElementAt(0), y1.ElementAt(0), x1.ElementAt(1), y1.ElementAt(1), ShipName.Ship2);
                                    x1 = new List<int>();
                                    y1 = new List<int>();
                                }
                                else
                                {
                                    if (x1.Count > 2 && y1.Count > 2)
                                    {
                                        x1 = new List<int>();
                                        y1 = new List<int>();
                                    }
                                }
                            }

                            break;

                        case ShipName.Ship3:
                            if (lim3 > 0)
                                if (x == 0 && y == 0)
                                {
                                    if (GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 0 && y > 0 && y < 9)
                                {
                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 0)
                                {
                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 0 && x > 0 && x < 9)
                                {
                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y > 0 && y < 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                    && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y == 0)
                                {
                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                        && GamePole?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x > 0 && x < 9)
                                {
                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y] == null
                                    && GamePole?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                  && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                  && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                  && GamePole?.pole[x + 1, y - 1] == null && GamePole?.pole[x - 1, y + 1] == null)
                                {
                                    x1.Add(x);
                                    y1.Add(y);
                                }
                            if (x1.Count > 1)
                                if (x1.ElementAt(0) != x1.ElementAt(1) || y1.ElementAt(0) != y1.ElementAt(1))
                                {
                                    if (x1.Count > 2)
                                        if (x1.ElementAt(1) != x1.ElementAt(2) || y1.ElementAt(1) != y1.ElementAt(2))
                                        {
                                            if (x1.ElementAt(0) != x1.ElementAt(2) || y1.ElementAt(0) != y1.ElementAt(2))
                                            {
                                                lim3 = lim3 - 1;
                                                GamePole.SetShip(x1.ElementAt(0), y1.ElementAt(0),
                                        x1.ElementAt(1), y1.ElementAt(1), x1.ElementAt(2), y1.ElementAt(2), ShipName.Ship3);
                                                x1 = new List<int>();
                                                y1 = new List<int>();
                                            }
                                            else
                                            {
                                                x1 = new List<int>();
                                                y1 = new List<int>();
                                            }

                                        }
                                }
                                else
                                {
                                    if (x1.Count > 3 && y1.Count > 3)
                                    {
                                        x1 = new List<int>();
                                        y1 = new List<int>();
                                    }
                                }
                            break;

                        case ShipName.Ship4:
                            if (lim4 > 0)
                                if (x1.Count == 0)
                                {
                                    if (y1.Count == 0)
                                    {
                                        if (x == 0 && y == 0)
                                        {
                                            if (GamePole?.pole[x + 1, y + 1] == null
                                            && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (x == 0 && y > 0 && y < 9)
                                        {
                                            if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y + 1] == null
                                            && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                            && GamePole?.pole[x + 1, y - 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 9 && x == 0)
                                        {
                                            if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y] == null
                                            && GamePole?.pole[x + 1, y - 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 0 && x > 0 && x < 9)
                                        {
                                            if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                            && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                            && GamePole?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 9 && x == 9)
                                        {
                                            if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                            && GamePole?.pole[x - 1, y] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (x == 9 && y > 0 && y < 9)
                                        {
                                            if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                            && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                            && GamePole?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (x == 9 && y == 0)
                                        {
                                            if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                                && GamePole?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 9 && x > 0 && x < 9)
                                        {
                                            if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                            && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y] == null
                                            && GamePole?.pole[x + 1, y - 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                          && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                          && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                          && GamePole?.pole[x + 1, y - 1] == null && GamePole?.pole[x - 1, y + 1] == null)
                                        {
                                            x1.Add(x);
                                            y1.Add(y);
                                        }
                                    }
                                }
                            if (x1.Count > 0)
                                if (x1.ElementAt(0) != (e.X - 43) / 40 || y1.ElementAt(0) != (e.Y - 119) / 41)
                                {
                                    if (x1.Count == 1)
                                    {
                                        if (y1.Count == 1)
                                        {
                                            if (x == 0 && y == 0)
                                            {
                                                if (GamePole?.pole[x + 1, y + 1] == null
                                                && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (x == 0 && y > 0 && y < 9)
                                            {
                                                if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y + 1] == null
                                                && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                                && GamePole?.pole[x + 1, y - 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 9 && x == 0)
                                            {
                                                if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y] == null
                                                && GamePole?.pole[x + 1, y - 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 0 && x > 0 && x < 9)
                                            {
                                                if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                                && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                                && GamePole?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 9 && x == 9)
                                            {
                                                if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                && GamePole?.pole[x - 1, y] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (x == 9 && y > 0 && y < 9)
                                            {
                                                if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                                && GamePole?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (x == 9 && y == 0)
                                            {
                                                if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                                    && GamePole?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 9 && x > 0 && x < 9)
                                            {
                                                if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y] == null
                                                && GamePole?.pole[x + 1, y - 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                              && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                              && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                              && GamePole?.pole[x + 1, y - 1] == null && GamePole?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                    }
                                    if (x1.ElementAt(1) != x || y1.ElementAt(1) != y)
                                    {
                                        if (x1.Count == 2)
                                        {
                                            if (y1.Count == 2)
                                            {
                                                if (x == 0 && y == 0)
                                                {
                                                    if (GamePole?.pole[x + 1, y + 1] == null
                                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (x == 0 && y > 0 && y < 9)
                                                {
                                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y + 1] == null
                                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                                    && GamePole?.pole[x + 1, y - 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 9 && x == 0)
                                                {
                                                    if (GamePole?.pole[x, y - 1] == null && GamePole?.pole[x + 1, y] == null
                                                    && GamePole?.pole[x + 1, y - 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 0 && x > 0 && x < 9)
                                                {
                                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                                    && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                                    && GamePole?.pole[x - 1, y + 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 9 && x == 9)
                                                {
                                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                    && GamePole?.pole[x - 1, y] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (x == 9 && y > 0 && y < 9)
                                                {
                                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                                    && GamePole?.pole[x - 1, y + 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (x == 9 && y == 0)
                                                {
                                                    if (GamePole?.pole[x - 1, y] == null && GamePole?.pole[x, y + 1] == null
                                                        && GamePole?.pole[x - 1, y + 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 9 && x > 0 && x < 9)
                                                {
                                                    if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                    && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y] == null
                                                    && GamePole?.pole[x + 1, y - 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (GamePole?.pole[x - 1, y - 1] == null && GamePole?.pole[x, y - 1] == null
                                                  && GamePole?.pole[x - 1, y] == null && GamePole?.pole[x + 1, y + 1] == null
                                                  && GamePole?.pole[x, y + 1] == null && GamePole?.pole[x + 1, y] == null
                                                  && GamePole?.pole[x + 1, y - 1] == null && GamePole?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                        }
                                        if (x1.Count > 1)
                                            if (x1.ElementAt(2) != x || y1.ElementAt(2) != y)
                                            {
                                                lim4 = lim4 - 1;
                                                GamePole.SetShip(x1.ElementAt(0), y1.ElementAt(0), x1.ElementAt(1), y1.ElementAt(1), x1.ElementAt(2), y1.ElementAt(2), x, y, ShipName.Ship4);
                                                x1 = new List<int>();
                                                y1 = new List<int>();
                                            }

                                    }
                                }
                                else
                                {
                                    if (x1.Count > 4 && y1.Count > 4)
                                    {
                                        x1 = new List<int>();
                                        y1 = new List<int>();
                                    }
                                }
                            break;
                    }
                }
            }
            else if(!stadia && !hod)
            {
                if (e.X > 42 && e.X < 447 && e.Y > 117 && e.Y < 533)
                    if (GamePoleFight.pole[x, y] == null)
                {
                    switch (shipname)
                    {
                        case ShipName.Ship1:
                            if (lim1p > 0)
                                if (x == 0 && y == 0)
                                {
                                    if (GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x,y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (x == 0 && y > 0 && y < 9)
                                {
                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (y == 9 && x == 0)
                                {
                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (y == 0 && x > 0 && x < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (y == 9 && x == 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (x == 9 && y > 0 && y < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (x == 9 && y == 0)
                                {
                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                        && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (y == 9 && x > 0 && x < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        lim1p = lim1p - 1;
                                        GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                        GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    }
                                }
                                else if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                  && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                  && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                  && GamePoleFight?.pole[x + 1, y - 1] == null && GamePoleFight?.pole[x - 1, y + 1] == null)
                                {
                                    lim1p = lim1p - 1;
                                    GamePoleFight.SetShip(x, y, ShipName.Ship1);
                                    GamePoleFight.pole[x, y].ShipImg = Image.FromFile(@"img\\shipr.png");
                                }

                            break;

                        case ShipName.Ship2:
                            if (lim2p > 0)
                                if (x == 0 && y == 0)
                                {
                                    if (GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 0 && y > 0 && y < 9)
                                {
                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 0)
                                {
                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 0 && x > 0 && x < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y > 0 && y < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y == 0)
                                {
                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                        && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x > 0 && x < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                  && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                  && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                  && GamePoleFight?.pole[x + 1, y - 1] == null && GamePoleFight?.pole[x - 1, y + 1] == null)
                                {
                                    x1.Add(x);
                                    y1.Add(y);
                                }
                            if (x1.Count > 1)
                            {
                                if (x1.ElementAt(0) != x1.ElementAt(1) || y1.ElementAt(0) != y1.ElementAt(1))
                                {
                                    lim2p = lim2p - 1;
                                    GamePoleFight.SetShip(x1.ElementAt(0), y1.ElementAt(0), x1.ElementAt(1), y1.ElementAt(1), ShipName.Ship2);
                                    GamePoleFight.pole[x1.ElementAt(0), y1.ElementAt(0)].ShipImg = Image.FromFile(@"img\\shipr.png");
                                    x1 = new List<int>();
                                    y1 = new List<int>();
                                }
                                else
                                {
                                    if (x1.Count > 2 && y1.Count > 2)
                                    {
                                        x1 = new List<int>();
                                        y1 = new List<int>();
                                    }
                                }
                            }

                            break;

                        case ShipName.Ship3:
                            if (lim3p > 0)
                                if (x == 0 && y == 0)
                                {
                                    if (GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 0 && y > 0 && y < 9)
                                {
                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 0)
                                {
                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 0 && x > 0 && x < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x == 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y > 0 && y < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (x == 9 && y == 0)
                                {
                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                        && GamePoleFight?.pole[x - 1, y + 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (y == 9 && x > 0 && x < 9)
                                {
                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y] == null
                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                    {
                                        x1.Add(x);
                                        y1.Add(y);
                                    }
                                }
                                else if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                  && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                  && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                  && GamePoleFight?.pole[x + 1, y - 1] == null && GamePoleFight?.pole[x - 1, y + 1] == null)
                                {
                                    x1.Add(x);
                                    y1.Add(y);
                                }
                            if (x1.Count > 1)
                                if (x1.ElementAt(0) != x1.ElementAt(1) || y1.ElementAt(0) != y1.ElementAt(1))
                                {
                                    if (x1.Count > 2)
                                        if (x1.ElementAt(1) != x1.ElementAt(2) || y1.ElementAt(1) != y1.ElementAt(2))
                                        {
                                            if (x1.ElementAt(0) != x1.ElementAt(2) || y1.ElementAt(0) != y1.ElementAt(2))
                                            {
                                                lim3p = lim3p - 1;
                                                GamePoleFight.SetShip(x1.ElementAt(0), y1.ElementAt(0),
                                        x1.ElementAt(1), y1.ElementAt(1), x1.ElementAt(2), y1.ElementAt(2), ShipName.Ship3);
                                                GamePoleFight.pole[x1.ElementAt(0), y1.ElementAt(0)].ShipImg = Image.FromFile(@"img\\shipr.png");


                                                x1 = new List<int>();
                                                y1 = new List<int>();
                                            }
                                            else
                                            {
                                                x1 = new List<int>();
                                                y1 = new List<int>();
                                            }

                                        }
                                }
                                else
                                {
                                    if (x1.Count > 3 && y1.Count > 3)
                                    {
                                        x1 = new List<int>();
                                        y1 = new List<int>();
                                    }
                                }
                            break;

                        case ShipName.Ship4:
                            if (lim4p > 0)
                                if (x1.Count == 0)
                                {
                                    if (y1.Count == 0)
                                    {
                                        if (x == 0 && y == 0)
                                        {
                                            if (GamePoleFight?.pole[x + 1, y + 1] == null
                                            && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (x == 0 && y > 0 && y < 9)
                                        {
                                            if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                            && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                            && GamePoleFight?.pole[x + 1, y - 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 9 && x == 0)
                                        {
                                            if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                            && GamePoleFight?.pole[x + 1, y - 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 0 && x > 0 && x < 9)
                                        {
                                            if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                            && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                            && GamePoleFight?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 9 && x == 9)
                                        {
                                            if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                            && GamePoleFight?.pole[x - 1, y] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (x == 9 && y > 0 && y < 9)
                                        {
                                            if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                            && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                            && GamePoleFight?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (x == 9 && y == 0)
                                        {
                                            if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                                && GamePoleFight?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (y == 9 && x > 0 && x < 9)
                                        {
                                            if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                            && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y] == null
                                            && GamePoleFight?.pole[x + 1, y - 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                        else if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                          && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                          && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                          && GamePoleFight?.pole[x + 1, y - 1] == null && GamePoleFight?.pole[x - 1, y + 1] == null)
                                        {
                                            x1.Add(x);
                                            y1.Add(y);
                                        }
                                    }
                                }
                            if (x1.Count > 0)
                                if (x1.ElementAt(0) != (e.X - 43) / 40 || y1.ElementAt(0) != (e.Y - 119) / 41)
                                {
                                    if (x1.Count == 1)
                                    {
                                        if (y1.Count == 1)
                                        {
                                            if (x == 0 && y == 0)
                                            {
                                                if (GamePoleFight?.pole[x + 1, y + 1] == null
                                                && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (x == 0 && y > 0 && y < 9)
                                            {
                                                if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                                && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                && GamePoleFight?.pole[x + 1, y - 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 9 && x == 0)
                                            {
                                                if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                && GamePoleFight?.pole[x + 1, y - 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 0 && x > 0 && x < 9)
                                            {
                                                if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                                && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 9 && x == 9)
                                            {
                                                if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                && GamePoleFight?.pole[x - 1, y] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (x == 9 && y > 0 && y < 9)
                                            {
                                                if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                                && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (x == 9 && y == 0)
                                            {
                                                if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (y == 9 && x > 0 && x < 9)
                                            {
                                                if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y] == null
                                                && GamePoleFight?.pole[x + 1, y - 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                            else if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                              && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                              && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                              && GamePoleFight?.pole[x + 1, y - 1] == null && GamePoleFight?.pole[x - 1, y + 1] == null)
                                            {
                                                x1.Add(x);
                                                y1.Add(y);
                                            }
                                        }
                                    }
                                    if (x1.ElementAt(1) != x || y1.ElementAt(1) != y)
                                    {
                                        if (x1.Count == 2)
                                        {
                                            if (y1.Count == 2)
                                            {
                                                if (x == 0 && y == 0)
                                                {
                                                    if (GamePoleFight?.pole[x + 1, y + 1] == null
                                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (x == 0 && y > 0 && y < 9)
                                                {
                                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 9 && x == 0)
                                                {
                                                    if (GamePoleFight?.pole[x, y - 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 0 && x > 0 && x < 9)
                                                {
                                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                                    && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 9 && x == 9)
                                                {
                                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                    && GamePoleFight?.pole[x - 1, y] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (x == 9 && y > 0 && y < 9)
                                                {
                                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                                    && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (x == 9 && y == 0)
                                                {
                                                    if (GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x, y + 1] == null
                                                        && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (y == 9 && x > 0 && x < 9)
                                                {
                                                    if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                    && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y] == null
                                                    && GamePoleFight?.pole[x + 1, y - 1] == null)
                                                    {
                                                        x1.Add(x);
                                                        y1.Add(y);
                                                    }
                                                }
                                                else if (GamePoleFight?.pole[x - 1, y - 1] == null && GamePoleFight?.pole[x, y - 1] == null
                                                  && GamePoleFight?.pole[x - 1, y] == null && GamePoleFight?.pole[x + 1, y + 1] == null
                                                  && GamePoleFight?.pole[x, y + 1] == null && GamePoleFight?.pole[x + 1, y] == null
                                                  && GamePoleFight?.pole[x + 1, y - 1] == null && GamePoleFight?.pole[x - 1, y + 1] == null)
                                                {
                                                    x1.Add(x);
                                                    y1.Add(y);
                                                }
                                            }
                                        }
                                        if (x1.Count > 1)
                                            if (x1.ElementAt(2) != x || y1.ElementAt(2) != y)
                                            {
                                                lim4p = lim4p - 1;
                                                GamePoleFight.SetShip(x1.ElementAt(0), y1.ElementAt(0), x1.ElementAt(1), y1.ElementAt(1), x1.ElementAt(2), y1.ElementAt(2), x, y, ShipName.Ship4);
                                                GamePoleFight.pole[x1.ElementAt(0), y1.ElementAt(0)].ShipImg = Image.FromFile(@"img\\shipr.png");
                                                x1 = new List<int>();
                                                y1 = new List<int>();
                                            }

                                    }
                                }
                                else
                                {
                                    if (x1.Count > 4 && y1.Count > 4)
                                    {
                                        x1 = new List<int>();
                                        y1 = new List<int>();
                                    }
                                }
                            break;
                    }
                }
            }
            else 
            {
               
                x = (e.X - 570) / 40;
                y = (e.Y - 119) / 41;
                this.Text = "Координаты клетки : " + x + " " + y + " "; ;
                if (hod && switchHod == false)
                {
                    if (e.X > 568 && e.X < 972 && e.Y > 117 && e.Y < 533)
                    {
                        if (GamePoleFight.pole[x, y] == null)
                        {
                            GamePoleFight.pole[x, y] = new Miss();
                            switchHod = true;
                        }
                        else if (GamePoleFight.pole[x, y].GetType() != new Death().GetType() || GamePoleFight.pole[x, y].GetType() != new Miss().GetType())
                        {
                            GamePoleFight.pole[x, y] = new Death();
                            deathCount = deathCount + 1;

                        }
                    }
                   
                } else if(switchHod == false)
                {
                    if (e.X > 568 && e.X < 972 && e.Y > 117 && e.Y < 533)
                    {
                        if (GamePole.pole[x, y] == null)
                        {
                            GamePole.pole[x, y] = new Miss();
                            switchHod = true;
                        }
                        else if (GamePole.pole[x, y].GetType() != new Death().GetType() && GamePole.pole[x, y].GetType() != new Miss().GetType())
                        {
                            GamePole.pole[x, y] = new Death();
                            deathCount2 = deathCount2 + 1;

                        }
                    }
                    
                }
            }
            paint();
            if (deathCount == 20)
            {
                win = true;
                this.Hide();
                Winner winner = new Winner(this);
                winner.Show();
            }
            else if (deathCount2 == 20)
            {
                win = false;
                this.Hide();
                Winner winner = new Winner(this);
                winner.Show();
            }

        }

        private void GamePvP_FormClosing(object sender, FormClosingEventArgs e)
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

        private void butHod_MouseClick(object sender, MouseEventArgs e)
        {
            if (switchHod == true)
                switchHod = false;
            else switchHod = true;
            if (hod == true)
                hod = false;
            else hod = true;
            paint();
        }

 
        private void restart_MouseClick(object sender, MouseEventArgs e)
        {
            YoN restartbox = new YoN(this);
            restartbox.Show();
        }

        private void pause_MouseClick(object sender, MouseEventArgs e)
        {
            pauseBox p = new pauseBox(this);
            p.Show();
        }

        private void butReady_MouseClick(object sender, MouseEventArgs e)
        {
            click = click + 1;
                if (!hod)
                {
                        stadia = true;
                        hod = true;
                        butReady.Hide();
                        faseBattle.Show();
                        picPanelPvP.Hide();
                        shipPanelPvP.Hide();

                } else
                {
                hod = false;
                butReady.Hide();
                }

                if (stadia == true)
                butHod.Show();
           
        }

        private void butShip1_CheckedChanged(object sender, EventArgs e)
        {
            shipname = ShipName.Ship1;
        }

        private void butShip2_CheckedChanged(object sender, EventArgs e)
        {
            shipname = ShipName.Ship2;
        }

        private void butShip3_CheckedChanged(object sender, EventArgs e)
        {
            shipname = ShipName.Ship3;
        }

        private void butShip4_CheckedChanged(object sender, EventArgs e)
        {
            shipname = ShipName.Ship4;
        }
    }
}
