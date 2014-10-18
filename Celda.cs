using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Celda
    {
        public int PosX;
        public int PosY;

        public Vector2 DevolverPosiciones()
        {
            return new Vector2(this.PosX,this.PosY);
        }

        public void ColocarPosicion(Vector2 posicion)
        {
            this.PosX = posicion.X;
            this.PosY = posicion.Y;
        }

    }
}
