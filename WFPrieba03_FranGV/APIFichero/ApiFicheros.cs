using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPrieba03_FranGV.APIFichero
{
    public static class ApiFicheros
    {

        private const string Directorio = "Peliculas\\";

        private const string NombreFichero = "Peliculas.pls";

        private static void CrearFicheros()
        {
            StreamWriter Escritor;

            Directory.CreateDirectory(Directorio);

            Escritor = File.CreateText(Directorio+NombreFichero);

            Escritor.Close();
        }




        public static void ValidarExistencia()
        {
          
            if (!File.Exists(Directorio+NombreFichero)) CrearFicheros();
        }



        public static void EscribirFichero(string[] pelicula)
        {

            StreamWriter escritor;

            // Validar Esxistencia
            ValidarExistencia();

            // Abrir Fichero Sobrescribe
            escritor = File.CreateText(Directorio+NombreFichero);

            // Escribir Fichero

            for (int indice = 0; indice < pelicula.Length; indice++)
            {
                escritor.WriteLine(pelicula[indice]);

            }

            escritor.Close();

        }

        public static string[] ConsultarFichero()
        {
            string[] ListaPeliculas;
            ValidarExistencia();

            // Abrir Fichero
            ListaPeliculas = File.ReadAllLines(Directorio+NombreFichero);

            return ListaPeliculas;
        }
    }
}
