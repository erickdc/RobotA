using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public enum Comandos
    {
        Adelante,
        VoltearDerecha,
        Atras,
        VoltearIzquierda
    };

    public class ListaComandos
    {
        public List<Comandos> ListaDeComandosEjecutar;

       
     

        public ListaComandos()
        {
            this.ListaDeComandosEjecutar = new List<Comandos>();
        }

        public void LimpiarLista()
        {
            ListaDeComandosEjecutar.Clear();
        }

        public void Agregar(Comandos comando)
        {
            ListaDeComandosEjecutar.Add(comando);
            
        }

        public void Ejecutar()
        {
            for (int i = 0; i < ListaDeComandosEjecutar.Count; i++)
            {
                Vector2 posiciones = ControladorJuego.Instance.Robot.DevolverPosiciones();
                Direccion dir = ControladorJuego.Instance.Robot.Direccion;
                bool esMoviemiento = false;
                switch (ListaDeComandosEjecutar[i])
                {
                    case Comandos.Adelante:
                        posiciones=Movimiento.IrAdelante(ControladorJuego.Instance.Robot.PosX, ControladorJuego.Instance.Robot.PosY,
                             dir);
                        esMoviemiento = true;
                        break;
                    case Comandos.Atras:
                        posiciones=Movimiento.IrAtras(ControladorJuego.Instance.Robot.PosX, ControladorJuego.Instance.Robot.PosY,
                            dir);
                        esMoviemiento = true;
                        break;
                    case Comandos.VoltearDerecha:
                        dir = Movimiento.RotarDerecha(dir);
                        break;
                    default:
                        dir = Movimiento.RotarIzquierda(dir);
                        break;
                }
                if (Tablero.Instance.TableroCelda[posiciones.X, posiciones.Y] is Obstaculo) break;
                Moverse(posiciones,dir,esMoviemiento) ;

            }
           
        }

        private void Moverse(Vector2 posiciones, Direccion dir, bool esMovimiento)
        {
             
            ControladorJuego.Instance.Tablero.TableroCelda[posiciones.X, posiciones.Y] =
                ControladorJuego.Instance.Robot;
             if(esMovimiento)
                ControladorJuego.Instance.Tablero.TableroCelda[ControladorJuego.Instance.Robot.PosX,
                ControladorJuego.Instance.Robot.PosY] = new Celda();
            ControladorJuego.Instance.Robot.ColocarPosicion(posiciones);
            ControladorJuego.Instance.Robot.Direccion = dir;
        }


        public void Eliminar(int indice)
        {
            ListaDeComandosEjecutar.RemoveAt(indice);
        }
    }
}
