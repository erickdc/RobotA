using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Robot.Properties;

namespace Robot
{
    class ControladorGrafico
    {
        public ControladorJuego ControladorJuego;
        public Panel PanelJuego,PanelComandos;
        public ListBox LbComandos, LbComandosEjecutar;
       public ControladorGrafico(Panel pJuego, Panel pComandos, ListBox lbComandos, ListBox lbComandosEjecutar)
        {
            PanelJuego = pJuego;
            PanelComandos = pComandos;
            LbComandos = lbComandos;
           LbComandosEjecutar = lbComandosEjecutar;
            ControladorJuego = new ControladorJuego();
           IniciarListaComandos();
        }

       public void DibujarCelda(Vector2 posiciones)
        {
                Image image = Resources.celda_vacia;
                PictureBox pic = new PictureBox();
                pic.Location = new Point(posiciones.X, posiciones.Y);
            
                pic.Image = image;
                pic.Height = image.Height;
                pic.Width = image.Width;

                PanelJuego.Controls.Add(pic);
                PanelJuego.Refresh();

        }

        public void DibujarTablero()
        {
            int x = 0, y = 0;
            Image image = Resources.celda_vacia;
            for (int i = 0; i < ControladorJuego.Tablero.DimensionX; i++)
            {
                for (int j = 0; j < ControladorJuego.Tablero.DimensionY; j++)
                {
                   if(ControladorJuego.Tablero.TableroCelda[i,j] is Robot)
                       DibujarRobot(new Vector2(x,y));
                   else if (ControladorJuego.Tablero.TableroCelda[i, j] is Obstaculo)
                       DibujarObstaculo(new Vector2(x, y));
                   else
                       DibujarCelda(new Vector2(x, y));                   
                       
                   

                    x += image.Width;
                    
                }
                x = 0;
                y += image.Height;

            }
        }

        void IniciarListaComandos()
        {
            String[] NombreComandos = Enum.GetNames(typeof(Comandos));
            for (int i = 0; i < NombreComandos.Length; i++)
                LbComandos.Items.Add(NombreComandos[i]);
        }
        private void DibujarObstaculo(Vector2 posiciones)
        {
            Image image = Resources.Obstaculo;
            PictureBox pic = new PictureBox();
            pic.Location = new Point(posiciones.X, posiciones.Y);

            pic.Image = image;
            pic.Height = image.Height;
            pic.Width = image.Width;

            PanelJuego.Controls.Add(pic);
            PanelJuego.Refresh();
        }

        public void DibujarRobot(Vector2 posiciones)
        {
            Image image = HerramientasJuego.ObtenerImagenRobotDireccion(ControladorJuego.Robot.Direccion);
            PictureBox pic = new PictureBox();
            pic.Location = new Point(posiciones.X,posiciones.Y);

            pic.Image = image;
            pic.Height = image.Height;
            pic.Width = image.Width;

            PanelJuego.Controls.Add(pic);
            PanelJuego.Refresh();

        }
        public void Dibujar()
        {
           
            DibujarTablero();
            PanelJuego.Refresh();
        }
    }
}
