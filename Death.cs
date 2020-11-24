using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShip
{
    class Death : IGameObject
    {
        Image image = Image.FromFile(@"img\\cross.png");
        public int[] X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int[] Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Image ShipImg { get => image; set => image = value; }

        bool IGameObject.Death(int x, int y)
        {
            return false;
        }
    }
}
