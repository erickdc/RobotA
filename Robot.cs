using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public enum Direccion
    {
        Arriba,
        Derecha,
        Abajo,
        Izquierda
        
    };
    class Robot:Celda
    {
        public  Direccion Direccion;
        
        public Robot(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
            Direccion = Direccion.Arriba;
        }

        public Robot(Vector2 posicones)
        {
            this.PosX = posicones.X;
            this.PosY = posicones.Y;
            Direccion = Direccion.Arriba;
        }

    }
}
