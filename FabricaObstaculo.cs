using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class FabricaObstaculo
    {


        public FabricaObstaculo() { }

        public Obstaculo Crear()
        {
            Vector2 posiciones;
            do
            {
                posiciones = HerramientasJuego.ObtenerPosicionAleatoria(Tablero.Instance.DimensionX,Tablero.Instance.DimensionY);
            } while (Tablero.Instance.TableroCelda[posiciones.X, posiciones.Y] != null );
             return (new Obstaculo(posiciones));
           
        }

        public List<Obstaculo> CrearVarios(int cantidad)
        {
            List<Obstaculo> listaObstaculos = new List<Obstaculo>();
            for(int i = 0  ; i<cantidad;i++)
                listaObstaculos.Add(Crear());
            return listaObstaculos;

        }
    }
}
