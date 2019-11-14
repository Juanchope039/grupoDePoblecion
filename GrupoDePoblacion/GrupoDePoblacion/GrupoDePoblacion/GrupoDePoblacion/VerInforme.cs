using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PowerFit
{
    public partial class VerInforme : Form
    {
        string usuario;
        int annoActual = DateTime.Now.Year;
        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        public VerInforme(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void VerInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Perfil' Puede moverla o quitarla según sea necesario.
            this.perfilTableAdapter.Estadisticas(this.clientesDataSet.Perfil, usuario);
            
            cb_inicio_mes.Text = meses[int.Parse(DateTime.Now.ToString("MM")) - 1];

            CargarChart();
        }

        private void CargarChart()
        {
            pb_carga.Value = 0;
            pb_carga.Visible = true;

            if (cb_inicio_mes.SelectedIndex == 0)
                MessageBox.Show("No ha elegido un año valido.");
            else
            {
                lb_peso.Text = "Grafico de peso(Kg) de " + annoActual.ToString();
                lb_altura.Text = "Grafico de altura(cm) de " + annoActual.ToString();
                lb_imc.Text = "Grafico de IMC de " + annoActual.ToString();

                pb_carga.Value += 1;

                double[] Pesos = new double[dgv_Informe.Rows.Count],
                    Alturas = new double[dgv_Informe.Rows.Count],
                    Imcs = new double[dgv_Informe.Rows.Count];
                string[] Fechas = new string[Pesos.Length];
                string mess = "*";
                foreach (string m in meses)
                    if (m == cb_inicio_mes.Text)
                        mess = cb_inicio_mes.Text;

                pb_carga.Value += 1;

                ct_Peso_Anno.Series.Clear();
                ct_Altura_anno.Series.Clear();
                ct_imc_anno.Series.Clear();

                pb_carga.Value += 1;

                for (int i = 0; i < Pesos.Length; i++)
                {
                    Pesos[i] = double.Parse(dgv_Informe.Rows[i].Cells[0].Value.ToString());
                    Alturas[i] = double.Parse(dgv_Informe.Rows[i].Cells[1].Value.ToString());
                    Imcs[i] = double.Parse(dgv_Informe.Rows[i].Cells[2].Value.ToString());
                    Fechas[i] = dgv_Informe.Rows[i].Cells[3].Value.ToString().Substring(0,10);

                    string dia = Fechas[i].Substring(0, Fechas[i].IndexOf('/')),
                                mes = Fechas[i].Substring(Fechas[i].IndexOf('/') + 1, 2),
                                anno = Fechas[i].Substring(Fechas[i].LastIndexOf('/') + 1, 4);

                }

                pb_carga.Value += 1;

                for(int j = 1; j <= 12; j++)
                    for (int i = 0; i < Pesos.Length; i++)
                    {
                        string dia = Fechas[i].Substring(0, Fechas[i].IndexOf('/')),
                            mes = Fechas[i].Substring(Fechas[i].IndexOf('/') + 1, 2),
                            anno = Fechas[i].Substring(Fechas[i].LastIndexOf('/')+1,4); 
                        if (int.Parse(mes) != j | anno != annoActual.ToString())
                            continue;

                            if (meses[j-1] == mess | mess == "*") 
                            {
                                string leyenda = meses[int.Parse(mes) - 1];
                                if (ct_Peso_Anno.Series.IndexOf(leyenda) == -1)
                                {
                                    ct_Peso_Anno.Series.Add(leyenda);
                                    ct_Altura_anno.Series.Add(leyenda);
                                    ct_imc_anno.Series.Add(leyenda);
                                }
                                ct_imc_anno.Series[leyenda].Points.AddXY(meses[int.Parse(mes) - 1] + "/ " + dia, Imcs[i]);

                                ct_Altura_anno.Series[leyenda].Points.AddXY(meses[int.Parse(mes) - 1] + "/ " + dia, Alturas[i]);

                                ct_Peso_Anno.Series[leyenda].Points.AddXY(meses[int.Parse(mes) - 1] + "/ " + dia, Pesos[i]);
                            }
                    }
                pb_carga.Value += 1;
            }
            pb_carga.Visible = false;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            CargarChart();
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
