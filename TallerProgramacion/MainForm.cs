﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaAnemia;
using TallerProgramacion.TiendVideojuegos;


namespace TallerProgramacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        // Evento para cerrar la aplicación
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento para abrir el formulario de Anemia
        private void anemiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnemiaForm anemiaForm = new AnemiaForm();
            anemiaForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNames_Click(object sender, EventArgs e)
        {

        }

        private void mostrarVideojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           TiendaVideojuegos tiendaVideojuegos = new TiendaVideojuegos();
            tiendaVideojuegos.Show();
        }
    }
}
