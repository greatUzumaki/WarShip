using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShip
{
    class Paluba
    {
        int x, y;
        IMnogoPalub mnogo;
        public bool DorL;

        public Paluba(int x,int y,IMnogoPalub boss)
        {
            this.x = x;
            this.y = y;
            mnogo = boss;
            DorL = true;
        }

        public void Death(int x,int y)
        {
           if(this.x == x && this.y == y)
            {
                DorL = false;
            }
        }

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }


    }
}
