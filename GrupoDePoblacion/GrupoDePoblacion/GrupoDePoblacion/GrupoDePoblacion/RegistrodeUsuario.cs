﻿using System;
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
        string usuario, correo, contrasena;
        public string nombre, apellido;
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
            if (validarusuario() && validarcorreo() && validarcontrasena())
            {
                Boolean registro = CargarRegistrodeDatos();
                if (registro)
                {
                    CrearNuevoUsuario();
                    Close();
                }
                else
                {
                    MessageBox.Show("registro fallido, profavor intente más tarde.");
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Error uno o varias cajas de texto están vacias.");
            }
        }

        private Boolean CrearNuevoUsuario()//Crea el nuevo registro en la base de datos
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
                " INSERT INTO `Usuarios` (`usuario`, `contrasena`, `apellido`, `nombre`)" +
                " VALUES (@usuario, @contraseña, @apellido, @nombre)";//*/

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

        private Boolean CargarRegistrodeDatos()//muestra la segunda ventana
        {
            Hide();
            RegistrodeDatos RegistrarDatos = new RegistrodeDatos(usuario,false);
            RegistrarDatos.ShowDialog();
            nombre = RegistrarDatos.ObtenerNombre();
            apellido = RegistrarDatos.ObtenerApellido();
            Show();
            return !(nombre == null || apellido == null);
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

        private void LimpiarCajasdeTexto()
        {
            txt_usuario.Clear();
            txt_correo.Clear();
            txt_contrasena1.Clear();
            txt_contrasena2.Clear();
            txt_usuario.Focus();
        }

        private Boolean validarusuario()
        {
            if (txt_usuario.TextLength != 0 && txt_usuario.TextLength <= 25)
            {
                usuario = txt_usuario.Text;
                return true;
            }                    
            usuario = null;
            return false;
        }

        private Boolean validarcorreo()
        {
            if (txt_correo.TextLength != 0 && txt_correo.TextLength <= 25 && txt_correo.Text.Contains('@'))
            {
                correo = txt_correo.Text;
                return true;
            }           
            correo = null;
            return false;
        }

        private Boolean validarcontrasena()
        {
            if (txt_contrasena1.TextLength == 0 || txt_contrasena1.TextLength > 20 ||
                txt_contrasena2.TextLength == 0 || txt_contrasena2.TextLength > 20 ||
                txt_contrasena1.Text != txt_contrasena2.Text)
            {
                contrasena = null;
                return false;
            }
            contrasena = txt_contrasena1.Text;
            return true;
        }

    }
}