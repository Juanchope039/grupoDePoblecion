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

            CargarCBA();
            cb_inicio_anno.Text = annoActual.ToString();
            
            CargarCBM();
            cb_inicio_mes.Text = meses[int.Parse(DateTime.Now.ToString("MM")) - 1];

            CargarChart();
        }

        private void CargarCBA()
        {
            cb_inicio_anno.Items.Clear();
            cb_inicio_anno.Items.Add("Ingrese el año a mostrar");
            for (int i = 2019; i <= annoActual; i++)
            {
                cb_inicio_anno.Items.Add(i);
            }
        }

        private void CargarChart()
        {
            if (cb_inicio_anno.SelectedIndex == 0 | cb_inicio_mes.SelectedIndex == 0)
                MessageBox.Show("No ha elegido un año valido.");
            else
            {
                lb_peso.Text = "Grafico de peso(Kg) de " + cb_inicio_anno.SelectedItem.ToString();
                lb_altura.Text = "Grafico de altura(cm) de " + cb_inicio_anno.SelectedItem.ToString();
                lb_imc.Text = "Grafico de IMC de " + cb_inicio_anno.SelectedItem.ToString();

                double[] Pesos = new double[dgv_Informe.Rows.Count],
                    Alturas = new double[dgv_Informe.Rows.Count],
                    Imcs = new double[dgv_Informe.Rows.Count];
                string[] Fechas = new string[Pesos.Length];
                string mess = "*";
                foreach (string m in meses)
                    if (m == cb_inicio_mes.Text)
                        mess = cb_inicio_mes.Text;

                ct_Peso_Anno.Series.Clear();
                ct_Altura_anno.Series.Clear();
                ct_imc_anno.Series.Clear();

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

                for (int k = 2019; k <= annoActual; k++) 
                    for(int j = 1; j <= 12; j++)
                        for (int i = 0; i < Pesos.Length; i++)
                        {
                            string dia = Fechas[i].Substring(0, Fechas[i].IndexOf('/')),
                                mes = Fechas[i].Substring(Fechas[i].IndexOf('/') + 1, 2),
                                anno = Fechas[i].Substring(Fechas[i].LastIndexOf('/')+1,4); 
                            if (int.Parse(mes) != j | int.Parse(anno)!=k)
                                continue;

                            if (k.ToString() == cb_inicio_anno.Text)
                                if (meses[j-1] == mess | mess == "*") 
                                {
                                    string leyenda = "";/*
                                    if (cb_inicio_anno.SelectedItem.ToString() == cb_fin_anno.SelectedItem.ToString())
                                        leyenda = meses[int.Parse(mes) - 1];
                                    else//*/
                                        leyenda = meses[int.Parse(mes) - 1] + "/" + k;
                                    if (ct_Peso_Anno.Series.IndexOf(leyenda) == -1)
                                    {
                                        ct_Peso_Anno.Series.Add(leyenda);
                                        ct_Altura_anno.Series.Add(leyenda);
                                        ct_imc_anno.Series.Add(leyenda);/*
                                        ct_Peso_Anno.Series[leyenda].ChartType = Datav 10;
                                        ct_Altura_anno.Series[leyenda].ChartType = 10;
                                        ct_imc_anno.Series[leyenda].ChartType = 10;//*/
                                    }
                                    ct_imc_anno.Series[leyenda].Points.AddXY(meses[int.Parse(mes) - 1] + "/ " + dia, Imcs[i]);

                                    ct_Altura_anno.Series[leyenda].Points.AddXY(meses[int.Parse(mes) - 1] + "/ " + dia, Alturas[i]);

                                    ct_Peso_Anno.Series[leyenda].Points.AddXY(meses[int.Parse(mes) - 1] + "/ " + dia, Pesos[i]);
                                }
                        }
            }
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

        private void cb_inicio_anno_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CargarCBM()
        {
            cb_inicio_mes.Items.Clear();
            cb_inicio_mes.Items.Add("Ingrese el Mes a mostrar");
            string[] Fechas = new string[dgv_Informe.Rows.Count];
            for (int i = 0; i < dgv_Informe.Rows.Count; i++)
            {
                Fechas[i] = dgv_Informe.Rows[i].Cells[3].Value.ToString().Substring(0, 10);
                string mes = Fechas[i].Substring(Fechas[i].IndexOf('/') + 1, 2),
                                anno = Fechas[i].Substring(Fechas[i].LastIndexOf('/') + 1, 4);
                if (anno == cb_inicio_anno.SelectedItem.ToString())
                    if (cb_inicio_mes.Items.IndexOf(meses[int.Parse(mes) - 1]) == -1)
                        cb_inicio_mes.Items.Add(meses[int.Parse(mes) - 1]);
            }
            cb_inicio_mes.Items.Add("Mostrar un resumen de todos los meses");
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
