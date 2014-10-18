using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Movimiento
    {
        public static int LimiteMinX = 0;
        public static int LimiteMaxX = 7;
        public static int LimiteMinY = 0;
        public static int LimiteMaxY = 7;
        public static Vector2 IrAdelante(int posX, int posY, Direccion dir)
        {
            int posXT = posX;
            int posYT = posY; 

            switch (dir)
            {
                case Direccion.Izquierda:
                    posYT--;
                    break;
               case Direccion.Derecha:
                    posYT++;
                    break;
                case Direccion.Arriba:
                    posXT--;
                    break;
                default:
                    posXT++;
                    break;
            }
            return EfectoPacman(new Vector2(posXT, posYT));

        }

        public static Vector2 IrAtras(int posX, int posY, Direccion dir)
        {
            int posXT = posX;
            int posYT = posY;

            switch (dir)
            {
                case Direccion.Izquierda:
                    posYT++;
                    break;
                case Direccion.Derecha:
                    posYT--;
                    break;
                case Direccion.Arriba:
                    posXT++;
                    break;
                default:
                    posXT--;
                    break;
            }
            return EfectoPacman(new Vector2(posXT, posYT));
        }

        public static Direccion RotarIzquierda(Direccion dir)
        {
            switch (dir)
            {
                case Direccion.Arriba:
                    return Direccion.Izquierda;
                case Direccion.Izquierda:
                    return Direccion.Abajo;
                case Direccion.Abajo:
                    return Direccion.Derecha;
                default:
                    return Direccion.Arriba;
            }
        }

        public static Direccion RotarDerecha(Direccion dir)
        {
            switch (dir)
            {
                case Direccion.Arriba:
                    return Direccion.Derecha;
                case Direccion.Derecha:
                    return Direccion.Abajo;
                case Direccion.Abajo:
                    return Direccion.Izquierda;
                default:
                    return Direccion.Arriba;
            }
        }

        public bool ValidarMovimiento(int posX, int posY)
        {
            if (Tablero.Instance.TableroCelda[posX, posY] == null)
                return true;
            return false;
        }

        public static Vector2 EfectoPacman(Vector2 posiciones)
        {
            if (posiciones.X < LimiteMinX)
                posiciones.X = LimiteMaxX;
            else if(posiciones.X >LimiteMaxX)
                posiciones.X = LimiteMinX;
            if (posiciones.Y < LimiteMinY)
                posiciones.Y= LimiteMaxY;
            else if (posiciones.Y > LimiteMaxY)
                posiciones.Y = LimiteMinY;

            return posiciones;
        }

        
    }
}
