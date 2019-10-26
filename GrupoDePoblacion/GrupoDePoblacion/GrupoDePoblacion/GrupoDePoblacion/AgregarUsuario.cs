using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        string usuario, nombre, apellido, leciones, grupoSanguineo, enfermedades, discapacidades;
        int edad;
        double peso, altura;

        public AgregarUsuario()
        {
            InitializeComponent();
            test();
        }

        public AgregarUsuario(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            test();
            CargarCajasDeTexto();
            
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
            string grupodepoblacion = "";
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


            //Enviar a base de datos
            EnviaraBasedeDatos(grupodepoblacion,IMC);

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
            //Ocultar el formulario
            Hide();

            //Mensaje que pregunta si quiere o no salir de la aplicacion
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //mensaje antes de cerrar la aplicacion
                MessageBox.Show("Gracias por usar está aplicacion");

                //Cerrar todos los formularios en proceso
                Application.ExitThread();
                Close();
            }
            else
            {
                // mostrar formulario
                Show();
            }
        }

        /// <summary>
        /// Carga las cajas de texto con una configuración pre establecida
        /// </summary>
        /// <param name="identificador_del_usuraio">El codigo unico del usuario</param>
        public void CargarCajasDeTexto()
        {
            //Obtiene los datos necesarios para cargar el formulario
            string[] Datos = CargarDatos();

            if (Datos != null)
            {
                // Desabilita las cajas de texto para que no puedan ser modificadas
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;

                txt_nombre.Text = Datos[0];
                txt_apellido.Text = Datos[1];/*
                txt_edad.Text = Datos[2];
                txt_peso.Text = Datos[3];
                txt_altura.Text = Datos[4];
                txt_leciones.Text = Datos[5];
                txt_grupoSanguineo.Text = Datos[6];
                txt_enfermedades.Text = Datos[7];
                txt_discapacidades.Text = Datos[8];//*/

            }
        }

        private string[] CargarDatos()
        {
            //declaracion de salida
            string[] SalidadeDatos = new string[2];

             // Direccion de la Base de Datos
            string CadenaDeConexion = Properties.Settings.Default.ClientesConnectionString;

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            String ConsultaQuery =
                "SELECT nombre, apellido FROM Usuarios WHERE(usuario = @usuario)";//

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            //agregar entrada a la base de datos
            Comando.Parameters.AddWithValue("@usuario", usuario);

            // Variable de lectura de datos
            OleDbDataReader LectordeDatos;

            // Vamos a ejecutar la c¿Consulta por medio del objecto comando
            LectordeDatos = Comando.ExecuteReader();

            // Validamos Si existen existas en esta consulta
            if (LectordeDatos.HasRows)
            {
                while (LectordeDatos.Read())
                {
                    SalidadeDatos[0] = LectordeDatos[0].ToString();
                    SalidadeDatos[1] = LectordeDatos[1].ToString();
                }
            }
            else
            {
                Console.WriteLine("Ha ocurriod un error inesperado");
                Enabled = false;
                return null;
            }

            // Cerrar Conexion
            Conexion.Close();
            LectordeDatos.Close();

            // Devolvemos el resultado
            return SalidadeDatos;
        }

        private Boolean EnviaraBasedeDatos( string grupodepoblacion, double imc)
        {
            //Declaración de variables
            string fecha = DateTime.Now.ToString("h:mm:ss");
            if (usuario == null)
                usuario = "Juan";
            Boolean salida = false;

            // Direccion de la Base de Datos
            string CadenaDeConexion = Properties.Settings.Default.ClientesConnectionString;

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            string ConsultaQuery = "INSERT INTO Perfil "
                + " (usuario, edad, peso, altura, leciones, [grupo sanguineo], enfermedades, discapacidades, [grupo de poblacion], imc, fecha)"
                + " VALUES (@usuario, @edad, @peso, @altura, @leciones, @grupoSanguineo, @enfermedades," + " @discapacidades, @grupodepoblacion, @imc, @fecha)";

            // crear un objecto comando para efectuar la consulta//*/
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            Comando.Parameters.AddWithValue("usuario", usuario);
            Comando.Parameters.AddWithValue("@edad", edad);
            Comando.Parameters.AddWithValue("@peso", peso);
            Comando.Parameters.AddWithValue("@altura", altura);
            Comando.Parameters.AddWithValue("@leciones", leciones);
            Comando.Parameters.AddWithValue("@grupoSanguineo", grupoSanguineo);
            Comando.Parameters.AddWithValue("@enfermedades", enfermedades);
            Comando.Parameters.AddWithValue("@discapacidades", discapacidades);
            Comando.Parameters.AddWithValue("@grupodepoblacion", grupodepoblacion);
            Comando.Parameters.AddWithValue("@imc", imc);
            Comando.Parameters.AddWithValue("@fecha", fecha);//*/

            //extra
            switch (Comando.ExecuteNonQuery())
            {
                case 0:
                    {
                        if (usuario == null)
                        {
                            MessageBox.Show("Registro Falló.");
                        }
                        else
                        {
                            MessageBox.Show("Actualización de datos fallida.");
                        }
                        break;
                    }
                case 1:
                    {
                        if (usuario == null)
                        {
                            MessageBox.Show("Registro exitoso.");
                        }
                        else
                        {
                            MessageBox.Show("Actualización de datos exitosa.");
                        }
                        salida = true;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado porfavor intente mas tarde.");
                        break;
                    }
            }

            // Cerrar Conexion
            Conexion.Close();

            // Tomamos el resutado y con un if le mostramos un mensaje al usuario
            return salida;
        }
    }
}