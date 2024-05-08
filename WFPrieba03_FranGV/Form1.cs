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
            string[] ListaPeliculas;
            string MensajeError = null;
            bool esValido = true;


            // Igualar cadena 
            pelicula = TextBoxPelicula.Text;

            // Inicializar Array al contenido del ComboBox
            ListaPeliculas = comboBoxPelicula.Items.Cast<string>().ToArray();            



            Button boton = (Button)sender;
            try
            {


                switch (boton.Name)
                {
                                            
                    case "BotonAgregarPelicula":
                        AgregarPeliculas(pelicula, ListaPeliculas);
                        break;
                    case "BotonGuardar":
                        APIFichero.ApiFicheros.EscribirFichero(ListaPeliculas);
                        break;

                    case "BotonCargar":
                        CargarPeliculas();
                        BotonCargar.Enabled = false;
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
            // Validación
            if (string.IsNullOrEmpty(pelicula)) throw new Exception("Error: Cadena vacía");
            // Validar repetición
            Validacion.ValidarRepeticion(pelicula, listaPeliculas);

            comboBoxPelicula.Items.Add(pelicula);

            TextBoxPelicula.Text = "";


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
