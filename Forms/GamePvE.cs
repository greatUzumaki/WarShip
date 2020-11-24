using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WarShip
{

    public partial class GamePvE : Form

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
        public int click;
        Random random;
        public int deathCount, deathCount2;
        public bool hod;
        public bool stadia;
        public int lim1, lim2, lim3, lim4;
        private Graphics g;
        Image pole = Image.FromFile(@"img\\pole.png");
        private Pole gamePole;
        private Pole gamePoleFight;
        ShipName shipname;
        List<int> x1;
        List<int> y1;

        internal Pole GamePole { get => gamePole; set => gamePole = value; }
        internal Pole GamePoleFight { get => gamePoleFight; set => gamePoleFight = value; }

        public GamePvE()
        {
            click = 0;
            random = new Random();
            deathCount = 0;
            deathCount2 = 0;
            hod = true;
            GamePoleFight = new Pole();
            stadia = false;
            x1 = new List<int>();
            y1 = new List<int>();
            GamePole = new Pole();
            InitializeComponent();
            g = this.CreateGraphics();
            lim1 = 4;
            lim2 = 3;
            lim3 = 2;
            lim4 = 1;
            butReady.Hide();
            faseBattle.Hide();
        }

        private void Check()
        {
            if (hod)
            {
                if (lim1 == 0 && lim2 == 0 && lim3 == 0 && lim4 == 0)
                    butReady.Show();
            }
        }
        void paint()
        {
            g.DrawImage(pole, new Rectangle(0, 0, 1000, 550));
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
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
                }
            }
            if (click < 1)
                Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GamePvE_Load(object sender, EventArgs e)
        {

        }

        private void GamePvP_Paint(object sender, PaintEventArgs e)
        {
            paint();
        }

        private void GamePvE_MouseClick(object sender, MouseEventArgs e)
        {

            int x;
            int y;
            x = (e.X - 43) / 40;
            y = (e.Y - 119) / 41;
            this.Text ="Координаты клетки : " + x + " " + y + " ";
            if (!stadia)
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
            else
            {
                x = (e.X - 570) / 40;
                y = (e.Y - 119) / 41;
                if (hod)
                {
                    if (e.X > 568 && e.X < 972 && e.Y > 117 && e.Y < 533)
                    {
                        if (GamePoleFight.pole[x, y] == null)
                        {
                            GamePoleFight.pole[x, y] = new Miss();
                            hod = false;
                            if (hod == false)
                            {
                                int xc, yc;
                                while (true)
                                {
                                    xc = random.Next(0, 9);
                                    yc = random.Next(0, 9);

                                    if (gamePole.pole[xc, yc]?.GetType() != new Death().GetType() && gamePole.pole[xc, yc]?.GetType() != new Miss().GetType())
                                    {
                                        if (gamePole.pole[xc, yc] == null)
                                        {
                                            hod = true;
                                            gamePole.pole[xc, yc] = new Miss();
                                            break;
                                        }
                                        else
                                        {
                                       

                                            gamePole.pole[xc, yc] = new Death();
                                            if (xc != 0 && yc != 0)
                                            {
                                                xc = xc - 1;
                                                yc = yc - 0;
                                                if (gamePole.pole[xc, yc]?.GetType() != new Death().GetType() && gamePole.pole[xc, yc]?.GetType() != new Miss().GetType())
                                                {
                                                    if (gamePole.pole[xc, yc] == null)
                                                    {
                                                        hod = true;
                                                        gamePole.pole[xc, yc] = new Miss();
                                                        break;
                                                    }
                                                    else
                                                    {


                                                        gamePole.pole[xc, yc] = new Death();
                                                        if (xc != 0 && yc != 0)
                                                        {

                                                        }
                                                        deathCount2 = deathCount2 + 1;
                                                    }

                                                }
                                            }
                                            deathCount2 = deathCount2 + 1;
                                        }
                                        paint();
                                    }
                                }
                            }
                        }
                        else if (GamePoleFight.pole[x, y].GetType() != new Death().GetType() && GamePoleFight.pole[x, y].GetType() != new Miss().GetType())
                        {
                            gamePoleFight.pole[x, y] = new Death();
                            deathCount = deathCount + 1;
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

        private void butReady_MouseClick(object sender, MouseEventArgs e)
        {
            click = click + 1;
            if (lim1 == 0 && lim2 == 0 && lim3 == 0 && lim4 == 0)
            {
                if (!stadia)
                {
                    butReady.Hide();
                    faseBattle.Show();
                    picPanelPvE.Hide();
                    shipPanelPvE.Hide();
                    stadia = true;
                    Pole map = new Pole();
                    int rnd = random.Next(1, 6);
                    switch (rnd)
                    {
                        case 1:
                            map.SetShip(0, 0, ShipName.Ship1);
                            map.SetShip(9, 9, ShipName.Ship1);
                            map.SetShip(0, 9, ShipName.Ship1);
                            map.SetShip(9, 0, ShipName.Ship1);
                            map.SetShip(3, 5, 4, 5, ShipName.Ship2);
                            map.SetShip(6, 2, 6, 3, ShipName.Ship2);
                            map.SetShip(0, 4, 0, 5, ShipName.Ship2);
                            map.SetShip(7, 6, 7, 7, 7, 8, ShipName.Ship3);
                            map.SetShip(2, 1, 3, 1, 4, 1, ShipName.Ship3);
                            map.SetShip(2, 9, 3, 9, 4, 9, 5, 9, ShipName.Ship4);
                            GamePoleFight = map;
                            break;

                        case 2:
                            map.SetShip(2, 1, ShipName.Ship1);
                            map.SetShip(5, 4, ShipName.Ship1);
                            map.SetShip(2, 6, ShipName.Ship1);
                            map.SetShip(8, 9, ShipName.Ship1);
                            map.SetShip(8, 5, 8, 4, ShipName.Ship2);
                            map.SetShip(6, 1, 7, 1, ShipName.Ship2);
                            map.SetShip(0, 3, 0, 4, ShipName.Ship2);
                            map.SetShip(0, 9, 1, 9, 2, 9, ShipName.Ship3);
                            map.SetShip(5, 6, 5, 7, 5, 8, ShipName.Ship3);
                            map.SetShip(2, 3, 3, 3, 3, 4, 2, 4, ShipName.Ship4);
                            GamePoleFight = map;
                            break;

                        case 3:
                            map.SetShip(1, 1, ShipName.Ship1);
                            map.SetShip(3, 5, ShipName.Ship1);
                            map.SetShip(6, 8, ShipName.Ship1);
                            map.SetShip(0, 8, ShipName.Ship1);
                            map.SetShip(6, 4, 6, 3, ShipName.Ship2);
                            map.SetShip(2, 7, 2, 8, ShipName.Ship2);
                            map.SetShip(8, 6, 9, 6, ShipName.Ship2);
                            map.SetShip(3, 0, 4, 0, 5, 0, ShipName.Ship3);
                            map.SetShip(0, 3, 1, 3, 2, 3, ShipName.Ship3);
                            map.SetShip(9, 0, 9, 1, 9, 2, 9, 3, ShipName.Ship4);
                            GamePoleFight = map;
                            break;

                        case 4:
                            map.SetShip(6, 9, ShipName.Ship1);
                            map.SetShip(2, 8, ShipName.Ship1);
                            map.SetShip(0, 1, ShipName.Ship1);
                            map.SetShip(7, 1, ShipName.Ship1);
                            map.SetShip(5, 5, 6, 5, ShipName.Ship2);
                            map.SetShip(1, 4, 1, 5, ShipName.Ship2);
                            map.SetShip(9, 0, 9, 1, ShipName.Ship2);
                            map.SetShip(9, 9, 9, 8, 9, 7, ShipName.Ship3);
                            map.SetShip(2, 0, 3, 0, 3, 1, ShipName.Ship3);
                            map.SetShip(4, 3, 5, 3, 6, 3, 7, 3, ShipName.Ship4);
                            GamePoleFight = map;
                            break;

                        case 5:
                            map.SetShip(1, 6, ShipName.Ship1);
                            map.SetShip(4, 3, ShipName.Ship1);
                            map.SetShip(4, 9, ShipName.Ship1);
                            map.SetShip(8, 3, ShipName.Ship1);
                            map.SetShip(6, 7, 6, 8, ShipName.Ship2);
                            map.SetShip(1, 8, 2, 8, ShipName.Ship2);
                            map.SetShip(0, 0, 1, 0, ShipName.Ship2);
                            map.SetShip(9, 6, 9, 7, 9, 8, ShipName.Ship3);
                            map.SetShip(0, 4, 1, 4, 2, 4, ShipName.Ship3);
                            map.SetShip(6, 0, 6, 1, 6, 2, 6, 3, ShipName.Ship4);
                            GamePoleFight = map;
                            break;

                        case 6:
                            map.SetShip(6, 7, ShipName.Ship1);
                            map.SetShip(2, 7, ShipName.Ship1);
                            map.SetShip(0, 4, ShipName.Ship1);
                            map.SetShip(9, 1, ShipName.Ship1);
                            map.SetShip(3, 9, 4, 9, ShipName.Ship2);
                            map.SetShip(1, 0, 1, 1, ShipName.Ship2);
                            map.SetShip(5, 4, 5, 3, ShipName.Ship2);
                            map.SetShip(8, 6, 8, 5, 9, 5, ShipName.Ship3);
                            map.SetShip(3, 0, 4, 0, 5, 0, ShipName.Ship3);
                            map.SetShip(0, 9, 0, 8, 0, 7, 0, 6, ShipName.Ship4);
                            GamePoleFight = map;
                            break;
                    }


                }
            }
        }      

        private void restart_MouseClick(object sender, MouseEventArgs e)
        {
            YoN restartbox = new YoN(this);
            restartbox.Show();
        }

        private void GamePvE_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pause_MouseClick(object sender, MouseEventArgs e)
        {
            pauseBox p = new pauseBox(this);
            p.Show();
        }

        private void butShip4_CheckedChanged(object sender, EventArgs e)
        {
            shipname = ShipName.Ship4;
        }

        private void GamePvE_Paint(object sender, PaintEventArgs e)
        {
            paint();
        }
    }
}
