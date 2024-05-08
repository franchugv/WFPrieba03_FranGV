using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPrieba03_FranGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cadena;

            cadena =  $"Índice del comboBox: {comboBoxPelicula.SelectedIndex}\n";
            cadena += $"El elemento del ComboBox: {comboBoxPelicula.SelectedItem}\n";
            cadena += $"El valor del elemento del ComboBox: {comboBoxPelicula.SelectedValue}\n";

            MessageBox.Show(cadena, "ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Reniciar la cadena
            cadena = "";
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            string pelicula;
            string[] ListaPeliculas = null;
            string MensajeError = null;
            bool esValido = true;

            Button boton = (Button)sender;

            try
            {


                switch (boton.Name)
                {
                    case "BotonAgregarPelicula":

                        // Igualar cadena 
                        pelicula = TextBoxPelicula.Text;


                        if (string.IsNullOrEmpty(pelicula)) throw new Exception("Error: Cadena vacía");


                        ListaPeliculas = comboBoxPelicula.Items.Cast<string>().ToArray();


                        AgregarPeliculas(pelicula, ListaPeliculas);

                        break;
                    case "BotonGuardar":
                        APIFichero.ApiFicheros.GuardarFichero(ListaPeliculas);
                        break;

                    case "BotonCargar":
                        CargarPeliculas();
                        break;
                }

               


            }
            catch (Exception error) 
            { 
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido)UI.MostrarErrores(MensajeError);


            }
        }

        public void AgregarPeliculas(string pelicula, string[] listaPeliculas)
        {

            // Validar repetición
            Validacion.ValidarRepeticion(pelicula, listaPeliculas);

            comboBoxPelicula.Items.Add(pelicula);

            TextBoxPelicula.Text = "";


        }

        public static void EscribirFichero(string[] ListaElementos)
        {
        }

        public void CargarPeliculas()
        {
            comboBoxPelicula.Items.AddRange(APIFichero.ApiFicheros.ConsultarFichero());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
        }

    }
}
