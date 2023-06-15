namespace Issue3
{
    partial class Form1
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
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(3, 59);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(167, 50);
            this.btnResultados.TabIndex = 1;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(3, 115);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(167, 50);
            this.btnListado.TabIndex = 2;
            this.btnListado.Text = "Listado contactables";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(167, 50);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registro de encuesta";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRegistro);
            this.flowLayoutPanel1.Controls.Add(this.btnResultados);
            this.flowLayoutPanel1.Controls.Add(this.btnListado);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 168);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 228);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Secretaria de transporte de su magestad!";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

