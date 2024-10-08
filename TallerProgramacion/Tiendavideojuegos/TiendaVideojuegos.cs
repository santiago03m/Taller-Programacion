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
            InventarioVideojuegos.AgregarVideojuego();
        }

        private void buttonMosrar_Click(object sender, EventArgs e)
        {
            dataGridViewVideojuegos.Rows.Clear();
            dataGridViewVideojuegos.Columns.Clear();

            dataGridViewVideojuegos.Columns.Add("Codigo", "Código");
            dataGridViewVideojuegos.Columns.Add("Nombre", "Nombre");
            dataGridViewVideojuegos.Columns.Add("Autor", "Autor");
            dataGridViewVideojuegos.Columns.Add("Estado", "Estado");

            int pos = InventarioVideojuegos.Cantidad();
            Videojuego[] videojuegos = InventarioVideojuegos.MostrarInventario();

            if (videojuegos != null && pos > 0)
            {
                for (int i = 0; i < pos; i++)
                {
                    string estado = videojuegos[i].Estado ? "Prestado" : "Disponible";
                    dataGridViewVideojuegos.Rows.Add(videojuegos[i].Codigo, videojuegos[i].Nombre, videojuegos[i].Autor, estado);
                }
            }
            else
            {
                MessageBox.Show("No hay videojuegos en el inventario.");
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }

}
