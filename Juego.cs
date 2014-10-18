using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Robot.Properties;
using ListBox = System.Windows.Forms.ListBox;

namespace Robot
{
    public partial class Juego : Form
    {
        private ControladorGrafico _controladorGrafico; 
        public Juego()
        {
            InitializeComponent();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            _controladorGrafico = new ControladorGrafico(this.pJuego, this.pComandos, this.lbComandos, this.lbComandosEjecutar);
            _controladorGrafico.Dibujar();
            
            
        }

        private void lbComandos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            lbComandosEjecutar.Items.Add(lbComandos.SelectedItem);
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<lbComandosEjecutar.Items.Count;i++)
                _controladorGrafico.ControladorJuego.ListaDeComandos.ListaDeComandosEjecutar.Add((Comandos)Enum.Parse(typeof(Comandos), lbComandosEjecutar.Items[i].ToString()));
            _controladorGrafico.ControladorJuego.ListaDeComandos.Ejecutar();
            _controladorGrafico.ControladorJuego.ListaDeComandos.LimpiarLista();
            _controladorGrafico.PanelJuego.Controls.Clear();
            _controladorGrafico.Dibujar();

        }

        private void bLimpiarLista_Click(object sender, EventArgs e)
        {
            lbComandosEjecutar.Items.Clear();
        }
        
        
    }
}
