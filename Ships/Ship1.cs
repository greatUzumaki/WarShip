using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShip
{
    public class Ship1 : IGameObject
    {
        int [] x, y;
        Image image = Image.FromFile(@"img\\ship.png");
      

        public int [] X { get { return x; } set { x = value; } }
        public int [] Y { get { return y; }  set { y = value; } }
        public Image ShipImg { get { return image; } set { image = value; } }

        public bool Death(int x, int y)
        {
            return true;
        }
    }

}
