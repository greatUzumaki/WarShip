using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShip
{
    class Pole
    {

      public IGameObject[,] pole = new IGameObject[10, 10];

        bool Player;

        public void SetShip(int x, int y, ShipName name)
        {
            if (x >= 0 && x < 10 && y >= 0 && y < 10 && name.Equals(ShipName.Ship1))
            {
                pole[x, y] = new Ship1();
            }
        }

        public void SetShip(int x1, int y1, int x2, int y2, ShipName name)
        {
            if ((Math.Abs(x1 - x2) == 1 && Math.Abs(y2 - y1) == 0) || (Math.Abs(x1 - x2) == 0 && Math.Abs(y2 - y1) == 1))
            {
                Ship2 s2 = new Ship2(x1, y1, x2, y2);
                pole[x1, y1] = s2;
                pole[x2, y2] = s2;
            }
        }
       

        public void SetShip(int x1, int y1, int x2, int y2, int x3, int y3, ShipName name)
        {
            if((Math.Abs(x1-x2) == 1 && Math.Abs(y2-y1) == 0) || (Math.Abs(x1-x2) == 0 && Math.Abs(y2-y1) == 1))
            {
                if ((Math.Abs(x3 - x2) == 1 && Math.Abs(y2 - y3) == 0) || (Math.Abs(x2 - x3) == 0 && Math.Abs(y3 - y2) == 1))
                {
                    Ship3 s3 = new Ship3(x1, y1, x2, y2, x3, y3);
                    pole[x1, y1] = s3;
                    pole[x2, y2] = s3;
                    pole[x3, y3] = s3;
                }
            }
        }
        public void SetShip(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, ShipName name)
        {
            if ((Math.Abs(x1 - x2) == 1 && Math.Abs(y2 - y1) == 0) || (Math.Abs(x1 - x2) == 0 && Math.Abs(y2 - y1) == 1))
            {
                if ((Math.Abs(x3 - x2) == 1 && Math.Abs(y2 - y3) == 0) || (Math.Abs(x2 - x3) == 0 && Math.Abs(y3 - y2) == 1))
                {
                    if ((Math.Abs(x3 - x4) == 1 && Math.Abs(y3 - y4) == 0) || (Math.Abs(x3 - x4) == 0 && Math.Abs(y3 - y4) == 1))
                    {
                        Ship4 s4 = new Ship4(x1, y1, x2, y2, x3, y3, x4, y4);
                        pole[x1, y1] = s4;
                        pole[x2, y2] = s4;
                        pole[x3, y3] = s4;
                        pole[x4, y4] = s4;
                    }
                }
            }
        }

        public void Attack(int x, int y, bool Player)
        {
            if(pole[x,y] != null)
            {
                pole[x, y].Death(x,y);
            }
        }

    }
}
