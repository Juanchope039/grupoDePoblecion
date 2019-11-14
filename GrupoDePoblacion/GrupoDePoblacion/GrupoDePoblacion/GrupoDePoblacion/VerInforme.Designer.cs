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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.clientesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.ct_Altura_anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_imc_anno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_altura = new System.Windows.Forms.Label();
            this.lb_imc = new System.Windows.Forms.Label();
            this.cb_inicio_mes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_pregunta = new System.Windows.Forms.Button();
            this.pb_carga = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Peso_Anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Altura_anno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_imc_anno)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Informe
            // 
            this.dgv_Informe.AllowUserToAddRows = false;
            this.dgv_Informe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgv_Informe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Informe.AutoGenerateColumns = false;
            this.dgv_Informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Informe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pesoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.imcDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgv_Informe.DataSource = this.perfilBindingSource;
            this.dgv_Informe.Location = new System.Drawing.Point(604, 373);
            this.dgv_Informe.Name = "dgv_Informe";
            this.dgv_Informe.ReadOnly = true;
            this.dgv_Informe.Size = new System.Drawing.Size(544, 282);
            this.dgv_Informe.TabIndex = 9;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.pesoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso(Kg)";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.alturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura(cm)";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imcDataGridViewTextBoxColumn
            // 
            this.imcDataGridViewTextBoxColumn.DataPropertyName = "imc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.imcDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.imcDataGridViewTextBoxColumn.HeaderText = "imc";
            this.imcDataGridViewTextBoxColumn.Name = "imcDataGridViewTextBoxColumn";
            this.imcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.ct_Peso_Anno.Location = new System.Drawing.Point(4, 36);
            this.ct_Peso_Anno.Name = "ct_Peso_Anno";
            this.ct_Peso_Anno.Size = new System.Drawing.Size(574, 300);
            this.ct_Peso_Anno.TabIndex = 3;
            this.ct_Peso_Anno.Text = "Grafico de un año";
            this.ct_Peso_Anno.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cargar.Location = new System.Drawing.Point(1190, 149);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(137, 23);
            this.btn_cargar.TabIndex = 4;
            this.btn_cargar.Text = "Cargar Informe";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1283, 12);
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
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(840, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.Transparent;
            this.lb_peso.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.ForeColor = System.Drawing.Color.Black;
            this.lb_peso.Location = new System.Drawing.Point(153, 6);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(263, 24);
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
            this.ct_Altura_anno.Location = new System.Drawing.Point(589, 36);
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
            this.ct_imc_anno.Location = new System.Drawing.Point(4, 373);
            this.ct_imc_anno.Name = "ct_imc_anno";
            this.ct_imc_anno.Size = new System.Drawing.Size(574, 300);
            this.ct_imc_anno.TabIndex = 12;
            this.ct_imc_anno.Text = "Grafico de un año";
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.BackColor = System.Drawing.Color.Transparent;
            this.lb_altura.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_altura.ForeColor = System.Drawing.Color.Black;
            this.lb_altura.Location = new System.Drawing.Point(735, 6);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(280, 24);
            this.lb_altura.TabIndex = 14;
            this.lb_altura.Text = "Gráfico de altura(cm) de 2019";
            // 
            // lb_imc
            // 
            this.lb_imc.AutoSize = true;
            this.lb_imc.BackColor = System.Drawing.Color.Transparent;
            this.lb_imc.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_imc.ForeColor = System.Drawing.Color.Black;
            this.lb_imc.Location = new System.Drawing.Point(177, 345);
            this.lb_imc.Name = "lb_imc";
            this.lb_imc.Size = new System.Drawing.Size(219, 24);
            this.lb_imc.TabIndex = 16;
            this.lb_imc.Text = "Gráfico de IMC de 2019";
            // 
            // cb_inicio_mes
            // 
            this.cb_inicio_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inicio_mes.ForeColor = System.Drawing.Color.Black;
            this.cb_inicio_mes.FormattingEnabled = true;
            this.cb_inicio_mes.Location = new System.Drawing.Point(12, 63);
            this.cb_inicio_mes.Name = "cb_inicio_mes";
            this.cb_inicio_mes.Size = new System.Drawing.Size(137, 26);
            this.cb_inicio_mes.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ct_Peso_Anno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_imc);
            this.panel1.Controls.Add(this.ct_imc_anno);
            this.panel1.Controls.Add(this.dgv_Informe);
            this.panel1.Controls.Add(this.lb_peso);
            this.panel1.Controls.Add(this.lb_altura);
            this.panel1.Controls.Add(this.ct_Altura_anno);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 759);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_inicio_mes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1190, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 102);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del informe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mes:";
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.Location = new System.Drawing.Point(1202, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 24;
            this.btn_menu.Text = "Menú";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_pregunta
            // 
            this.btn_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.btn_pregunta.BackgroundImage = global::PowerFit.Properties.Resources.pregunta;
            this.btn_pregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pregunta.Location = new System.Drawing.Point(1333, 147);
            this.btn_pregunta.Name = "btn_pregunta";
            this.btn_pregunta.Size = new System.Drawing.Size(25, 25);
            this.btn_pregunta.TabIndex = 25;
            this.btn_pregunta.UseVisualStyleBackColor = false;
            // 
            // pb_carga
            // 
            this.pb_carga.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_carga.ForeColor = System.Drawing.Color.Lime;
            this.pb_carga.Location = new System.Drawing.Point(0, 0);
            this.pb_carga.Maximum = 5;
            this.pb_carga.Name = "pb_carga";
            this.pb_carga.Size = new System.Drawing.Size(1370, 3);
            this.pb_carga.TabIndex = 26;
            this.pb_carga.Visible = false;
            // 
            // VerInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.pb_carga);
            this.Controls.Add(this.btn_pregunta);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Informe;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private ClientesDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Peso_Anno;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.BindingSource clientesDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Altura_anno;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_imc_anno;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.Label lb_imc;
        private System.Windows.Forms.ComboBox cb_inicio_mes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_pregunta;
        private System.Windows.Forms.ProgressBar pb_carga;
    }
}