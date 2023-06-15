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
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {

        }
    }
}
