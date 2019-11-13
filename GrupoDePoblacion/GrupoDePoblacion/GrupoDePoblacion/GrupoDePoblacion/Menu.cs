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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_recomendacionesAlimenticias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desnutricion: Carbohidrato: cereal, fruta, huevo.  \n Bebida no procesada: Chocolate, café ó jugo natural \n Media mañana: Avena o yogurt y galleta o un snack ligero. \n Almuerzo: Una harina ó dos, papa, pasta Ó arroz. \n Legumbres o sopa. \n Proteína: Pollo, carne, pescado Ó atún y ensalada o fruta. \n Media tarde: Bebida: Leche, yogurt ó jugo con un snack ligero, cómo: Galletas, cereal ó frutas. \n Cena: Carbohidratos: Arroz, pan ó pasta, proteína y ensalada.\n Normal: Desayuno: Carbohidrato: Cereal, fruta, huevo ó sandwich. \n Bebida: Café, jugo ó chocolate (nada procesado) \n Media mañana: Un snack ligero sin demasiada azúcar, y evitar bebidas procesadas. \n Almuerzo: Una harina: Papá, pasta ó arroz, legumbres o sopa, una proteína: Carne, pollo, pescado, ensalada y bebida. \n Media tarde: snack ligero sin demasiada azúcar y una babida. \n Cena: Una harina, una proteína y bebida. \n Obesidad: Desayuno: Huevo, fruta, bebida citrica. \n Media mañana: Agua, galletas libres de grasas o carbohidratos, o fruta. \n Almuerzo: Un carbohidrato:  (Una cucharada) papa, arroz (si es integral es mejor), pescado o pollo asado como proteina, verduras. De bebida agua o jugo cítrico, ensalada. \n Media tarde: Agua, galletas libres de grasas o carbohidratos o fruta.  \n Cena: Ensalada y una proteína: Pescado o pollo asado.");
        }

        private void btn_recomendacionesRutinas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desnutrición (para aumentar la masa muscular): Estiramiento, 2 repeticiones de 10 sentadillas con peso muerto, 2 sesiones de 10 abdominales, ejercicio de pantorrilla durante 15 minutos (descanso de 30 segundos entre cada minuto), 30 abdominales tocando el pie y por último estirar. \n Normal: Estirar, 20 minutos de cardio, 2 sesiones de 20 sentadillas, 2 sesiones de 20 abdominales, 10 minutos saltando lazo y estirar. \n Sobrepeso: Estirar, 40 minutos de cardio, un circuito de cuatro repeticiones con 20 sentadillas, 20 jumping jack, 30 segundos de skipping, 30 minutos saltando lazo y estirar.");
        }
    }
}
