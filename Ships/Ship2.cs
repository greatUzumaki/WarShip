using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShip
{
    class Ship2 : IGameObject, IMnogoPalub
    {
       // int x, y;
        List<Paluba> palubas;
        Image image = Image.FromFile(@"img\\ship.png");
        public Ship2(int x1,int y1, int x2,int y2)
        {
            palubas = new List<Paluba>();
            palubas.Add(new Paluba(x1,y1,this));
            palubas.Add(new Paluba(x2, y2, this));
        }
        public int [] X { get { int[] x = new int[2]; x[0] = palubas[0].X; x[1] = palubas[1].X; return x; } set { palubas[0].X = value[0]; palubas[1].X = value[1]; } }
        public int [] Y { get { int[] y = new int[2]; y[0] = palubas[0].Y; y[1] = palubas[1].Y; return y; } set { palubas[0].Y = value[0]; palubas[1].Y = value[1]; } }
        public Image ShipImg { get => image; set => image = value; }

        public bool Death(int x, int y)
        {
            for(int i = 0; i < palubas.Count; i++)
            {
                palubas[i].Death(x, y);
            }
            for(int i = 0; i < palubas.Count; i++)
            {
                if (palubas[i].DorL == true)
                {
                    return false;
                }
            }
            return true;
        } 

        public List<Paluba> SpisokPalub()
        {
            return palubas;
        }
    }
}
