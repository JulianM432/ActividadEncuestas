using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Issue3
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Encuesta nuevo = new Encuesta();
            FormRegistro vRegistro = new FormRegistro();
            if (vRegistro.ShowDialog() == DialogResult.OK)
            {
                nuevo.UsaBicicleta = vRegistro.cbBici.Checked;
                nuevo.UsaAuto = vRegistro.cbAuto.Checked;
                nuevo.UsaTransportePublico = vRegistro.cbTransportePublico.Checked;
                nuevo.DistanciaASuDestino = Convert.ToDouble(vRegistro.tbDistancia.Text);
                if (vRegistro.cbContacto.Checked)
                {
                    nuevo.Email = vRegistro.tbEmail.Text;
                }
                proceso.RegistrarEncuesta(nuevo, vRegistro.cbContacto.Checked);
            }
            vRegistro.Dispose();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            FormResultado vResultado = new FormResultado();
            vResultado.listBox.Items.Clear();
            vResultado.listBox.Items.Add("Bicicleta: " + proceso.PorcBicleta.ToString() + "%");
            vResultado.listBox.Items.Add("Automovil: " + proceso.PorcAuto.ToString() + "%");
            vResultado.listBox.Items.Add("Transporte Publico: " + proceso.PorcTranspPublico.ToString() + "%");
            vResultado.ShowDialog();
            vResultado.Dispose();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            FormContacto vContacto = new FormContacto();
            //vContacto.listBox1.Items.Clear();
            vContacto.listBox1.Items.Add("\tInforme de resultados contactables:");
            vContacto.listBox1.Items.Add("");
            for (int i = 0; i < proceso.CantContactables; i++)
            {
                vContacto.listBox1.Items.Add(proceso.VerContactable(i).Email + "  -  " + proceso.VerContactable(i).DistanciaASuDestino.ToString("0.00 km"));
            }
            vContacto.ShowDialog();
            vContacto.Dispose();
        }
    }
}
