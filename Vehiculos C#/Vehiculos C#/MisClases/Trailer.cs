using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo.p1bpoo.MisClases
{
        public class Trailer : Vehiculo
        {
            public int CapacidadCarga { get; set; }
            public string TipoCarga { get; set; }
            public int NumeroEjes { get; set; }
            public bool TieneFrenos { get; set; }
            public double Longitud { get; set; }

            public Trailer(int anio, string elColor, string elModelo, int velocidadMaxima ,int capacidadCarga, string tipoCarga, int numeroEjes, bool tieneFrenos, double longitud)
                : base(anio, elColor, elModelo, velocidadMaxima)
            {
                VelocidadMaxima = 180;
                CapacidadCarga = capacidadCarga;
                TipoCarga = tipoCarga;
                NumeroEjes = numeroEjes;
                TieneFrenos = tieneFrenos;
                Longitud = longitud;
                tiposLicenciaAceptados = new List<string> { "A" };
            }
            
        }
}
