namespace PowerFit
{
    partial class RegistrodeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contrasena1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contrasena2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_pregunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(66, 9);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(66, 35);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 3;
            this.txt_correo.Tag = "El correo debe contener un @";
            this.txt_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correo_KeyPress);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo: ";
            // 
            // txt_contrasena1
            // 
            this.txt_contrasena1.Location = new System.Drawing.Point(320, 9);
            this.txt_contrasena1.Name = "txt_contrasena1";
            this.txt_contrasena1.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena1.TabIndex = 5;
            this.txt_contrasena1.UseSystemPasswordChar = true;
            this.txt_contrasena1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contrasena1_KeyPress);
            this.txt_contrasena1.Leave += new System.EventHandler(this.txt_contrasena1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña: ";
            // 
            // txt_contrasena2
            // 
            this.txt_contrasena2.Location = new System.Drawing.Point(320, 35);
            this.txt_contrasena2.Name = "txt_contrasena2";
            this.txt_contrasena2.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena2.TabIndex = 7;
            this.txt_contrasena2.Tag = "la contraseña debe ser la misma en ambos casos";
            this.txt_contrasena2.UseSystemPasswordChar = true;
            this.txt_contrasena2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contrasena2_KeyPress);
            this.txt_contrasena2.Leave += new System.EventHandler(this.txt_contrasena2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar contraseña: ";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 73);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(130, 73);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(248, 73);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 9;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.Btn_atras_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(366, 73);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // btn_pregunta
            // 
            this.btn_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.btn_pregunta.BackgroundImage = global::PowerFit.Properties.Resources.pregunta;
            this.btn_pregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pregunta.Location = new System.Drawing.Point(426, 4);
            this.btn_pregunta.Name = "btn_pregunta";
            this.btn_pregunta.Size = new System.Drawing.Size(25, 25);
            this.btn_pregunta.TabIndex = 19;
            this.btn_pregunta.UseVisualStyleBackColor = false;
            this.btn_pregunta.Click += new System.EventHandler(this.btn_pregunta_Click_1);
            // 
            // RegistrodeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PowerFit.Properties.Resources.Panoramica_Gym;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 105);
            this.ControlBox = false;
            this.Controls.Add(this.btn_pregunta);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_contrasena2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_contrasena1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrodeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                 Registro de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contrasena1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contrasena2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_pregunta;
    }
}