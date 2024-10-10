using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaViaje
{
    public partial class ViajesFormulario : Form
    {
        public ViajesFormulario()
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
            LabelValorMinutoVuelo.Visible = false;  
            TextBoxValorMinuto.Enabled = false;
            TextBoxValorMinuto.Visible = false;
            TextBoxTasaAero.Visible = false;    
            LabelTasaAeropuerto.Visible = false;
            TextBoxTasaAero.Enabled = false;
            LabelCamarote.Visible = true;
            ListaCamarote.Visible = true;
            ListaCamarote.Enabled = true;
            LabelTransporte.Text = "Valor del transporte a muelle";
            LabelTiempoViaje.Text = "Tiempo de Viaje (Dias)";
        }

        private void BotonAvion_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bienvenido al ingreso de datos!");
            BotonAvion.Visible = false;
            BotonBarco.Enabled = false;
            BotonBarco.Visible = false;
            PictureBoxBarco.Visible = false;
            GroupBoxIngresoDatos.Visible = true;
            LabelCamarote.Visible = false;
            ListaCamarote.Enabled = false;
            ListaCamarote.Visible = false;
            LabelTransporte.Text = "Valor del transporte a el aeropuerto: ";
            LabelTiempoViaje.Text = "Tiempo de Viaje (Horas): ";
            LabelTasaAeropuerto.Enabled = true;
            TextBoxTasaAero.Visible=true;
            LabelTasaAeropuerto.Visible=true;
            TextBoxTasaAero.Enabled=true;
            LabelValorMinutoVuelo.Visible=true;
            TextBoxValorMinuto.Visible=true;
            TextBoxValorMinuto.Enabled=true;

        }

        private void ImageBoxAvion_Click(object sender, EventArgs e)
        {

        }

        private void GroupBoxIngresoDatos_Enter(object sender, EventArgs e)
        {

        }

        private void BotonTotal_Click(object sender, EventArgs e)
        {


        }

        private void BotonTotal_Click_1(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TextBoxDestino.Text) || String.IsNullOrEmpty(TextBoxNombre.Text) || String.IsNullOrEmpty(TextBoxCedula.Text) || String.IsNullOrEmpty(TextBoxNombre.Text) || String.IsNullOrEmpty(ListaHabitación.Text) || String.IsNullOrEmpty(TextBoxValorTransporte.Text))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {


                if (BotonBarco.Enabled == false)
                {
                    Avion avioncito = new Avion(TextBoxDestino.Text, TextBoxNombre.Text, Int32.Parse(TextBoxCedula.Text), Int32.Parse(NumericoDiasEstadia.Value.ToString()), ListaHabitación.Text, FechaDeViaje.Text, Double.Parse(TextBoxTiempoViaje.Text), Double.Parse(TextBoxTasaAero.Text), Double.Parse(TextBoxValorTransporte.Text), Double.Parse(TextBoxValorMinuto.Text));
                    TextBoxTotal.Text = "El precio de excursión en avion para el señor: " + avioncito.Nombre + "\tCon cedula: " + avioncito.Cedula1 + "\tCon destino a: " + avioncito.Destino1 + "\tEn la fecha: " + avioncito.FechaViaje + "\tEs: $" + avioncito.Total().ToString();
            }
                else if (BotonAvion.Enabled == false)
                {
                    Barco Barquito = new Barco(TextBoxDestino.Text,TextBoxNombre.Text,Int32.Parse(TextBoxCedula.Text),Int32.Parse(NumericoDiasEstadia.Value.ToString()),ListaHabitación.Text,FechaDeViaje.Text,Double.Parse(TextBoxTiempoViaje.Text),ListaCamarote.Text,Double.Parse(TextBoxValorTransporte.Text));
                    TextBoxTotal.Text = "El precio de excursión en barco para el señor: " + Barquito.Nombre + "\tCon cedula: " + Barquito.Cedula1 + "\tCon destino a: " + Barquito.Destino1 + "\tEn la fecha: " + Barquito.FechaViaje + "\tEs: $" + Barquito.Total().ToString();

                }
                BotonAvion.Enabled = true;
                BotonBarco.Enabled = true;
                BotonAvion.Visible = true;
                BotonBarco.Visible = true;
                PictureBoxBarco.Visible = true;
                ImageBoxAvion.Visible = true;
            }
            
        }

        private void TextBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            TextBoxDestino.Clear();
            TextBoxCedula.Clear();
            TextBoxNombre.Clear();
            TextBoxTiempoViaje.Clear();
            TextBoxValorMinuto.Clear();
            TextBoxTasaAero.Clear();
            TextBoxValorTransporte.Clear();
            TextBoxTotal.Clear();
            BotonAvion.Enabled = true;
            BotonBarco.Enabled = true;
            BotonAvion.Visible = true;
            BotonBarco.Visible = true;
            PictureBoxBarco.Visible= true;
            ImageBoxAvion.Visible = true;
            GroupBoxIngresoDatos.Visible = false;
        }
    }
}
