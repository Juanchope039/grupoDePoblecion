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

namespace PowerFit
{
    public partial class InicioDeSesion : Form
    {
        int contador = 0;
        string usuario = null;
        public InicioDeSesion()
        {
            this.SetDesktopLocation(700, 200);
            InitializeComponent();
        }

        private void Btn_iniciar_Click_1(object sender, EventArgs e)
        {
            principal();
        }
        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            this.usuario = null;
            Hide();
            MostrarRegistrarUsuario();
            contador = 0;
            Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            salirDeLaAplicacion();
        }

        private void salirDeLaAplicacion()
        {
            Hide();
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
            else
            {
                Show();
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
                    this.usuario = usuario;

                    //Ocultar Formulario Actual
                    Hide();

                    MostrarRegistrarUsuario();

                    //Reiniciar contador
                    contador=0;

                    //Abrir Formulario Actual
                    Close();
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

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            String ConsultaQuery =
                "SELECT        usuario, contrasena " +
                "FROM Usuarios " +
                "WHERE (usuario =  @usuario) AND (contrasena =  @contrasena)";//*/

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            // agregar entradas a la consulta
            Comando.Parameters.AddWithValue("@usuario",usuario);
            Comando.Parameters.AddWithValue("@contrasena",contrasena);

            // Variable de lectura de datos
            OleDbDataReader LectordeDatos;

            // Vamos a ejecutar la c¿Consulta por medio del objecto comando
            LectordeDatos = Comando.ExecuteReader();

            // Validamos Si existen existas en esta consulta
            Boolean ExistenDatos = LectordeDatos.HasRows;

            // Cerrar Conexion
            Conexion.Close();
            LectordeDatos.Close();

            // Devolvemos el resultado
            return ExistenDatos;
        }

        private void MostrarRegistrarUsuario()
        {
            if (usuario != null)
            {
                //Mostrar Formulario Siguiente
                RegistrodeDatos RegistrodeDatos = new RegistrodeDatos(usuario,true);
                if (RegistrodeDatos.fecha.ToString().Contains(DateTime.Now.ToString("d/MM/yyyy")))
                {
                    Menu menu = new Menu(usuario);
                    menu.ShowDialog();
                    menu.Close();
                }
                else
                {
                    RegistrodeDatos.ShowDialog();
                    if (RegistrodeDatos.salir)
                    {
                        RegistrodeDatos.Close();
                        Close();
                    }
                }            

                //Cerrar Formulario siguiente
                RegistrodeDatos.Close();
            }
            else
            {
                //Mostrar Formulario Siguiente
                RegistrodeUsuario RegistrodeUsuario = new RegistrodeUsuario();

                RegistrodeUsuario.ShowDialog();

                //Cerrar Formulario siguiente
                RegistrodeUsuario.Close();
            }            
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

        private void btn_pregunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Porfavor ingrese su nombre de usuario y contraseña, para iniciar seción. si no tiene un usuario porfavor de clic en 'Registrarse'."
                ,"Instrucciones",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void InicioDeSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
