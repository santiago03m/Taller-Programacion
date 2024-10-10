using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVideojuegos
{
    public partial class TiendaVideojuegos : Form
    {
        public TiendaVideojuegos()
        {
            InitializeComponent();
            InventarioVideojuegos.AgregarVideojuego();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
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
                buttonPrestar.Visible = true;
                buttonRetirar.Visible = true;
                buttonDevolver.Visible = true;
                labelCodigo.Visible = true;
                labelAutor.Visible = true;
                labelNombre.Visible = true;
                textBoxCodigo.Visible = true;
                textBoxAutor.Visible = true;
                textBoxNombre.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay videojuegos en el inventario.");
                buttonPrestar.Enabled = false;
                buttonRetirar.Enabled = false;
                buttonDevolver.Enabled = false;
            }
            buttonIngresarNuevo.Visible = true;
        }
 

        private void buttonIngresarNuevo_Click(object sender, EventArgs e)
        {
            if (!InventarioVideojuegos.lleno())
            {
                string codigo = textBoxCodigo.Text;
                string nombre = textBoxNombre.Text;
                string autor = textBoxAutor.Text;
                bool estado = false;


                if (codigo != "" && nombre != "" && autor != "")
                {
                    if (InventarioVideojuegos.ExisteCodigo(codigo))
                    {
                        MessageBox.Show("El código ya existe. Por favor, ingrese un código diferente.");
                    }
                    else if (InventarioVideojuegos.ExisteNombre(nombre))
                    {
                        MessageBox.Show("El nombre ya existe. Por favor, ingrese un nombre diferente.");
                    }
                    else
                    {
                        try
                        {
                            Videojuego nuevoVideojuego = new Videojuego(codigo, nombre, autor, estado);

                            string mensaje = InventarioVideojuegos.agregarVideojuego(nuevoVideojuego);

                            MessageBox.Show(mensaje);

                            buttonPrestar.Enabled = true;
                            buttonRetirar.Enabled = true;
                            buttonDevolver.Enabled = true;

                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Por favor, ingrese un código válido (número)." + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
            }
            else
            {
                MessageBox.Show("No es posible poner más juegos en el invetario");
            }
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxAutor.Clear();
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            if (!InventarioVideojuegos.vacio())
            {
                string codigo = textBoxCodigo.Text;
                string eliminar = InventarioVideojuegos.RetirarVideojugo(codigo);
                MessageBox.Show(eliminar);

            }
            else
            {
                MessageBox.Show("No se ha encontrado el videojuego");
            }
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxAutor.Clear();
        }

        private void buttonPrestar_Click(object sender, EventArgs e)
        {
            if (!InventarioVideojuegos.vacio())
            {

                string codigo = textBoxCodigo.Text;
                string mensaje = InventarioVideojuegos.Prestar(codigo);

                MessageBox.Show(mensaje);

                textBoxCodigo.Clear();
                textBoxNombre.Clear();
                textBoxAutor.Clear();

            }
            else
            {
                MessageBox.Show("El inventario se encuentra vacio");
            }
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            if (!InventarioVideojuegos.vacio())
            {

                string codigo = textBoxCodigo.Text;
                string mensaje = InventarioVideojuegos.Devolver(codigo);

                MessageBox.Show(mensaje);

            }
            else
            {
                MessageBox.Show("El inventario se encuentra vacio");
            }

            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxAutor.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
