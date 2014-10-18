using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Robot
{
    class ControladorJuego
    {
        public static ControladorJuego Instance;
        public Tablero Tablero;
        public Robot Robot;
        private FabricaObstaculo _fabricaObstaculo;
        private List<Obstaculo> Obstaculos; 
        public ListaComandos ListaDeComandos;
        public ControladorJuego()
        {
            Instance = this;
            ListaDeComandos = new ListaComandos(); 
            Obstaculos = new List<Obstaculo>();
            _fabricaObstaculo = new FabricaObstaculo();
            InicializarTablero();
           
        }

        public void InicializarTablero()
        {
            Tablero = new Tablero();
            Vector2 posiciones = HerramientasJuego.ObtenerPosicionAleatoria(Tablero.Instance.DimensionX, Tablero.Instance.DimensionY);
            Robot = new Robot(posiciones);

            Tablero.TableroCelda[posiciones.X, posiciones.Y] = Robot;
            InicializarObstaculos();


        }

        private void InicializarObstaculos()
        {
            
            Obstaculos= _fabricaObstaculo.CrearVarios(HerramientasJuego.CalcularCantidadObstaculos());
            for (int i = 0; i < Obstaculos.Count; i++)
            {
                
                var obstaculo = Obstaculos.ElementAt(i);
                var posiciones = obstaculo.DevolverPosiciones();
                Tablero.TableroCelda[posiciones.X, posiciones.Y ]= obstaculo;
            }
        }

        
    }
}
