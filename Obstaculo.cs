using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Obstaculo:Celda
    {
        public Obstaculo(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }

        public Obstaculo(Vector2 posiciones)
        {
            this.PosX = posiciones.X;
            this.PosY = posiciones.Y;
        }
    }
}
