namespace PowerFit
{
    partial class VerInforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerInforme));
            this.dgv_Informe = new System.Windows.Forms.DataGridView();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new PowerFit.ClientesDataSet();
            this.perfilTableAdapter = new PowerFit.ClientesDataSetTableAdapters.PerfilTableAdapter();
            this.ct_Peso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_Peso_Anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_anno = new System.Windows.Forms.ComboBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_Altura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_peso = new System.Windows.Forms.Label();
            this.ct_Altura_anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_imc_anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_imc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso_Anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura_anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc_anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Informe
            // 
            this.dgv_Informe.AllowUserToAddRows = false;
            this.dgv_Informe.AllowUserToDeleteRows = false;
            this.dgv_Informe.AutoGenerateColumns = false;
            this.dgv_Informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Informe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pesoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.imcDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgv_Informe.DataSource = this.perfilBindingSource;
            this.dgv_Informe.Location = new System.Drawing.Point(12, 1051);
            this.dgv_Informe.Name = "dgv_Informe";
            this.dgv_Informe.ReadOnly = true;
            this.dgv_Informe.Size = new System.Drawing.Size(544, 282);
            this.dgv_Informe.TabIndex = 9;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // ct_Peso
            // 
            chartArea1.Name = "ChartArea1";
            this.ct_Peso.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ct_Peso.Legends.Add(legend1);
            this.ct_Peso.Location = new System.Drawing.Point(12, 38);
            this.ct_Peso.Name = "ct_Peso";
            this.ct_Peso.Size = new System.Drawing.Size(574, 300);
            this.ct_Peso.TabIndex = 1;
            this.ct_Peso.Text = "Grafico Historico";
            // 
            // ct_Peso_Anno
            // 
            this.ct_Peso_Anno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.ct_Peso_Anno.ChartAreas.Add(chartArea2);
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend2.Name = "Legend1";
            this.ct_Peso_Anno.Legends.Add(legend2);
            this.ct_Peso_Anno.Location = new System.Drawing.Point(592, 38);
            this.ct_Peso_Anno.Name = "ct_Peso_Anno";
            this.ct_Peso_Anno.Size = new System.Drawing.Size(574, 300);
            this.ct_Peso_Anno.TabIndex = 3;
            this.ct_Peso_Anno.Text = "Grafico de un año";
            // 
            // cb_anno
            // 
            this.cb_anno.FormattingEnabled = true;
            this.cb_anno.Location = new System.Drawing.Point(1138, 6);
            this.cb_anno.Name = "cb_anno";
            this.cb_anno.Size = new System.Drawing.Size(203, 21);
            this.cb_anno.TabIndex = 5;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(994, 4);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(138, 23);
            this.btn_cargar.TabIndex = 4;
            this.btn_cargar.Text = "Cargar Grafico";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1266, 38);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.pesoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.alturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imcDataGridViewTextBoxColumn
            // 
            this.imcDataGridViewTextBoxColumn.DataPropertyName = "imc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.imcDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.imcDataGridViewTextBoxColumn.HeaderText = "imc";
            this.imcDataGridViewTextBoxColumn.Name = "imcDataGridViewTextBoxColumn";
            this.imcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientesDataSetBindingSource
            // 
            this.clientesDataSetBindingSource.DataSource = this.clientesDataSet;
            this.clientesDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafico Historico de peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 1023);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos";
            // 
            // ct_Altura
            // 
            this.ct_Altura.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.ct_Altura.ChartAreas.Add(chartArea3);
            legend3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend3.Name = "Legend1";
            this.ct_Altura.Legends.Add(legend3);
            this.ct_Altura.Location = new System.Drawing.Point(12, 368);
            this.ct_Altura.Name = "ct_Altura";
            this.ct_Altura.Size = new System.Drawing.Size(574, 300);
            this.ct_Altura.TabIndex = 7;
            this.ct_Altura.Text = "Grafico de un año";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.Transparent;
            this.lb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.ForeColor = System.Drawing.Color.White;
            this.lb_peso.Location = new System.Drawing.Point(746, 6);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(243, 24);
            this.lb_peso.TabIndex = 2;
            this.lb_peso.Text = "Grafico del peso en 2019";
            // 
            // ct_Altura_anno
            // 
            this.ct_Altura_anno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.ct_Altura_anno.ChartAreas.Add(chartArea4);
            legend4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend4.Name = "Legend1";
            this.ct_Altura_anno.Legends.Add(legend4);
            this.ct_Altura_anno.Location = new System.Drawing.Point(592, 368);
            this.ct_Altura_anno.Name = "ct_Altura_anno";
            this.ct_Altura_anno.Size = new System.Drawing.Size(574, 300);
            this.ct_Altura_anno.TabIndex = 10;
            this.ct_Altura_anno.Text = "Grafico de un año";
            // 
            // ct_imc_anno
            // 
            this.ct_imc_anno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.ct_imc_anno.ChartAreas.Add(chartArea5);
            legend5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend5.Name = "Legend1";
            this.ct_imc_anno.Legends.Add(legend5);
            this.ct_imc_anno.Location = new System.Drawing.Point(592, 709);
            this.ct_imc_anno.Name = "ct_imc_anno";
            this.ct_imc_anno.Size = new System.Drawing.Size(574, 300);
            this.ct_imc_anno.TabIndex = 12;
            this.ct_imc_anno.Text = "Grafico de un año";
            // 
            // ct_imc
            // 
            this.ct_imc.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.ct_imc.ChartAreas.Add(chartArea6);
            legend6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend6.Name = "Legend1";
            this.ct_imc.Legends.Add(legend6);
            this.ct_imc.Location = new System.Drawing.Point(12, 709);
            this.ct_imc.Name = "ct_imc";
            this.ct_imc.Size = new System.Drawing.Size(574, 300);
            this.ct_imc.TabIndex = 11;
            this.ct_imc.Text = "Grafico de un año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(753, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grafico del Altura en 2019";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Grafico Historico de Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(761, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grafico del imc en 2019";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(163, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Grafico Historico de imc";
            // 
            // VerInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PowerFit.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ct_imc_anno);
            this.Controls.Add(this.ct_imc);
            this.Controls.Add(this.ct_Altura_anno);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.ct_Altura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.cb_anno);
            this.Controls.Add(this.ct_Peso_Anno);
            this.Controls.Add(this.ct_Peso);
            this.Controls.Add(this.dgv_Informe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                                                " +
    "                       Ver Informe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VerInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso_Anno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura_anno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc_anno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Informe;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private ClientesDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Peso;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Peso_Anno;
        private System.Windows.Forms.ComboBox cb_anno;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Altura;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Altura_anno;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_imc_anno;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_imc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}