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
            // Creación del directorio
            Directory.CreateDirectory(Directorio);

            // Creación del archivo
            Escritor = File.CreateText(Directorio+NombreFichero);

            Escritor.Close();
        }




        public static void ValidarExistencia()
        {
          // Si no existe, creará el archivo, haciendo uso del metodo anterior
            if (!File.Exists(Directorio+NombreFichero)) CrearFicheros();
        }



        public static void EscribirFichero(string[] ListaPeliculas)
        {

            StreamWriter escritor;

            // Validar Esxistencia
            ValidarExistencia();

            // Abrir Fichero Sobrescribe
            escritor = File.CreateText(Directorio+NombreFichero);

            // Escribir Fichero usando el contenido del Array ListaPeliculas

            for (int indice = 0; indice < ListaPeliculas.Length; indice++)
            {
                escritor.WriteLine(ListaPeliculas[indice]);

            }
            // Cerramos el fichero para que no de error
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
