using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WarShip
{
    interface IGameObject
    {
        int [] X { get; set; }
        int [] Y { get; set; }

       Image ShipImg { get; set; }

        bool Death(int x , int y);
    }
}
