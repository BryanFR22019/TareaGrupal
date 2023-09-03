using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaGrupal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNota.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double nota = Convert.ToDouble(txtNota.Text);
            if (nota >= 6.0)
            {
                MessageBox.Show(nombre + " Aprobado");
            }
            else
            {
                MessageBox.Show(nombre + " Reprobado");
            }
        }
    }
}
