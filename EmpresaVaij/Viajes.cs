using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaVaij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelOpciones_Click(object sender, EventArgs e)
        {

        }

        private void LabelFecha_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonBarco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al ingreso de datos!");
            BotonAvion.Enabled = false;
            BotonAvion.Visible = false;
            ImageBoxAvion.Visible = false;
            GroupBoxIngresoDatos.Visible = true;
            BotonBarco.Visible = false;

        }

        private void BotonAvion_Click(object sender, EventArgs e)
        {
            Objetos avion = new Objetos(TextBoxDestino.Text, );
            MessageBox.Show("Bienvenido al ingreso de datos!");
            BotonAvion.Visible = false;
            BotonBarco.Enabled = false;
            BotonBarco.Visible = false;
            PictureBoxBarco.Visible = false;
            GroupBoxIngresoDatos.Visible = true;
            LabelTiempoViaje.Text = "Tiempo de Viaje (Horas): ";
            
        }

        private void ImageBoxAvion_Click(object sender, EventArgs e)
        {

        }

        private void GroupBoxIngresoDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
