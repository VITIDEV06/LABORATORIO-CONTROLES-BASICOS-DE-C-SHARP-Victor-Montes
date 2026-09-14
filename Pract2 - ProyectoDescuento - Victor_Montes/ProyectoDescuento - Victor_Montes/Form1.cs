using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDescuento___Victor_Montes
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

        private void txtValorVenta_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorVenta;
            decimal valorDescuento;

            if (!decimal.TryParse(txtValorVenta.Text, out valorVenta))
            {
                MessageBox.Show("Está vacío el campo del valor de venta");
            }
            else
            {
                if (valorVenta >= 500)
                {
                    valorDescuento = valorVenta * 0.30m;
                    txtDescuento1.Text = valorDescuento.ToString();
                    txtDescuento2.Text = "30%";
                    txtValorFinal.Text = (valorVenta - valorDescuento).ToString();
                }
                else if (valorVenta >= 300 && valorVenta <= 499)
                {
                    valorDescuento = valorVenta * 0.20m;
                    txtDescuento1.Text = valorDescuento.ToString();
                    txtDescuento2.Text = "20%";
                    txtValorFinal.Text = (valorVenta - valorDescuento).ToString();
                }
                else if (valorVenta > 100 && valorVenta <= 299)
                {
                    valorDescuento = valorVenta * 0.10m;
                    txtDescuento1.Text = valorDescuento.ToString();
                    txtDescuento2.Text = "10%";
                    txtValorFinal.Text = (valorVenta - valorDescuento).ToString();
                }
                else
                {
                    valorDescuento = valorVenta * 0.00m;
                    txtDescuento1.Text = valorDescuento.ToString();
                    txtDescuento2.Text = "0%";
                    txtValorFinal.Text = (valorVenta - valorDescuento).ToString();
                }
            }

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Clear();
            txtDescuento1.Clear();
            txtDescuento2.Clear();
            txtValorFinal.Clear();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana","Salir",MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
