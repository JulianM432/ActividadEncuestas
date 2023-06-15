namespace Issue3
{
    partial class FormRegistro
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbContacto = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBici = new System.Windows.Forms.CheckBox();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.cbTransportePublico = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 241);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 285);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(3, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConfirm);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Location = new System.Drawing.Point(3, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 31);
            this.panel4.TabIndex = 7;
            // 
            // cbContacto
            // 
            this.cbContacto.AutoSize = true;
            this.cbContacto.Location = new System.Drawing.Point(6, 19);
            this.cbContacto.Name = "cbContacto";
            this.cbContacto.Size = new System.Drawing.Size(137, 17);
            this.cbContacto.TabIndex = 0;
            this.cbContacto.Text = "Puede ser contactado?";
            this.cbContacto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 25);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(50, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(147, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.cbContacto);
            this.groupBox3.Location = new System.Drawing.Point(3, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDistancia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en [km]";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(97, 1);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(100, 20);
            this.tbDistancia.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(3, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobre el destino al trabajo/estudio";
            // 
            // cbBici
            // 
            this.cbBici.AutoSize = true;
            this.cbBici.Location = new System.Drawing.Point(15, 19);
            this.cbBici.Name = "cbBici";
            this.cbBici.Size = new System.Drawing.Size(94, 17);
            this.cbBici.TabIndex = 0;
            this.cbBici.Text = "Usa Bicicleta?";
            this.cbBici.UseVisualStyleBackColor = true;
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(15, 42);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(99, 17);
            this.cbAuto.TabIndex = 5;
            this.cbAuto.Text = "Usa automovil?";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // cbTransportePublico
            // 
            this.cbTransportePublico.AutoSize = true;
            this.cbTransportePublico.Location = new System.Drawing.Point(15, 66);
            this.cbTransportePublico.Name = "cbTransportePublico";
            this.cbTransportePublico.Size = new System.Drawing.Size(138, 17);
            this.cbTransportePublico.TabIndex = 6;
            this.cbTransportePublico.Text = "Usa transporte publico?";
            this.cbTransportePublico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTransportePublico);
            this.groupBox1.Controls.Add(this.cbAuto);
            this.groupBox1.Controls.Add(this.cbBici);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de transporte habitual";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 313);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormRegistro";
            this.Text = "Registro de encuesta";
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox cbTransportePublico;
        public System.Windows.Forms.CheckBox cbAuto;
        public System.Windows.Forms.CheckBox cbBici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox cbContacto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}