using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo.p1bpoo.MisClases
{
    public class Bus : Vehiculo
    {
        public int CapacidadPasajeros { get; set; }
        public int Rutas { get; set; }
        public bool EsAccesible { get; set; }
        public bool TieneWiFi { get; set; }
        public int NumeroDePuertas { get; set; }

        public Bus(int anio, string elColor, string elModelo, int velocidadMaxima, int capacidadPasajeros, int rutas, bool esAccesible, bool tieneWiFi, int numeroDePuertas)
            : base(anio, elColor, elModelo, velocidadMaxima)
        {
            CapacidadPasajeros = capacidadPasajeros;
            Rutas = rutas;
            EsAccesible = esAccesible;
            TieneWiFi = tieneWiFi;
            NumeroDePuertas = numeroDePuertas;
            VelocidadMaxima = 100;
            CapacidadTanque = 200;
            ConsumoCombustible = 5;
            tiposLicenciaAceptados = new List<string> { "B" };
        }
        public void Informacionbus()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);

        }


    }
}
