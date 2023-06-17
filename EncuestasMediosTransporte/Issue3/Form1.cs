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
            FormRegistro vRegistro = new FormRegistro();
            if (vRegistro.ShowDialog() == DialogResult.OK)
            {
                Encuesta nuevo = new Encuesta();
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
            FormListBox vResultado = new FormListBox();
            vResultado.listBox.Items.Add(string.Format("{0:-40} %{1,-10:f2}", "Porcentaje Bicicletas:", proceso.PorcBicleta));
            vResultado.listBox.Items.Add(string.Format("{0:-40} %{1,-10:f2}", "Porcentaje Automovil:", proceso.PorcAuto));
            vResultado.listBox.Items.Add(string.Format("{0:-40} %{1,-10:f2}", "Porcentaje Transporte publico:", proceso.PorcTranspPublico));
            vResultado.ShowDialog();
            vResultado.Dispose();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            FormListBox vContacto = new FormListBox();
            vContacto.listBox.Items.Add("\tInforme de resultados contactables:");
            vContacto.listBox.Items.Add("");
            for (int i = 0; i < proceso.CantContactables; i++)
            {
                vContacto.listBox.Items.Add(proceso.VerContactable(i).Email + "  -  " + proceso.VerContactable(i).DistanciaASuDestino.ToString("0.00 km"));
            }
            vContacto.ShowDialog();
            vContacto.Dispose();
        }
    }
}
