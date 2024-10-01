using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAnemia
{
    public class Estadisticas
    {
        public int TotalExamenes { get; private set; }
        public int TotalPositivos { get; private set; }
        public int TotalNegativos { get; private set; }

        public int Positivos0_1 { get; private set; }
        public int Negativos0_1 { get; private set; }
        public int Positivos1_5 { get; private set; }
        public int Negativos1_5 { get; private set; }
        public int Positivos5_10 { get; private set; }
        public int Negativos5_10 { get; private set; }
        public int Positivos10_15 { get; private set; }
        public int Negativos10_15 { get; private set; }
        public int PositivosMayores15Mujeres { get; private set; }
        public int NegativosMayores15Mujeres { get; private set; }
        public int PositivosMayores15Hombres { get; private set; }
        public int NegativosMayores15Hombres { get; private set; }

        public void ActualizarContadores(string resultado, int edad, string genero)
        {
            TotalExamenes++;

            if (resultado == "Positivo")
            {
                TotalPositivos++;
            }
            else
            {
                TotalNegativos++;
            }

            // Actualizar contadores por rango de edad
            if (edad <= 1)
            {
                if (resultado == "Positivo") Positivos0_1++;
                else Negativos0_1++;
            }
            else if (edad <= 5)
            {
                if (resultado == "Positivo") Positivos1_5++;
                else Negativos1_5++;
            }
            else if (edad <= 10)
            {
                if (resultado == "Positivo") Positivos5_10++;
                else Negativos5_10++;
            }
            else if (edad <= 15)
            {
                if (resultado == "Positivo") Positivos10_15++;
                else Negativos10_15++;
            }
            else if (genero == "Femenino")
            {
                if (resultado == "Positivo") PositivosMayores15Mujeres++;
                else NegativosMayores15Mujeres++;
            }
            else // Masculino
            {
                if (resultado == "Positivo") PositivosMayores15Hombres++;
                else NegativosMayores15Hombres++;
                Console.WriteLine("Parchese");
            }
        }
    }
}
