﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PowerFit
{
    public partial class VerInforme : Form
    {
        string usuario;
        int annoActual = DateTime.Now.Year;

        public VerInforme(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void VerInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Perfil' Puede moverla o quitarla según sea necesario.
            this.perfilTableAdapter.Estadisticas(this.clientesDataSet.Perfil, usuario);
            CargarCB();
            cb_anno.Text = annoActual.ToString();
            CargarChart();
        }

        private void CargarCB()
        {
            cb_anno.Items.Add("Ingrese el año a mostrar");
            for (int i = 2019; i <= annoActual; i++)
            {
                cb_anno.Items.Add(i);
            }  
        }

        private void CargarChart()
        {
            if (cb_anno.SelectedIndex == 0)
                MessageBox.Show("No ha elegido un año valido.");
            else
                lb_peso.Text = "Grafico del peso en " + cb_anno.SelectedItem.ToString();
            double[] Pesos = new double[dgv_Informe.Rows.Count],
                Alturas = new double[dgv_Informe.Rows.Count],
                Imcs = new double[dgv_Informe.Rows.Count];
            string[] Fechas = new string[Pesos.Length],
                meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            ct_Peso.Series.Clear();
            ct_Peso_Anno.Series.Clear();
            ct_Altura.Series.Clear();
            ct_Altura_anno.Series.Clear();
            ct_imc.Series.Clear();
            ct_imc_anno.Series.Clear();

            for (int i = 0; i < Pesos.Length; i++)
            {
                Pesos[i] = double.Parse(dgv_Informe.Rows[i].Cells[0].Value.ToString());
                Alturas[i] = double.Parse(dgv_Informe.Rows[i].Cells[1].Value.ToString());
                Imcs[i] = double.Parse(dgv_Informe.Rows[i].Cells[2].Value.ToString());
                Fechas[i] = dgv_Informe.Rows[i].Cells[3].Value.ToString().Substring(0,10);
            }

            for (int k = 2019; k <= annoActual; k++) 
            {
                for(int j = 1; j <= 12; j++)
                {
                    for (int i = 0; i < Pesos.Length; i++)
                    {
                        string dia = Fechas[i].Substring(0, Fechas[i].IndexOf('/')),
                            mes = Fechas[i].Substring(Fechas[i].IndexOf('/') + 1, 2),
                            anno = Fechas[i].Substring(Fechas[i].LastIndexOf('/')+1,4); 
                        if (int.Parse(mes) != j | int.Parse(anno)!=k)
                            continue;

                        if (ct_Peso.Series.IndexOf(anno).ToString() == "-1")
                        {
                            ct_Peso.Series.Add(anno);
                            ct_Altura.Series.Add(anno);
                            ct_imc.Series.Add(anno);
                        }

                        if (k.ToString() == cb_anno.Text)
                        {
                            if (ct_Peso_Anno.Series.IndexOf(meses[int.Parse(mes)-1]).ToString() == "-1")
                            {
                                ct_Peso_Anno.Series.Add(meses[int.Parse(mes) - 1]);
                                ct_Altura_anno.Series.Add(meses[int.Parse(mes) - 1]);
                                ct_imc_anno.Series.Add(meses[int.Parse(mes) - 1]);
                            }

                            ct_imc_anno.Series[meses[int.Parse(mes) - 1]].Points.AddXY(mes + "/ " + dia, Imcs[i]);

                            ct_Altura_anno.Series[meses[int.Parse(mes) - 1]].Points.AddXY(mes + "/ " + dia, Alturas[i]);

                            ct_Peso_Anno.Series[meses[int.Parse(mes)-1]].Points.AddXY(mes + "/ " + dia, Pesos[i]);
                            //ct_informeAnno.Series[meses[int.Parse(mes) - 1]].Points.AddXY(dia, Pesos[i]);
                        }

                        //ct_Peso.Series[anno].Points.AddXY(mes + "/ " + dia, Pesos[i]);
                        ct_imc.Series[anno].Points.AddXY(mes + "/ " + dia, Imcs[i]);
                        ct_Altura.Series[anno].Points.AddXY(mes + "/ " + dia, Alturas[i]);
                        ct_Peso.Series[anno].Points.AddXY(mes + "/ " + dia, Pesos[i]);
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
    }
}