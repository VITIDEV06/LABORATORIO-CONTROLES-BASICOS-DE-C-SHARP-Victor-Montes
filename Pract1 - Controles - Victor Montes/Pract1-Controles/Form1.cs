using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmEnviar_Click(object sender, EventArgs e)
        {
            if (txtDia.Text != "" && txtMes.Text != "" && txtAnio.Text != "")
            {
                lblFecha.Text = txtDia.Text + "/" + txtMes.Text + "/" + txtAnio.Text;
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");
            MessageBox.Show("Cerrando");
            this.Close();
        }

        
    }
}
