using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo.p1bpoo.MisClases
{
    public class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo, int velocidadMaxima) : base(anio, elColor, elModelo, velocidadMaxima)
        {
            tiposLicenciaAceptados = new List<string> { "M" };
            VelocidadMaxima = 220;
            CapacidadTanque = 15;
            ConsumoCombustible = 1;
        }

        public void HacerCaballito()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("¡Haciendo caballito!");
            }
            else
            {
                Console.WriteLine("La moto debe estar en movimiento para hacer un caballito.");
            }
        }
    }
}
