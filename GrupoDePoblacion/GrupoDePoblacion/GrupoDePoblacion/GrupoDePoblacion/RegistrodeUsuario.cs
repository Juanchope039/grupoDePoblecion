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

namespace PowerFit
{
    public partial class RegistrodeUsuario : Form
    {
        string usuario = " ", correo, contrasena;
        public string nombre, apellido;
        int contador = 0;
        public RegistrodeUsuario()
        {
            this.SetDesktopLocation(600, 200);
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
            if (txt_usuario.Text == "" | txt_correo.Text == "" |
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
                {
                    CrearNuevoUsuario();
                    Close();
                }
                else
                    MessageBox.Show("registro fallido");
            }
        }


        /// <summary>
        /// carga el registro   
        /// </summary>
        /// <returns> si fue exitoso o no </returns>
        private Boolean CargarRegistrodeDatos()//muestra la segunda ventana
        {
            Hide();
            RegistrodeDatos RegistrarDatos = new RegistrodeDatos(usuario, false);
            RegistrarDatos.ShowDialog();
            //if (!RegistrarDatos.salir)//
            //{
            nombre = RegistrarDatos.ObtenerNombre();
            apellido = RegistrarDatos.ObtenerApellido();
            RegistrarDatos.Close();
            Show();
            return !(nombre == null || apellido == null);
            //}
            //return false;
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
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else
            {
                Boolean correo = txt_correo.Text.Contains("@");
                if (txt_correo.TextLength > 35 & e.KeyChar != '\b')
                {
                    MessageBox.Show("maximo 35 caracteres");
                    e.Handled = true;
                }
                else if (e.KeyChar == '@' && correo)
                {
                    MessageBox.Show("Solo se puede usar un '@'");
                    e.Handled = true;
                }
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else if ((txt_usuario.Text + e.KeyChar).Length > 20 & e.KeyChar != '\b')
            {
                MessageBox.Show("El usuario no puede ser mayor a 20 caracteres.");
                e.Handled = true;
            }
        }

        private void txt_contrasena2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txt_contrasena2.Text + e.KeyChar).Length > 15 & e.KeyChar != '\b')
            {
                MessageBox.Show("La contraseña no puede ser mayor a 15 caracteres.");
                e.Handled = true;
            }
        }
        private void txt_contrasena1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txt_contrasena1.Text + e.KeyChar).Length > 15 & e.KeyChar != '\b')
            {
                MessageBox.Show("La contraseña no puede ser mayor a 15 caracteres.");
                e.Handled = true;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text != "")
            {
                if (!txt_correo.Text.Contains("@"))
                {
                    MessageBox.Show("Debe ingresar porlomenos un '@'");
                    txt_correo.Focus();
                }
                else if (txt_correo.TextLength < 4)
                {
                    MessageBox.Show("El correo no debe ser menora a 4 caracteres");
                    txt_correo.Focus();
                }
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.TextLength != 0)
            {
                if (txt_usuario.TextLength < 5)
                {
                    MessageBox.Show("El usuario no puede ser menor a 5 caracteres");
                    txt_usuario.Focus();
                }
                else if (ValidarexistenciadeUsuario())
                {
                    MessageBox.Show("Usuario " + txt_usuario.Text + " ya existe");
                    txt_usuario.Focus();
                }
            }
        }

        private void txt_contrasena1_Leave(object sender, EventArgs e)
        {
            if (txt_contrasena1.TextLength < 8 & txt_contrasena1.Text != "")
            {
                MessageBox.Show("La contraseña debe ser mayor a 8 caracteres");
                txt_contrasena1.Focus();
            }
        }

        private void txt_contrasena2_Leave(object sender, EventArgs e)
        {
            if (txt_contrasena2.TextLength < 8 & txt_contrasena2.Text != "")
            {
                MessageBox.Show("La contraseña debe ser mayor a 8 caracteres");
                txt_contrasena2.Focus();
            }
            else if (txt_contrasena1.Text != txt_contrasena2.Text)
            {
                MessageBox.Show("Contraseñas no coinciden");
                txt_contrasena1.Focus();
            }
        }

        private void btn_pregunta_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("para registrarse, ingrese los datos requeridos en los campos en blanco y dar click en el boton \"siguiente\"."
                , "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                " INSERT INTO `Usuarios` (`usuario`, `contrasena`, `nombre`, `apellido`, `correo`)" +
                " VALUES (@usuario, @contraseña, @nombre, @apellido, @correo)";//*/

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            // agregar entradas a la consulta
            Comando.Parameters.AddWithValue("@usuario", usuario);
            Comando.Parameters.AddWithValue("@contrasena", contrasena);
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@apellido", apellido);
            Comando.Parameters.AddWithValue("@correo", correo);

            //verificacion de fallos y correcto funcionamiemto
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
            string CadenaDeConexion = PowerFit.Properties.Settings.Default.ClientesConnectionString;

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
            Comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);

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
