namespace PowerFit
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_verInforme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_recomendacionesAlimenticias = new System.Windows.Forms.Button();
            this.btn_recomendacionesRutinas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_verInforme
            // 
            this.btn_verInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verInforme.Location = new System.Drawing.Point(12, 12);
            this.btn_verInforme.Name = "btn_verInforme";
            this.btn_verInforme.Size = new System.Drawing.Size(133, 54);
            this.btn_verInforme.TabIndex = 0;
            this.btn_verInforme.Text = "Ver Informe";
            this.btn_verInforme.UseVisualStyleBackColor = true;
            this.btn_verInforme.Click += new System.EventHandler(this.btn_verInforme_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(461, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_recomendacionesAlimenticias
            // 
            this.btn_recomendacionesAlimenticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recomendacionesAlimenticias.Location = new System.Drawing.Point(161, 12);
            this.btn_recomendacionesAlimenticias.Name = "btn_recomendacionesAlimenticias";
            this.btn_recomendacionesAlimenticias.Size = new System.Drawing.Size(133, 54);
            this.btn_recomendacionesAlimenticias.TabIndex = 2;
            this.btn_recomendacionesAlimenticias.Text = "Recomendaciones alimenticias";
            this.btn_recomendacionesAlimenticias.UseVisualStyleBackColor = true;
            this.btn_recomendacionesAlimenticias.Click += new System.EventHandler(this.btn_recomendacionesAlimenticias_Click);
            // 
            // btn_recomendacionesRutinas
            // 
            this.btn_recomendacionesRutinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recomendacionesRutinas.Location = new System.Drawing.Point(312, 12);
            this.btn_recomendacionesRutinas.Name = "btn_recomendacionesRutinas";
            this.btn_recomendacionesRutinas.Size = new System.Drawing.Size(133, 54);
            this.btn_recomendacionesRutinas.TabIndex = 3;
            this.btn_recomendacionesRutinas.Text = "Recomendaciones de rutina";
            this.btn_recomendacionesRutinas.UseVisualStyleBackColor = true;
            this.btn_recomendacionesRutinas.Click += new System.EventHandler(this.btn_recomendacionesRutinas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PowerFit.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(610, 78);
            this.ControlBox = false;
            this.Controls.Add(this.btn_recomendacionesRutinas);
            this.Controls.Add(this.btn_recomendacionesAlimenticias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_verInforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "              Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_verInforme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_recomendacionesAlimenticias;
        private System.Windows.Forms.Button btn_recomendacionesRutinas;
    }
}