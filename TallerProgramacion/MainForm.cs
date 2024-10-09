using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaAnemia;
using EmpresaViaje;


namespace TallerProgramacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void empresaViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViajesFormulario viajesForm = new ViajesFormulario();
            viajesForm.Show();
        }
    }
}
