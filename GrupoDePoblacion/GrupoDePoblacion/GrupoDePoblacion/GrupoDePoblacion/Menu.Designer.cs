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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_verInforme
            // 
            this.btn_verInforme.Location = new System.Drawing.Point(12, 12);
            this.btn_verInforme.Name = "btn_verInforme";
            this.btn_verInforme.Size = new System.Drawing.Size(92, 37);
            this.btn_verInforme.TabIndex = 0;
            this.btn_verInforme.Text = "Ver Informe";
            this.btn_verInforme.UseVisualStyleBackColor = true;
            this.btn_verInforme.Click += new System.EventHandler(this.btn_verInforme_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Recomendaciones alimenticias";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Recomendaciones de rutina";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 59);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_verInforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_verInforme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}