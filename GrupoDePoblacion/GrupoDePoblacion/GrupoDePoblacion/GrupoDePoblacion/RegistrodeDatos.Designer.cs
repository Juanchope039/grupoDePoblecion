namespace GrupoDePoblacion
{
    partial class RegistrodeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeDatos));
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btProcesar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_enfermedades = new System.Windows.Forms.TextBox();
            this.txt_grupoSanguineo = new System.Windows.Forms.TextBox();
            this.txt_discapacidades = new System.Windows.Forms.TextBox();
            this.txt_leciones = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLimpiar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btLimpiar.Location = new System.Drawing.Point(412, 190);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(90, 26);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btProcesar
            // 
            this.btProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btProcesar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btProcesar.Location = new System.Drawing.Point(612, 190);
            this.btProcesar.Name = "btProcesar";
            this.btProcesar.Size = new System.Drawing.Size(90, 26);
            this.btProcesar.TabIndex = 2;
            this.btProcesar.Text = "Procesar";
            this.btProcesar.UseVisualStyleBackColor = true;
            this.btProcesar.Click += new System.EventHandler(this.btProcesar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Peso: ";
            // 
            // txt_peso
            // 
            this.txt_peso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_peso.Location = new System.Drawing.Point(314, 28);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(121, 25);
            this.txt_peso.TabIndex = 7;
            this.txt_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            this.txt_peso.Validating += new System.ComponentModel.CancelEventHandler(this.txt_peso_Validating);
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_apellido.Location = new System.Drawing.Point(88, 61);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(121, 25);
            this.txt_apellido.TabIndex = 3;
            this.txt_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            this.txt_apellido.Leave += new System.EventHandler(this.txt_apellido_Leave_1);
            this.txt_apellido.Validating += new System.ComponentModel.CancelEventHandler(this.txt_apellido_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Apellido:";
            // 
            // txt_altura
            // 
            this.txt_altura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_altura.Location = new System.Drawing.Point(314, 61);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(121, 25);
            this.txt_altura.TabIndex = 9;
            this.txt_altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_altura_KeyPress);
            this.txt_altura.Validating += new System.ComponentModel.CancelEventHandler(this.txt_altura_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Edad:";
            // 
            // txt_edad
            // 
            this.txt_edad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_edad.Location = new System.Drawing.Point(88, 96);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(121, 25);
            this.txt_edad.TabIndex = 5;
            this.txt_edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edad_KeyPress);
            this.txt_edad.Validating += new System.ComponentModel.CancelEventHandler(this.txt_edad_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_nombre.Location = new System.Drawing.Point(88, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 25);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave_1);
            this.txt_nombre.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nombre_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rb_masculino);
            this.groupBox2.Controls.Add(this.rb_femenino);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_edad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_altura);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_apellido);
            this.groupBox2.Controls.Add(this.txt_peso);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Personal";
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(356, 116);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(89, 21);
            this.rb_masculino.TabIndex = 12;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Location = new System.Drawing.Point(252, 116);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(87, 21);
            this.rb_femenino.TabIndex = 11;
            this.rb_femenino.TabStop = true;
            this.rb_femenino.Text = "Femenino";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Altura: ";
            // 
            // txt_enfermedades
            // 
            this.txt_enfermedades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_enfermedades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_enfermedades.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_enfermedades.Location = new System.Drawing.Point(121, 97);
            this.txt_enfermedades.Name = "txt_enfermedades";
            this.txt_enfermedades.Size = new System.Drawing.Size(101, 22);
            this.txt_enfermedades.TabIndex = 5;
            this.txt_enfermedades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_enfermedades.Validating += new System.ComponentModel.CancelEventHandler(this.txt_enfermedades_Validating);
            // 
            // txt_grupoSanguineo
            // 
            this.txt_grupoSanguineo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_grupoSanguineo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_grupoSanguineo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_grupoSanguineo.Location = new System.Drawing.Point(121, 63);
            this.txt_grupoSanguineo.Name = "txt_grupoSanguineo";
            this.txt_grupoSanguineo.Size = new System.Drawing.Size(101, 22);
            this.txt_grupoSanguineo.TabIndex = 3;
            this.txt_grupoSanguineo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_grupoSanguineo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_grupoSanguineo_Validating);
            // 
            // txt_discapacidades
            // 
            this.txt_discapacidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_discapacidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_discapacidades.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_discapacidades.Location = new System.Drawing.Point(121, 131);
            this.txt_discapacidades.Name = "txt_discapacidades";
            this.txt_discapacidades.Size = new System.Drawing.Size(101, 22);
            this.txt_discapacidades.TabIndex = 7;
            this.txt_discapacidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_discapacidades.Validating += new System.ComponentModel.CancelEventHandler(this.txt_discapacidades_Validating);
            // 
            // txt_leciones
            // 
            this.txt_leciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_leciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_leciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_leciones.Location = new System.Drawing.Point(121, 29);
            this.txt_leciones.Name = "txt_leciones";
            this.txt_leciones.Size = new System.Drawing.Size(101, 22);
            this.txt_leciones.TabIndex = 1;
            this.txt_leciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_leciones.Validating += new System.ComponentModel.CancelEventHandler(this.txt_leciones_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_leciones);
            this.groupBox3.Controls.Add(this.txt_discapacidades);
            this.groupBox3.Controls.Add(this.txt_grupoSanguineo);
            this.groupBox3.Controls.Add(this.txt_enfermedades);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(473, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informe Medico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discapasidades:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enfermedades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo sanguineo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Leciones:";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(12, 190);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 26);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Visible = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_atras.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_atras.Location = new System.Drawing.Point(212, 190);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(90, 26);
            this.btn_atras.TabIndex = 14;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Visible = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click_1);
            // 
            // RegistrodeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 223);
            this.ControlBox = false;
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btProcesar);
            this.Name = "RegistrodeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                G" +
    "rupoDePoblacion";
            this.Load += new System.EventHandler(this.AgregarUsuario_load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btProcesar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_enfermedades;
        private System.Windows.Forms.TextBox txt_grupoSanguineo;
        private System.Windows.Forms.TextBox txt_discapacidades;
        private System.Windows.Forms.TextBox txt_leciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.RadioButton rb_femenino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_atras;
    }
}

