using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPrieba03_FranGV
{
    public static class Validacion
    {

        public static void ValidarRepeticion(string pelicula, string[] ListaPeliculas)
        {
            // Pasar a misnusculas
            pelicula = pelicula.Trim().ToLower();
            string Cadena = "";

            foreach (string item in ListaPeliculas)
            {
                // Pasar a misnusculas
                Cadena = item.Trim().ToLower();

                // Validar que exista, tambien se puede hacer con el Equals
                if (pelicula.Contains(Cadena)) throw new Exception("Se repite");
            }
        }

        public static void ValidarCadena(string cadena)
        {
            if(string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
        }

    }
}
