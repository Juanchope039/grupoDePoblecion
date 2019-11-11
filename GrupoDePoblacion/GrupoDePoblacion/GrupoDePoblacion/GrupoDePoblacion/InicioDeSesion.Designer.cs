namespace PowerFit
{
    partial class InicioDeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            this.ckb_mo_contrasena = new System.Windows.Forms.CheckBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pregunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckb_mo_contrasena
            // 
            this.ckb_mo_contrasena.AutoSize = true;
            this.ckb_mo_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.ckb_mo_contrasena.ForeColor = System.Drawing.Color.White;
            this.ckb_mo_contrasena.Location = new System.Drawing.Point(106, 92);
            this.ckb_mo_contrasena.Name = "ckb_mo_contrasena";
            this.ckb_mo_contrasena.Size = new System.Drawing.Size(118, 17);
            this.ckb_mo_contrasena.TabIndex = 17;
            this.ckb_mo_contrasena.Text = "Mostrar Contraseña";
            this.ckb_mo_contrasena.UseVisualStyleBackColor = false;
            this.ckb_mo_contrasena.CheckedChanged += new System.EventHandler(this.Ckb_mo_contrasena_CheckedChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(183, 115);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.Location = new System.Drawing.Point(102, 115);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrarse.TabIndex = 15;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.Btn_Registrarse_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(21, 115);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 14;
            this.btn_iniciar.Text = "Iniciar Sesion";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click_1);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(106, 62);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 13;
            this.txt_contrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña: ";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(106, 22);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 11;
            this.txt_usuario.Tag = "Ingrese nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario: ";
            // 
            // btn_pregunta
            // 
            this.btn_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.btn_pregunta.BackgroundImage = global::PowerFit.Properties.Resources.pregunta;
            this.btn_pregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pregunta.Location = new System.Drawing.Point(243, 12);
            this.btn_pregunta.Name = "btn_pregunta";
            this.btn_pregunta.Size = new System.Drawing.Size(25, 25);
            this.btn_pregunta.TabIndex = 18;
            this.btn_pregunta.UseVisualStyleBackColor = false;
            this.btn_pregunta.Click += new System.EventHandler(this.btn_pregunta_Click);
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PowerFit.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(280, 156);
            this.ControlBox = false;
            this.Controls.Add(this.btn_pregunta);
            this.Controls.Add(this.ckb_mo_contrasena);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                  Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_mo_contrasena;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pregunta;
    }
}