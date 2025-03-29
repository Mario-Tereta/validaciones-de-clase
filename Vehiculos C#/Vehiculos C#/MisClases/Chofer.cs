using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfaces;

namespace p1bpoo.MisClases
{
    public class Chofer : IPiloto
    {
        public string Nombre { get; set ; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        public Chofer(string nombre, int edad, string tipoLicencia)
        {
            if ((tipoLicencia == "A" || tipoLicencia == "B") && edad < 18)
            {
                throw new ArgumentException("La edad mínima para la licencia tipo A o B es 18 años.");
            }
            if (tipoLicencia == "C" && edad < 21)
            {
                throw new ArgumentException("La edad mínima para la licencia tipo C es 21 años.");
            }
            if (tipoLicencia == "M" && edad < 16)
            {
                throw new ArgumentException("La edad mínima para la licencia tipo M es 16 años.");
            }

            Nombre = nombre;
            Edad = edad;
            TipoLicencia = tipoLicencia;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("El piloto es {0}", Nombre);
            Console.WriteLine("Licencia Tipo {0}", TipoLicencia);
        }
    }
}
