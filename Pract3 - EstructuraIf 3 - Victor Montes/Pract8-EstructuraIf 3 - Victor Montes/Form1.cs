using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract8_EstructuraIf_3___Victor_Montes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal numero1;
            decimal numero2;
            decimal resultado;

            if (!decimal.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show("Ingrese un número válido en el primer campo.");
                return;
            }

            if (!decimal.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Ingrese un número válido en el segundo campo.");
                return;
            }

            if (rbtnSuma.Checked)
            {
                lblSigno.Text = "+";
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else if (rbtnResta.Checked)
            {
                lblSigno.Text = "-";
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else if (rbtnMultiplicacion.Checked)
            {
                lblSigno.Text = "*";
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else if (rbtnDivision.Checked)
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                    return;
                }

                lblSigno.Text = "/";
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una operación.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
