using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerFit
{
    public partial class Menu : Form
    {
        string usuario;

        public Menu(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btn_verInforme_Click(object sender, EventArgs e)
        {
            Hide();
            VerInforme verInforme = new VerInforme(usuario);
            verInforme.ShowDialog();
            verInforme.Close();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
