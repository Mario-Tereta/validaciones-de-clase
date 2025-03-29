using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }
        public int VelocidadActual { get; private set; }
        protected int VelocidadMaxima { get; set; }
        protected int CapacidadTanque { get; set; }
        protected int ConsumoCombustible { get; set; }
        
        private int velocidad = 0;

        //Atributos Nuevos

        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C" };
        private Chofer? piloto = null;
        private int estadoVe = 0; // 0 = apagado, 1 = encendido, 2 = en movimiento
        
        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (string.IsNullOrEmpty(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene una licencia válida";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado para este vehículo";
            }
            if (piloto != null)
            {
                return "El vehículo ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado correctamente";
        }

        public Vehiculo(int anio, string elColor, string elModelo, int velocidadMaxima)
        {
            Year = anio;
            Color = elColor;
            Modelo = elModelo;
            VelocidadActual = 0;
            estadoVe = 0; // Apagado por defecto
            VelocidadMaxima = velocidadMaxima;
        }

        public void InformacionVehiculo()
        {
            string estadoVehiculo = estadoVe switch
            {
                0 => "apagado",
                1 => "encendido",
                2 => "en movimiento",
                _ => "desconocido"
            };

            string infoPiloto = piloto != null ? piloto.Nombre : "Ninguno";

            Console.WriteLine($"Marca: {Modelo}, Año: {Year}, Color: {Color}");
            Console.WriteLine($"Velocidad Actual: {VelocidadActual} km/h, Velocidad Máxima: {VelocidadMaxima} km/h");
            Console.WriteLine($"Estado del Vehículo: {estadoVehiculo}");
            Console.WriteLine($"Piloto Asignado: {infoPiloto}");
        }

        public string Encender ()
        {
            if (piloto == null)
            {
                return "ups, no puedes encender el vehiculo sin piloto";
            }
            if(estadoVe == 0)
            {
                estadoVe = 1;
                return "El Vehiculo esta encendido";
            }
            return "ups, ya estaba encendido";
        }

        public void Apagar()
        {
            if (VelocidadActual == 0)
            {
                estadoVe = 0;
                Console.WriteLine("Vehículo apagado.");
            }
            else
            {
                Console.WriteLine("No se puede apagar el vehículo en movimiento.");
            }
        }
        public virtual void Acelerar(int cuanto)
        {
            if (estadoVe == 1)
            {
                if (velocidad + cuanto > VelocidadMaxima)
                {
                    velocidad = VelocidadMaxima;
                    Console.WriteLine("Has alcanzado la velocidad máxima de {0} KMS / Hora", VelocidadMaxima);
                }
                else
                {
                    velocidad += cuanto;
                    Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar con el vehiculo apagado");
            }
        }

        public void Frenar(int decremento)
        {
            if (estadoVe == 2)
            {
                VelocidadActual -= decremento;
                if (VelocidadActual <= 0)
                {
                    VelocidadActual = 0;
                    estadoVe = 1; // Encendido
                    Console.WriteLine("El vehículo se ha detenido.");
                }
                else
                {
                    Console.WriteLine($"Vehículo frenado a {VelocidadActual} km/h.");
                }
            }
            else
            {
                Console.WriteLine("El vehículo no está en movimiento.");
            }
        }
    }
}
