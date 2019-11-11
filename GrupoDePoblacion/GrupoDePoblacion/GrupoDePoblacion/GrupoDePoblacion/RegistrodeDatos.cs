using System;
using System.Collections.Specialized;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PowerFit
{
    public partial class RegistrodeDatos : Form
    {
        public string fecha;
        string usuario, nombre, apellido, leciones, grupoSanguineo, enfermedades, discapacidades;
        int edad;
        char genero = ' ';
        double peso, altura;
        Boolean actualizacion = false;
        public Boolean salir = false;

        public RegistrodeDatos(string usuario, Boolean actualizacion)
        {
            this.usuario = usuario;
            this.actualizacion = actualizacion;
            InitializeComponent();
            test();
            if (actualizacion)
            {
                btn_salir.Visible = true;
                CargarCajasDeTexto();
                if (genero=='M')
                {
                    MessageBox.Show("Bienvenido " + nombre + " " + apellido + ".");
                }
                else if (genero  =='F')
                {
                    MessageBox.Show("Bienvenida " + nombre + " " + apellido + ".");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.");
                    Close();
                }
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCajasDeTexto();
        }

        private void btProcesar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                //Declaracion
                string grupodepoblacion = "";
                double IMC;

                //Entradas
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                edad = int.Parse(txt_edad.Text);
                peso = double.Parse(txt_peso.Text);
                altura = double.Parse(txt_altura.Text);
                if (rb_femenino.Checked)
                    genero = 'F';
                if (rb_masculino.Checked)
                    genero = 'M';
                if (genero == ' ')
                {
                    Close();
                }                    
                leciones = txt_leciones.Text;
                grupoSanguineo = cb_grupoSanguineo.Text;
                enfermedades = txt_enfermedades.Text;
                discapacidades = txt_discapacidades.Text;

                //metodos
                grupodepoblacion = grupopoblacion(edad, grupodepoblacion);
                IMC = CalcularIMC(peso, altura);

                Hide();
                Boolean RegistroGuardado = EnviaraBasedeDatos(grupodepoblacion, IMC);//Enviar a base de datos
                if (RegistroGuardado && actualizacion)
                {
                    MostrarMenu();
                    Close();
                }
                else
                    Close();

                //metodos                
                GuardarAutoCompletado();
            }            
        }

        private bool validarCampos()
        {
            if (txt_nombre.TextLength==0 | txt_apellido.TextLength == 0
                | txt_edad.TextLength == 0 | txt_peso.TextLength == 0
                | txt_altura.TextLength == 0 | txt_leciones.TextLength == 0
                | txt_peso.Text == "0,0" | txt_altura.Text == "0,0"
                | cb_grupoSanguineo.SelectedIndex == 0 | txt_enfermedades.TextLength == 0
                | txt_discapacidades.TextLength == 0 | !(rb_masculino.Checked
                | rb_femenino.Checked))
            {
                MessageBox.Show("Uno o varios campos son invalidos");
                return false;
            }
            return true;
            
        }

        private void AgregarUsuario_load(object sender, EventArgs e)
        {
            CargarAutoCompletado();
        }

        private void GuardarAutoCompletado()
        {
            // Validar no repeticion antes de guardar
            if (!PowerFit.Properties.Settings.Default.Lecciones.Contains(leciones))
                PowerFit.Properties.Settings.Default.Lecciones.Add(leciones);

            if (!PowerFit.Properties.Settings.Default.GrupoSanguineo.Contains(grupoSanguineo))
                PowerFit.Properties.Settings.Default.GrupoSanguineo.Add(grupoSanguineo);

            if (!PowerFit.Properties.Settings.Default.Enfermedades.Contains(enfermedades))
                PowerFit.Properties.Settings.Default.Enfermedades.Add(enfermedades);

            if (!PowerFit.Properties.Settings.Default.Discapacidades.Contains(discapacidades))
                PowerFit.Properties.Settings.Default.Discapacidades.Add(discapacidades);

            PowerFit.Properties.Settings.Default.Save();
        }

        private double CalcularIMC(double peso, double altura)
        {
            string imc = (peso / (altura * altura)).ToString();
            return double.Parse(imc.Substring(0,imc.IndexOf(',')+2));
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
            txt_leciones.AutoCompleteCustomSource = Autocompletar(PowerFit.Properties.Settings.Default.Lecciones);
            txt_enfermedades.AutoCompleteCustomSource = Autocompletar(PowerFit.Properties.Settings.Default.Enfermedades);
            txt_discapacidades.AutoCompleteCustomSource = Autocompletar(PowerFit.Properties.Settings.Default.Discapacidades);
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
            cb_grupoSanguineo.SelectedIndex = 0;
            txt_enfermedades.Clear();
            txt_discapacidades.Clear();
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                if (txt_edad.Text != "" && e.KeyChar != '\b')
                {
                    string al = txt_edad.Text + e.KeyChar;
                    int edad = int.Parse(al);
                    if (edad < 0)
                    {
                        MessageBox.Show("La edad no puede ser negativa.");
                        e.Handled = true;
                    }
                    else if (edad > 150)
                    {
                        MessageBox.Show("La edad no puede ser mayor a 150 años.");
                        e.Handled = true;
                    }
                    else
                        e.Handled = false;
                }
            }
            else
            {
                MessageBox.Show("no se aceptan digitos no numericos");
                e.Handled = true;
            }
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean punto = ! txt_peso.Text.Contains(",");//controlar mas de dos caracteres despues del punto
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) | (e.KeyChar == ',' & punto))
            {
                if ((txt_peso.Text != "" | txt_peso.Text != "0,0") && e.KeyChar != '\b' & txt_peso.Text + e.KeyChar != ",")
                {
                    double peso= double.Parse(txt_peso.Text + e.KeyChar);
                    if (peso < 0)
                    {
                        MessageBox.Show("El peso no puede ser negativo.");
                        e.Handled = true;
                    }
                    else if (peso > 250)
                    {
                        MessageBox.Show("Ha exedido el peso permitido (250) por la aplicación.");
                        e.Handled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("no se aceptan digitos no numericos y solo una coma");
                e.Handled = true;
            }
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                if ((txt_altura.Text != "" | txt_altura.Text != "0") & e.KeyChar !='\b')
                {
                    double altura = double.Parse(txt_altura.Text + e.KeyChar);
                    if (altura < 0)
                    {
                        MessageBox.Show("La altura no puede ser negativo.");
                        e.Handled = true;
                    }else if (altura > 300)
                        MessageBox.Show("La altura no puede superar los 3 metros (300cm)");
                }
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("no se aceptan digitos no numericos");
                e.Handled = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            salirDeLaAplicacion();
        }

        private void btn_atras_Click_1(object sender, EventArgs e)
        {
            if (actualizacion)
            {
                nombre = null;
                apellido = null;
            }
            Close();
        }

        /// <summary>
        /// Hace una verificacion en busca de variables vacias y las inicializa
        /// </summary>
        private void test()
        {
            if (PowerFit.Properties.Settings.Default.Lecciones == null)
                PowerFit.Properties.Settings.Default.Lecciones = new StringCollection();

            if (PowerFit.Properties.Settings.Default.GrupoSanguineo == null)
                PowerFit.Properties.Settings.Default.GrupoSanguineo = new StringCollection();

            if (PowerFit.Properties.Settings.Default.Enfermedades == null)
                PowerFit.Properties.Settings.Default.Enfermedades = new StringCollection();

            if (PowerFit.Properties.Settings.Default.Discapacidades == null)
                PowerFit.Properties.Settings.Default.Discapacidades = new StringCollection();
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
            }//*/
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_nombre.TextLength > 30)
            {
                MessageBox.Show("Maximo deben haber 30 caracteres");
                txt_nombre.Focus();
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_apellido.TextLength > 30)
            {
                MessageBox.Show("Maximo deben haber 30 caracteres.");
                txt_apellido.Focus();
                e.Handled = true;
            }
        }

        private void txt_nombre_Leave_1(object sender, EventArgs e)
        {
            if (txt_nombre.TextLength < 3 & txt_nombre.Text != "")
            {
                MessageBox.Show("minimo deben haber 3 caracteres");
                txt_nombre.Focus();
            }
        }

        private void btn_pregunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("por favor llene los campos en blanco para poder completar su informacion personal."
                , "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void txt_peso_Leave(object sender, EventArgs e)
        {
            if ((txt_peso.Text != "" | txt_peso.Text != "0,0"))
            {
                if (double.Parse(txt_peso.Text) < 35)
                {
                    MessageBox.Show("El peso no puede ser menor a 35Kg");
                    txt_peso.Focus();
                }
            }
        }

        private void txt_altura_Leave(object sender, EventArgs e)
        {
            if (txt_altura.Text != "")
            {
                if (int.Parse(txt_altura.Text) < 120)
                {
                    MessageBox.Show("La altura no puede ser menor a 120cm");
                    txt_peso.Focus();
                }
            }
        }

        private void txt_apellido_Leave_1(object sender, EventArgs e)
        {
            if (txt_apellido.TextLength < 4 & txt_apellido.Text != "")
            {
                MessageBox.Show("Minimo deben haber 4 caracteres.");
                txt_apellido.Focus();
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

            // Desabilita las cajas de texto para que no puedan ser modificadas
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_edad.Enabled = false;
            cb_grupoSanguineo.Enabled = false;
            rb_masculino.Enabled = false;
            rb_femenino.Enabled = false;

            if (Datos != null)
            {
                nombre = Datos[0];
                apellido = Datos[1];
                edad = int.Parse(Datos[2]);
                peso = double.Parse(Datos[3]);
                altura = double.Parse(Datos[4]);
                leciones = Datos[5];
                grupoSanguineo = Datos[6];
                enfermedades = Datos[7];
                discapacidades = Datos[8];
                genero = char.Parse(Datos[9]);
                fecha = Datos[10];

                txt_nombre.Text = nombre;
                txt_apellido.Text = apellido;
                txt_edad.Text = edad.ToString();
                txt_peso.Text = peso.ToString();
                txt_altura.Text = altura.ToString();
                txt_leciones.Text = leciones;
                cb_grupoSanguineo.Text = grupoSanguineo;
                txt_enfermedades.Text = enfermedades;
                txt_discapacidades.Text = discapacidades;
                if (genero == 'M')
                {
                    rb_masculino.Checked = true;
                }
                else if (genero == 'F')
                {
                    rb_femenino.Checked = true;
                }
            }
        }

        private void MostrarMenu()
        {
            Menu Menu = new Menu(usuario);
            Menu.ShowDialog();
        }

        private string[] CargarDatos()
        {
            //declaracion de salida
            string[] SalidadeDatos;

            // Direccion de la Base de Datos
            string CadenaDeConexion = PowerFit.Properties.Settings.Default.ClientesConnectionString;

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            String ConsultaQuery =
                /*"SELECT nombre, apellido FROM Usuarios WHERE(usuario = @usuario)";//*/
                " SELECT  Usuarios.nombre, Usuarios.apellido, Perfil.edad, Perfil.peso, Perfil.altura, Perfil.leciones, Perfil.[grupo sanguineo], Perfil.enfermedades, Perfil.discapacidades, Perfil.genero, Perfil.fecha, Perfil.[grupo de poblacion], Perfil.imc" +
                " FROM (Perfil INNER JOIN Usuarios ON Perfil.usuario = Usuarios.usuario) " +
                " WHERE (Usuarios.usuario = @usuario)";

            // crear un objecto comando para efectuar la consulta
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            //agregar entrada a la base de datos
            Comando.Parameters.AddWithValue("@usuario", usuario);

            // Variable de lectura de datos
            OleDbDataReader LectordeDatos;

            // Vamos a ejecutar la c¿Consulta por medio del objecto comando
            LectordeDatos = Comando.ExecuteReader();

            SalidadeDatos = new string[LectordeDatos.FieldCount];

            // Validamos Si existen existas en esta consulta
            if (LectordeDatos.HasRows)
            {
                LectordeDatos.Read();
                for (int i = 0; i < SalidadeDatos.Length; i++)
                {
                    SalidadeDatos[i] = LectordeDatos[i].ToString();
                }
                SalidadeDatos[10]= "                ";
                do
                {
                    if (LectordeDatos[10].ToString().Contains(DateTime.Now.ToString("d/MM/yyyy")))
                    {
                        SalidadeDatos[10] = LectordeDatos[10].ToString();
                        break;
                    }
                } while (LectordeDatos.Read());
            }
            else
            {
                MessageBox.Show("Ha ocurriod un error inesperado");
                Enabled = false;
                return null;
            }

            // Cerrar Conexion
            Conexion.Close();
            LectordeDatos.Close();

            // Devolvemos el resultado
            return SalidadeDatos;
        }

        private Boolean EnviaraBasedeDatos(string grupodepoblacion, double imc)
        {
            //Declaración de variables
            string fecha = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss");
            if (usuario == null)
                MessageBox.Show("Error");
            Boolean salida = false;

            // Direccion de la Base de Datos
            string CadenaDeConexion = Properties.Settings.Default.ClientesConnectionString;

            // crear una conexion con la base de datos
            OleDbConnection Conexion = new OleDbConnection(CadenaDeConexion);

            // Iniciar la conexion con la base de datos
            Conexion.Open();

            // crear la consulta (Query)
            string ConsultaQuery = "INSERT INTO Perfil "
                + " (usuario, edad, peso, altura, genero, leciones, [grupo sanguineo], enfermedades, discapacidades, [grupo de poblacion], imc, fecha)"
                + " VALUES (@usuario, @edad, @peso, @altura, @genero, @leciones, @grupoSanguineo, @enfermedades," + " @discapacidades, @grupodepoblacion, @imc, @fecha)";

            // crear un objecto comando para efectuar la consulta//*/
            OleDbCommand Comando = new OleDbCommand(ConsultaQuery, Conexion);

            Comando.Parameters.AddWithValue("usuario", usuario);
            Comando.Parameters.AddWithValue("@edad", edad);
            Comando.Parameters.AddWithValue("@peso", peso);
            Comando.Parameters.AddWithValue("@altura", altura);
            Comando.Parameters.AddWithValue("@genero",genero);
            Comando.Parameters.AddWithValue("@leciones", leciones);
            Comando.Parameters.AddWithValue("@grupoSanguineo", grupoSanguineo);
            Comando.Parameters.AddWithValue("@enfermedades", enfermedades);
            Comando.Parameters.AddWithValue("@discapacidades", discapacidades);
            Comando.Parameters.AddWithValue("@grupodepoblacion", grupodepoblacion);
            Comando.Parameters.AddWithValue("@imc", imc);
            Comando.Parameters.AddWithValue("@fecha", fecha);//*/

            // validar datos
            switch (Comando.ExecuteNonQuery())
            {
                case 0:
                    {
                        if (!actualizacion)
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
                        if (actualizacion)
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

        public string ObtenerNombre()
        {
            return nombre;
        }

        public string ObtenerApellido()
        {
            return apellido;
        }
    }
}