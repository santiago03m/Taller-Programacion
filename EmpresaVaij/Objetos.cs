using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViaje
{
    public class Viaje
    {
        string Destino;
        string nombre;
        int Cedula;
        int diasEstadia;
        string TipoHabitacion;
        string fechaViaje;

        public Viaje(string destino, string nombre, int cedula, int diasEstadia, string tipoHabitacion, string fechaViaje)
        {
            Destino1 = destino;
            this.Nombre = nombre;
            Cedula1 = cedula;
            this.DiasEstadia = diasEstadia;
            TipoHabitacion1 = tipoHabitacion;
            this.FechaViaje = fechaViaje;
        }

        public string Destino1 { get => Destino; set => Destino = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cedula1 { get => Cedula; set => Cedula = value; }
        public int DiasEstadia { get => diasEstadia; set => diasEstadia = value; }
        public string TipoHabitacion1 { get => TipoHabitacion; set => TipoHabitacion = value; }
        public string FechaViaje { get => fechaViaje; set => fechaViaje = value; }

        public double ValorHabitacion()
        {
            switch(TipoHabitacion1.ToLower())
            {
                case "suite":
                    return 90000;
                    break;
                    
                case "normal":
                    return 55000;
                    break;
            
            }
            return 90000;
        }

    }
    public class Avion : Viaje
    {
        double DuracionHorasViajes;
        double ValorTasaAeroportuaria;
        double ValorTransporteAeropuerto;
        double ValorMinutoVuelo;

        public Avion(string destino, string Nombre, int cedula, int DiasEstadia, string tipoHabitacion, string FechaViaje, double duracionHorasViajes, double valorTasaAeroportuaria, double valorTransporteAeropuerto, double valorMinutoVuelo) : base(destino, Nombre, cedula, DiasEstadia,tipoHabitacion,FechaViaje)
        {
            DuracionHorasViajes1 = duracionHorasViajes;
            ValorTasaAeroportuaria1 = valorTasaAeroportuaria;
            ValorTransporteAeropuerto1 = valorTransporteAeropuerto;
            ValorMinutoVuelo1 = valorMinutoVuelo;
        }

        public double DuracionHorasViajes1 { get => DuracionHorasViajes; set => DuracionHorasViajes = value; }
        public double ValorTasaAeroportuaria1 { get => ValorTasaAeroportuaria; set => ValorTasaAeroportuaria = value; }
        public double ValorTransporteAeropuerto1 { get => ValorTransporteAeropuerto; set => ValorTransporteAeropuerto = value; }
        public double ValorMinutoVuelo1 { get => ValorMinutoVuelo; set => ValorMinutoVuelo = value; }
       
        
        public double Total()
        {
            return ((ValorHabitacion() * DiasEstadia) + (DuracionHorasViajes1 * 60 * ValorMinutoVuelo1) + ValorTasaAeroportuaria1 + ValorTransporteAeropuerto1);
        }
    }
    public class Barco : Viaje
    {
        double DuracionDiasViaje;
        string TipoCamarote;
        double ValorTransporteMuelle;

        public double DuracionDiasViaje1 { get => DuracionDiasViaje; set => DuracionDiasViaje = value; }
        public string TipoCamarote1 { get => TipoCamarote; set => TipoCamarote = value; }
        public double ValorTransporteMuelle1 { get => ValorTransporteMuelle; set => ValorTransporteMuelle = value; }

        public Barco(string destino, string Nombre, int cedula, int DiasEstadia, string tipoHabitacion, string FechaViaje, double duracionDiasViaje, string tipoCamarote, double valorTransporteMuelle) : base(destino,Nombre, cedula, DiasEstadia, tipoHabitacion, FechaViaje)
        {
            DuracionDiasViaje = duracionDiasViaje;
            TipoCamarote = tipoCamarote;
            ValorTransporteMuelle = valorTransporteMuelle;
            
        }
        public double ValorCamarote()
        {
            switch (TipoCamarote.ToLower())
            {
                case "lujo":
                    return 70000;
                    break;
                case "normal":
                    return 60000;
                    break;
                case "economica":
                    return 40000;
                    break;
            }
            return 0;
        }
        public double Total()
        {
            return ((DuracionDiasViaje * ValorCamarote()) + (ValorHabitacion() * DiasEstadia) + ValorTransporteMuelle);
        }
    }

}
