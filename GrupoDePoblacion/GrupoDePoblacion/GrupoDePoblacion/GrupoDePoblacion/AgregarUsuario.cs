using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GrupoDePoblacion
{
    public partial class AgregarUsuario : Form
    {
        string nombre, apellido, leciones, grupoSanguineo, enfermedades, discapacidades;
        int edad;
        double peso, altura;

        public AgregarUsuario()
        {
            InitializeComponent();
            test();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            salirDeLaAplicacion();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCajasDeTexto();
        }

        private void btProcesar_Click(object sender, EventArgs e)
        {
            EnviarInforme();
            GuardarAutoCompletado();
            Close();
        }

        private void AgregarUsuario_load(object sender, EventArgs e)
        {
            CargarAutoCompletado();
        }

        private void GuardarAutoCompletado()
        {
            // Validar no repeticion antes de guardar
            if (!Properties.Settings.Default.Lecciones.Contains(leciones))
                Properties.Settings.Default.Lecciones.Add(leciones);

            if (!Properties.Settings.Default.GrupoSanguineo.Contains(grupoSanguineo))
                Properties.Settings.Default.GrupoSanguineo.Add(grupoSanguineo);

            if (!Properties.Settings.Default.Enfermedades.Contains(enfermedades))
                Properties.Settings.Default.Enfermedades.Add(enfermedades);

            if (!Properties.Settings.Default.Discapacidades.Contains(discapacidades))
                Properties.Settings.Default.Discapacidades.Add(discapacidades);

            Properties.Settings.Default.Save();
        }

        private void EnviarInforme()
        {
            //Declaracion
            string salida = "", grupodepoblacion = "";
            double IMC = 0;

            //Entradas
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            edad = int.Parse(txt_edad.Text);
            peso = double.Parse(txt_peso.Text);
            altura = double.Parse(txt_altura.Text);
            leciones = txt_leciones.Text;
            grupoSanguineo = txt_grupoSanguineo.Text;
            enfermedades = txt_enfermedades.Text;
            discapacidades = txt_discapacidades.Text;

            //metodos
            grupodepoblacion = grupopoblacion(edad, grupodepoblacion);
            IMC = CalcularIMC(peso, altura);


            //Salida
            salida += "Nombre: " + nombre + " " + apellido + "\n";
            _ = "Edad: " + edad + "\n";
            _ = "Peso: " + peso + "\n";
            _ = "Altura: " + altura + "\n";
            _ = "Discapacidades: " + discapacidades + "\n";
            _ = "Lecciones: " + leciones + "\n";
            _ = "IMC: " + IMC.ToString() + "\n";
            _ = "Grupo de Poblacion: " + grupodepoblacion + "\n";
        }

        private double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string grupopoblacion(int Edad, string grupodepoblacion)
        {
            if (Edad >= 0 && Edad < 18)
            {
                grupodepoblacion = "niño(joven)";
            }
            else if (Edad >= 18 && Edad < 60)
            {
                grupodepoblacion = "adulto";

            }
            else if (Edad >= 60)
            {
                grupodepoblacion = "Tercera edad";
            }
            else
            {
                grupodepoblacion = "Ha ingresado un valor invalido";
            }
            return grupodepoblacion;
        }

        private void CargarAutoCompletado()
        {
            txt_leciones.AutoCompleteCustomSource = Autocompletar(Properties.Settings.Default.Lecciones);
            txt_grupoSanguineo.AutoCompleteCustomSource = Autocompletar(Properties.Settings.Default.GrupoSanguineo);
            txt_enfermedades.AutoCompleteCustomSource = Autocompletar(Properties.Settings.Default.Enfermedades);
            txt_discapacidades.AutoCompleteCustomSource = Autocompletar(Properties.Settings.Default.Discapacidades);
        }

        private AutoCompleteStringCollection Autocompletar(StringCollection lista)
        {
            AutoCompleteStringCollection value = new AutoCompleteStringCollection();
            foreach (string i in lista)
            {
                value.Add(i);
            }
            return value;
        }

        /// <summary>
        /// Limpiar cajas de texto
        /// </summary>
        private void limpiarCajasDeTexto()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_edad.Clear();
            txt_peso.Clear();
            txt_altura.Clear();
            txt_leciones.Clear();
            txt_grupoSanguineo.Clear();
            txt_enfermedades.Clear();
            txt_discapacidades.Clear();
        }

        /// <summary>
        /// Hace una verificacion en busca de variables vacias y las inicializa
        /// </summary>
        private void test()
        {
            if (Properties.Settings.Default.Lecciones == null)
                Properties.Settings.Default.Lecciones = new StringCollection();

            if (Properties.Settings.Default.GrupoSanguineo == null)
                Properties.Settings.Default.GrupoSanguineo = new StringCollection();

            if (Properties.Settings.Default.Enfermedades == null)
                Properties.Settings.Default.Enfermedades = new StringCollection();

            if (Properties.Settings.Default.Discapacidades == null)
                Properties.Settings.Default.Discapacidades = new StringCollection();
        }

        /// <summary>
        /// Cierra todas las ventanas y cierratoda la aplicación
        /// </summary>
        private void salirDeLaAplicacion()
        {
            //Mensaje que pregunta si quiere o no salir de la aplicacion
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {//en caso verdadero
                //mensaje antes de cerrar la aplicacion
                MessageBox.Show("Gracias por usar está aplicacion");

                //Ocultar el formulario
                Hide();

                //Cerrar todos los formularios en proceso
                Application.ExitThread();
                Close();
            }
        }

        /// <summary>
        /// Carga las cajas de texto con una configuración pre establecida
        /// </summary>
        /// <param name="identificador_del_usuraio">El codigo unico del usuario</param>
        public void CargarCajasDeTexto(string identificador_del_usuraio)
        {
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
        }
    }
}