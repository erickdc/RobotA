using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Robot.Properties;

namespace Robot
{
    class HerramientasJuego
    {
        public static int CeldaPorObstaculo = 4;
        private static readonly Random Random = new Random();   
        public static Vector2 ObtenerPosicionAleatoria(int limiteX, int limiteY)
        {


            return new Vector2(Random.Next(0, limiteX), Random.Next(0, limiteY));

        }

        public static int CalcularCantidadObstaculos()
        {
            return (Tablero.Instance.DimensionX * Tablero.Instance.DimensionY) /CeldaPorObstaculo;
        }

        public static Image ObtenerImagenRobotDireccion(Direccion dir)
        {
            switch (dir)
            {
                case Direccion.Abajo:
                    return Resources.Abajo;
                case Direccion.Arriba:
                    return Resources.Arriba;
                case Direccion.Derecha:
                    return Resources.Derecha;
                default:
                    return Resources.Izquierda;
            }
        }
    }
}
