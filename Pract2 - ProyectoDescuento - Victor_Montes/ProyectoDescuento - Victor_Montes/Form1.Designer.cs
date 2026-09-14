namespace ProyectoDescuento___Victor_Montes
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
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuento1 = new System.Windows.Forms.Label();
            this.lblDescuento2 = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuento1 = new System.Windows.Forms.TextBox();
            this.txtDescuento2 = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(58, 80);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(77, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta";
            // 
            // lblDescuento1
            // 
            this.lblDescuento1.AutoSize = true;
            this.lblDescuento1.Location = new System.Drawing.Point(58, 177);
            this.lblDescuento1.Name = "lblDescuento1";
            this.lblDescuento1.Size = new System.Drawing.Size(82, 16);
            this.lblDescuento1.TabIndex = 1;
            this.lblDescuento1.Text = "Descuento $";
            // 
            // lblDescuento2
            // 
            this.lblDescuento2.AutoSize = true;
            this.lblDescuento2.Location = new System.Drawing.Point(58, 217);
            this.lblDescuento2.Name = "lblDescuento2";
            this.lblDescuento2.Size = new System.Drawing.Size(87, 16);
            this.lblDescuento2.TabIndex = 2;
            this.lblDescuento2.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(58, 268);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(74, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(188, 80);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 4;
            this.txtValorVenta.TextChanged += new System.EventHandler(this.txtValorVenta_TextChanged);
            // 
            // txtDescuento1
            // 
            this.txtDescuento1.Location = new System.Drawing.Point(188, 171);
            this.txtDescuento1.Name = "txtDescuento1";
            this.txtDescuento1.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento1.TabIndex = 5;
            // 
            // txtDescuento2
            // 
            this.txtDescuento2.Location = new System.Drawing.Point(188, 217);
            this.txtDescuento2.Name = "txtDescuento2";
            this.txtDescuento2.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento2.TabIndex = 6;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(188, 268);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(100, 22);
            this.txtValorFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(370, 80);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(370, 122);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(370, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 419);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtDescuento2);
            this.Controls.Add(this.txtDescuento1);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuento2);
            this.Controls.Add(this.lblDescuento1);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuento1;
        private System.Windows.Forms.Label lblDescuento2;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuento1;
        private System.Windows.Forms.TextBox txtDescuento2;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

