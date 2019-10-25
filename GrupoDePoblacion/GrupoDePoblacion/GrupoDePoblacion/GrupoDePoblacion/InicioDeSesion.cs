using System;
using System.Collections.Generic;
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
    public partial class InicioDeSesion : Form
    {
        int contador = 0;
        string[] Nuevos_Usuarios = new string[0];
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void Btn_iniciar_Click_1(object sender, EventArgs e)
        {
            principal();
        }
        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            MostrarRegistrarUsuario(null);
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            salirDeLaAplicacion();
        }

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
        /// Esé Algoritmo se encarga de validar de diferentes formas las credenciales del usuario
        /// </summary>
        private void principal()
        {
            // Declaración de cariables
            contador++;
            Boolean validar;
            string usuario=txt_usuario.Text, contrasena = txt_contrasena.Text;

            // Validar errores y controlar intentos de repetición
            if (contador == 3)
            {
                MessageBox.Show("Ultimo intento porfavor ingrse sús credenciales correctamente.");
            }

            if (usuario.Length == 0 || contrasena.Length == 0)
            {
                MessageBox.Show("Caja(s) vacia(s), por favor ingrese credenciales");
            }
            else 
            {
                validar =  ValidarUsuario(usuario, contrasena);
                if (validar)
                {
                    MessageBox.Show("Inicio de Sesión Sactisfactorio.");
                    MostrarRegistrarUsuario(capturarUsuario(usuario));
                }
                else if (!validar && contador > 3)
                {
                    MessageBox.Show("Ha exedido el número de intentos permitidos, porfavor intente nuevamente más tarde.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Credencial incorrecta, por favor intente nuevamente.");
                }           
            }
            limpiarCajas();
        }

        private string capturarUsuario(string usuario)
        {
            return "";
        }

        /// <summary>
        /// Éste metodo Limpia todas las cajas de texto del programa
        /// </summary>
        private void limpiarCajas()
        {
            txt_usuario.Clear();
            txt_contrasena.Clear();
            txt_usuario.Focus();
        }

        /// <summary>
        /// Éste metodo  valida si un usuario existe o no.
        /// </summary>
        /// <param name="usuario">
        /// Aqui va el usuario a validar.
        /// </param>
        /// <param name="contrasena">
        /// Aqui va la contraseña del usuario.
        /// </param>
        private Boolean ValidarUsuario(string usuario, string contrasena)
        {
            // Direccion de la Base de Datos
            string CadenaDeConexion = Properties.Settings.Default.ClientesConnectionString;
            ///    "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\ASUS\\source\repos\\Mi primer loguin en CShart\\Mi primer loguin en CShart\\Clientes.mdb";
            ///    "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = d:\\ASUS\\Documentos\\Clientes.mdb; Persist Security Info=False;";

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            String ConsultaQuery =
                "SELECT        usuario, contrasena " +
                "FROM Usuarios " +
                "WHERE (usuario =  '" + usuario + "') AND (contrasena =  '" + contrasena + "')";//*/

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            // Variable de lectura de datos
            OleDbDataReader LectordeDatos;

            // Vamos a ejecutar la c¿Consulta por medio del objecto comando
            LectordeDatos = Comando.ExecuteReader();

            // Validamos Si existen existas en esta consulta
            Boolean ExistenDatos = LectordeDatos.HasRows;

            // Cerrar Conexion
            Conexion.Close();

            // Tomamos el resutado y con un if le mostramos un mensaje al usuario
            if (ExistenDatos)
            {
                return true;
            }
            return false;
        }

        private void MostrarRegistrarUsuario(string usuario)
        {
            //Ocultar Formulario Actual
            Hide();

            //Mostrar Formulario Siguiente
            AgregarUsuario AgregarUsuario = new AgregarUsuario();
            if (usuario != null)
            {
                AgregarUsuario.CargarCajasDeTexto(usuario);
            }
            AgregarUsuario.ShowDialog();

            //Cerrar Formulario siguiente
            AgregarUsuario.Close();

            //Abrir Formulario Actual
            Show();

        }

        private void Ckb_mo_contrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_mo_contrasena.CheckState == CheckState.Checked)
            {
                ckb_mo_contrasena.Text = "Ocultar Contraseña";

            }
            else if (ckb_mo_contrasena.CheckState == CheckState.Unchecked)
            {
                ckb_mo_contrasena.Text = "Mostrar Contraseña";
            }
            txt_contrasena.UseSystemPasswordChar = !ckb_mo_contrasena.Checked;
        }
    }
}
