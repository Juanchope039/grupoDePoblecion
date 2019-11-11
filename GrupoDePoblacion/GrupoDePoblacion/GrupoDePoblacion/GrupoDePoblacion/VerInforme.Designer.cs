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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerInforme));
            this.dgv_Informe = new System.Windows.Forms.DataGridView();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new PowerFit.ClientesDataSet();
            this.perfilTableAdapter = new PowerFit.ClientesDataSetTableAdapters.PerfilTableAdapter();
            this.ct_Peso_Anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_inicio_anno = new System.Windows.Forms.ComboBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.clientesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.ct_Altura_anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_imc_anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_altura = new System.Windows.Forms.Label();
            this.lb_imc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cb_inicio_mes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_fin_mes = new System.Windows.Forms.ComboBox();
            this.cb_fin_anno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso_Anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura_anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc_anno)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dgv_Informe.Location = new System.Drawing.Point(18, 951);
            this.dgv_Informe.Name = "dgv_Informe";
            this.dgv_Informe.ReadOnly = true;
            this.dgv_Informe.Size = new System.Drawing.Size(544, 282);
            this.dgv_Informe.TabIndex = 9;
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
            // ct_Peso_Anno
            // 
            this.ct_Peso_Anno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.ct_Peso_Anno.ChartAreas.Add(chartArea1);
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend1.Name = "Legend1";
            this.ct_Peso_Anno.Legends.Add(legend1);
            this.ct_Peso_Anno.Location = new System.Drawing.Point(3, 277);
            this.ct_Peso_Anno.Name = "ct_Peso_Anno";
            this.ct_Peso_Anno.Size = new System.Drawing.Size(574, 300);
            this.ct_Peso_Anno.TabIndex = 3;
            this.ct_Peso_Anno.Text = "Grafico de un año";
            // 
            // cb_inicio_anno
            // 
            this.cb_inicio_anno.FormattingEnabled = true;
            this.cb_inicio_anno.Location = new System.Drawing.Point(6, 47);
            this.cb_inicio_anno.Name = "cb_inicio_anno";
            this.cb_inicio_anno.Size = new System.Drawing.Size(140, 26);
            this.cb_inicio_anno.TabIndex = 5;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(1206, 331);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(137, 23);
            this.btn_cargar.TabIndex = 4;
            this.btn_cargar.Text = "Cargar Grafico";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1266, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // clientesDataSetBindingSource
            // 
            this.clientesDataSetBindingSource.DataSource = this.clientesDataSet;
            this.clientesDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 923);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.Transparent;
            this.lb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.ForeColor = System.Drawing.Color.White;
            this.lb_peso.Location = new System.Drawing.Point(152, 245);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(277, 24);
            this.lb_peso.TabIndex = 2;
            this.lb_peso.Text = "Gráfico de peso(Kg) de 2019";
            // 
            // ct_Altura_anno
            // 
            this.ct_Altura_anno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.ct_Altura_anno.ChartAreas.Add(chartArea2);
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend2.Name = "Legend1";
            this.ct_Altura_anno.Legends.Add(legend2);
            this.ct_Altura_anno.Location = new System.Drawing.Point(588, 277);
            this.ct_Altura_anno.Name = "ct_Altura_anno";
            this.ct_Altura_anno.Size = new System.Drawing.Size(574, 300);
            this.ct_Altura_anno.TabIndex = 10;
            this.ct_Altura_anno.Text = "Grafico de un año";
            // 
            // ct_imc_anno
            // 
            this.ct_imc_anno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.ct_imc_anno.ChartAreas.Add(chartArea3);
            legend3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend3.Name = "Legend1";
            this.ct_imc_anno.Legends.Add(legend3);
            this.ct_imc_anno.Location = new System.Drawing.Point(3, 609);
            this.ct_imc_anno.Name = "ct_imc_anno";
            this.ct_imc_anno.Size = new System.Drawing.Size(574, 300);
            this.ct_imc_anno.TabIndex = 12;
            this.ct_imc_anno.Text = "Grafico de un año";
            this.ct_imc_anno.Click += new System.EventHandler(this.ct_imc_anno_Click);
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.BackColor = System.Drawing.Color.Transparent;
            this.lb_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_altura.ForeColor = System.Drawing.Color.White;
            this.lb_altura.Location = new System.Drawing.Point(734, 250);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(285, 24);
            this.lb_altura.TabIndex = 14;
            this.lb_altura.Text = "Gráfico de altura(cm) de 2019";
            // 
            // lb_imc
            // 
            this.lb_imc.AutoSize = true;
            this.lb_imc.BackColor = System.Drawing.Color.Transparent;
            this.lb_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_imc.ForeColor = System.Drawing.Color.White;
            this.lb_imc.Location = new System.Drawing.Point(176, 582);
            this.lb_imc.Name = "lb_imc";
            this.lb_imc.Size = new System.Drawing.Size(228, 24);
            this.lb_imc.TabIndex = 16;
            this.lb_imc.Text = "Gráfico de IMC de 2019";
            this.lb_imc.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1145, 206);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cb_inicio_mes
            // 
            this.cb_inicio_mes.FormattingEnabled = true;
            this.cb_inicio_mes.Location = new System.Drawing.Point(6, 103);
            this.cb_inicio_mes.Name = "cb_inicio_mes";
            this.cb_inicio_mes.Size = new System.Drawing.Size(137, 26);
            this.cb_inicio_mes.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.ct_Peso_Anno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_imc);
            this.panel1.Controls.Add(this.ct_imc_anno);
            this.panel1.Controls.Add(this.dgv_Informe);
            this.panel1.Controls.Add(this.lb_peso);
            this.panel1.Controls.Add(this.lb_altura);
            this.panel1.Controls.Add(this.ct_Altura_anno);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 725);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(535, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Informe";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_inicio_mes);
            this.groupBox1.Controls.Add(this.cb_inicio_anno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1190, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 139);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Año:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mes:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_fin_mes);
            this.groupBox2.Controls.Add(this.cb_fin_anno);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1190, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 139);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Año:";
            // 
            // cb_fin_mes
            // 
            this.cb_fin_mes.FormattingEnabled = true;
            this.cb_fin_mes.Location = new System.Drawing.Point(6, 103);
            this.cb_fin_mes.Name = "cb_fin_mes";
            this.cb_fin_mes.Size = new System.Drawing.Size(137, 26);
            this.cb_fin_mes.TabIndex = 19;
            // 
            // cb_fin_anno
            // 
            this.cb_fin_anno.FormattingEnabled = true;
            this.cb_fin_anno.Location = new System.Drawing.Point(6, 47);
            this.cb_fin_anno.Name = "cb_fin_anno";
            this.cb_fin_anno.Size = new System.Drawing.Size(140, 26);
            this.cb_fin_anno.TabIndex = 5;
            // 
            // VerInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PowerFit.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso_Anno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura_anno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc_anno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Informe;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private ClientesDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Peso_Anno;
        private System.Windows.Forms.ComboBox cb_inicio_anno;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Altura_anno;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_imc_anno;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.Label lb_imc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cb_inicio_mes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_fin_mes;
        private System.Windows.Forms.ComboBox cb_fin_anno;
    }
}