using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaAnemia
{
    public partial class AnemiaForm : Form
    {
        private Estadisticas estadisticas;

        public AnemiaForm()
        {
            InitializeComponent();
            estadisticas = new Estadisticas();
            ActualizarLabelsEstadisticas();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double hemoglobina;
            int edad;

            // Validar que se ingrese la hemoglobina y que la edad sea seleccionada
            if (double.TryParse(txtHemoglobina.Text, out hemoglobina) && numericEdad.Value > 0)
            {
                edad = (int)numericEdad.Value;
                string genero = cmbGenero.SelectedItem.ToString();
                string resultado = EvaluarHemoglobina(hemoglobina, edad, genero);

                // Actualizar estadísticas
                estadisticas.ActualizarContadores(resultado, edad, genero);

                // Mostrar resultado en el label de resultado
                lblResultado.Text = $"Resultado: {resultado}";

                // Actualizar labels en el group box de estadísticas
                ActualizarLabelsEstadisticas();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
            }
        }

        private string EvaluarHemoglobina(double hemoglobina, int edad, string genero)
        {
            if (edad <= 1)
            {
                return (hemoglobina < 13 || hemoglobina > 26) ? "Positivo" : "Negativo";
            }
            else if (edad <= 5)
            {
                return (hemoglobina < 11.5 || hemoglobina > 15) ? "Positivo" : "Negativo";
            }
            else if (edad <= 10)
            {
                return (hemoglobina < 12.6 || hemoglobina > 15.5) ? "Positivo" : "Negativo";
            }
            else if (edad <= 15)
            {
                return (hemoglobina < 13 || hemoglobina > 15.5) ? "Positivo" : "Negativo";
            }
            else if (genero == "Femenino")
            {
                return (hemoglobina < 12 || hemoglobina > 16) ? "Positivo" : "Negativo";
            }
            else // Masculino
            {
                return (hemoglobina < 14 || hemoglobina > 18) ? "Positivo" : "Negativo";
            }
        }

        private void ActualizarLabelsEstadisticas()
        {
            lblTotalExamenes.Text = $"Total Exámenes: {estadisticas.TotalExamenes}";
            lblPositivos.Text = $"Positivos: {estadisticas.TotalPositivos}";
            lblNegativos.Text = $"Negativos: {estadisticas.TotalNegativos}";
            lblPositivos0_1.Text = $"0-1 años Positivos: {estadisticas.Positivos0_1}";
            lblNegativos0_1.Text = $"0-1 años Negativos: {estadisticas.Negativos0_1}";
            lblPositivos1_5.Text = $"1-5 años Positivos: {estadisticas.Positivos1_5}";
            lblNegativos1_5.Text = $"1-5 años Negativos: {estadisticas.Negativos1_5}";
            lblPositivos5_10.Text = $"5-10 años Positivos: {estadisticas.Positivos5_10}";
            lblNegativos5_10.Text = $"5-10 años Negativos: {estadisticas.Negativos5_10}";
            lblPositivos10_15.Text = $"10-15 años Positivos: {estadisticas.Positivos10_15}";
            lblNegativos10_15.Text = $"10-15 años Negativos: {estadisticas.Negativos10_15}";
            lblPositivosMayores15Mujeres.Text = $"Mayores de 15 (Mujeres) Positivos: {estadisticas.PositivosMayores15Mujeres}";
            lblNegativosMayores15Mujeres.Text = $"Mayores de 15 (Mujeres) Negativos: {estadisticas.NegativosMayores15Mujeres}";
            lblPositivosMayores15Hombres.Text = $"Mayores de 15 (Hombres) Positivos: {estadisticas.PositivosMayores15Hombres}";
            lblNegativosMayores15Hombres.Text = $"Mayores de 15 (Hombres) Negativos: {estadisticas.NegativosMayores15Hombres}";
        }

        private void gbEvaluacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
