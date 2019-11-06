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

namespace GrupoDePoblacion
{
    public partial class RegistrodeUsuario : Form
    {
        string usuario = " ", correo, contrasena;
        public string nombre, apellido;
        int contador = 0;
        public RegistrodeUsuario()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            salirDeLaAplicacion();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajasdeTexto();
        }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            usuario = txt_usuario.Text;
            contrasena = txt_contrasena1.Text;
            correo = txt_correo.Text;
            if (txt_usuario.Text == "" | txt_correo.Text =="" | 
                txt_contrasena1.Text == "" | txt_contrasena2.Text == "")
            {                
                contador++;
                if (contador == 3)
                {
                    MessageBox.Show("Ultimo intento por favor ingrese correctamente sus credenciales.");
                }
                else if (contador == 4)
                {
                    MessageBox.Show("Ha exedido el limite de errores, porfavor intente más tarde");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error inesperado 0xR000059");
                    Close();
                }
                MessageBox.Show("Uno o varios Campos están vacios");
            }
            else
            {
                if (CargarRegistrodeDatos())
                    CrearNuevoUsuario();
                else
                    MessageBox.Show("registro fallido, profavor intente más tarde.");                RegistraNuevoUsuario();
            }            
            Close();
        }

        private void RegistraNuevoUsuario()
        {            
            if (CargarRegistrodeDatos())
                CrearNuevoUsuario();
            else
                MessageBox.Show("registro fallido, profavor intente más tarde.");
        }


        /// <summary>
        /// carga el registro   
        /// </summary>
        /// <returns> si fue exitoso o no </returns>
        private Boolean CargarRegistrodeDatos()//muestra la segunda ventana
        {
            Hide();
            RegistrodeDatos RegistrarDatos = new RegistrodeDatos(usuario,false);
            RegistrarDatos.ShowDialog();
            if ()
            {
                nombre = RegistrarDatos.ObtenerNombre();
                apellido = RegistrarDatos.ObtenerApellido();
                RegistrarDatos.Close();
                Show();
                return !(nombre == null || apellido == null);
            }
            return false;
        }

        public void salirDeLaAplicacion()
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
                Show();
        }

        private void LimpiarCajasdeTexto()
        {
            txt_usuario.Clear();
            txt_correo.Clear();
            txt_contrasena1.Clear();
            txt_contrasena2.Clear();
            txt_usuario.Focus();
        }
        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean correo = txt_correo.Text.Contains("@");
            if (txt_correo.TextLength > 25)
            {
                MessageBox.Show("maximo 25 caracteres");
                e.Handled = true;
            }            
            else if (e.KeyChar=='@' && correo)
            {
                MessageBox.Show("Solo se puede usar un '@'");
                e.Handled = true;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            correo = null;
            if (txt_correo.TextLength != 0 && txt_correo.TextLength <= 25 && txt_correo.Text.Contains('@'))
                correo = txt_correo.Text;
            else 
            {
                if (txt_correo.TextLength == 0)
                    MessageBox.Show("El correo vacio");
                else if (txt_correo.TextLength > 25)
                    MessageBox.Show("El correo mayo a 25 caracteres");
                else if (!txt_correo.Text.Contains('@'))
                    MessageBox.Show("El correo no contiene '@'");
                txt_correo.Focus();
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            usuario = "";
            if (txt_usuario.TextLength != 0 && txt_usuario.TextLength <= 25)
                usuario = txt_usuario.Text;
            else
            {
                if (txt_usuario.Text == "")
                    MessageBox.Show("Usuario vacio");
                else if (txt_usuario.Text.Length > 25)
                    MessageBox.Show("El usuario debe contener menos de 25 caracteres");
                else if (ValidarexistenciadeUsuario())
                    MessageBox.Show("Usuario " + txt_usuario.Text + " ya existe");
                txt_usuario.Focus();
            }
        }

        private void txt_contrasena2_Leave(object sender, EventArgs e)
        {
            contrasena = null;
            if (txt_contrasena1.Text == txt_contrasena2.Text)
                contrasena = txt_contrasena1.Text;
            else
            {
                if (txt_contrasena1.TextLength == 0 || txt_contrasena2.TextLength == 0)
                    MessageBox.Show("Caja(s) de cotraseña vacia(s)");
                else if (txt_contrasena1.Text != txt_contrasena2.Text)
                    MessageBox.Show("Contraseñas no coinciden");
                else if (txt_contrasena1.TextLength > 20 || txt_contrasena2.TextLength > 20)
                    MessageBox.Show("Contraseña mayor a 20 caracteres");
                txt_contrasena1.Focus();
            }
        }


        /// <summary>
        /// Crear un nuevo registro en la base de datos
        /// </summary>
        /// <returns> devuelve si pudo crear registro </returns>
        private Boolean CrearNuevoUsuario()
        {
            Boolean salida = false;

            // Direccion de la Base de Datos
            string CadenaDeConexion = Properties.Settings.Default.ClientesConnectionString;

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            String ConsultaQuery = 
                " INSERT INTO `Usuarios` (`usuario`, `contrasena`, `nombre`, `apellido`)" +
                " VALUES (@usuario, @contraseña, @nombre, @apellido)";//*/

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            // agregar entradas a la consulta
            Comando.Parameters.AddWithValue("@usuario", usuario);
            Comando.Parameters.AddWithValue("@contrasena", contrasena);
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@apellido", apellido);

            //
            switch (Comando.ExecuteNonQuery())
            {
                case 0:
                    {
                        MessageBox.Show("Registro Falló.");
                        break;
                    }
                case 1:
                    {
                        Hide();
                        MessageBox.Show("Registro exitoso.");
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

            // Devolvemos el resultado
            return salida;
        }
        private bool ValidarexistenciadeUsuario()
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
                "WHERE (usuario =  @usuario)";//*/

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            // agregar entradas a la consulta
            Comando.Parameters.AddWithValue("@usuario", usuario);

            // Variable de lectura de datos
            OleDbDataReader LectordeDatos;

            // Vamos a ejecutar la c¿Consulta por medio del objecto comando
            LectordeDatos = Comando.ExecuteReader();

            // Validamos Si existen existas en esta consulta
            Boolean ExistenDatos = LectordeDatos.HasRows;

            // Cerrar Conexion
            Conexion.Close();
            LectordeDatos.Close();

            // Devolver resultado
            return ExistenDatos;
        }
    }
}
