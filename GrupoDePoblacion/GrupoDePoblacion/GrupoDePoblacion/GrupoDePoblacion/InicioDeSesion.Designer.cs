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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckb_mo_contrasena
            // 
            this.ckb_mo_contrasena.AutoSize = true;
            this.ckb_mo_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.ckb_mo_contrasena.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_mo_contrasena.ForeColor = System.Drawing.Color.Black;
            this.ckb_mo_contrasena.Location = new System.Drawing.Point(106, 144);
            this.ckb_mo_contrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckb_mo_contrasena.Name = "ckb_mo_contrasena";
            this.ckb_mo_contrasena.Size = new System.Drawing.Size(134, 20);
            this.ckb_mo_contrasena.TabIndex = 17;
            this.ckb_mo_contrasena.Text = "Mostrar Contraseña";
            this.ckb_mo_contrasena.UseVisualStyleBackColor = false;
            this.ckb_mo_contrasena.CheckedChanged += new System.EventHandler(this.Ckb_mo_contrasena_CheckedChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(21, 172);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(57, 28);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrarse.Location = new System.Drawing.Point(91, 172);
            this.btn_Registrarse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(89, 28);
            this.btn_Registrarse.TabIndex = 15;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.Btn_Registrarse_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(193, 172);
            this.btn_iniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 28);
            this.btn_iniciar.TabIndex = 14;
            this.btn_iniciar.Text = "Iniciar Sesion";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click_1);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(106, 107);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 13;
            this.txt_contrasena.UseSystemPasswordChar = true;
            this.txt_contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contrasena_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña: ";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(106, 58);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 11;
            this.txt_usuario.Tag = "Ingrese nombre de usuario";
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario: ";
            // 
            // btn_pregunta
            // 
            this.btn_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.btn_pregunta.BackgroundImage = global::PowerFit.Properties.Resources.pregunta;
            this.btn_pregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pregunta.Location = new System.Drawing.Point(243, 46);
            this.btn_pregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pregunta.Name = "btn_pregunta";
            this.btn_pregunta.Size = new System.Drawing.Size(25, 31);
            this.btn_pregunta.TabIndex = 18;
            this.btn_pregunta.UseVisualStyleBackColor = false;
            this.btn_pregunta.Click += new System.EventHandler(this.btn_pregunta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inicio de sesión";
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 209);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pregunta);
            this.Controls.Add(this.ckb_mo_contrasena);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "                                      PowerFit";
            this.Load += new System.EventHandler(this.InicioDeSesion_Load);
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
        private System.Windows.Forms.Label label1;
    }
}