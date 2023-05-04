using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulacion_Actividad_1_U1_FEGA.Personaje
{
    public class Personaje
    {
        public string Nombre { get; private set; }
        public string NombreReal { get; private set; }
        public string PrimeraAparicion { get; private set; }
        public string FechaPrimeraAparicion { get; set; }
        public string Poderes { get; set; }

        public string Creador { get; set; }
        public string Artista { get; set; }

        public void CrearPersonaje (string _nombre, string _nombreReal, string _primeraAparacion)
        {
            this.Nombre = _nombre;
            this.NombreReal = _nombreReal;
            this.PrimeraAparicion = _primeraAparacion;
        }

        public void MostrarPersonaje(Personaje _personaje)
        {
            Console.WriteLine("Nombre: " + _personaje.Nombre);
            Console.WriteLine("Nombre Real: " + _personaje.NombreReal);
            Console.WriteLine("primera Aparacion: " + _personaje.PrimeraAparicion);
        }


    }
}
