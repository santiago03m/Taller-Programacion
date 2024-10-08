using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion.Tiendavideojuegos;

namespace TallerProgramacion.TiendVideojuegos
{
    public partial class TiendaVideojuegos : Form
    {
        public TiendaVideojuegos()
        {
            InitializeComponent();
        }

        private void buttonMosrar_Click(object sender, EventArgs e)
        {
            int pos = InventarioVideojuegos.Cantidad();
            Videojuego[] videojuegos = InventarioVideojuegos.MostrarInventario();
            string mensaje = "Codigo\tNombre\tAutor\tEstado";
            if (videojuegos != null && videojuegos.Length >0)
            {
                for (int i = 0; i < pos; i++)
                {
                    mensaje += videojuegos[i].Codigo + "\t" +
                               videojuegos[i].Nombre + "\t" +
                               videojuegos[i].Autor + "\t" +
                               (videojuegos[i].Estado ? "Prestado" : "Disponible") + "\r\n";
                }
            }
            else
            {
                mensaje += "No hay videojuegos en el inventario.\r\n";
            }
            textBoxMostrar.Text = mensaje;
        
    }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
