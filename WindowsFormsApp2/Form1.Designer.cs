namespace WindowsFormsApp2
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
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_remito = new System.Windows.Forms.Button();
            this.btn_vendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_producto
            // 
            this.btn_producto.Location = new System.Drawing.Point(55, 55);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(216, 76);
            this.btn_producto.TabIndex = 0;
            this.btn_producto.Text = "Enviar Producto";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(55, 171);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(216, 76);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Enviar Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_empresa
            // 
            this.btn_empresa.Location = new System.Drawing.Point(55, 297);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(216, 76);
            this.btn_empresa.TabIndex = 2;
            this.btn_empresa.Text = "Enviar Empresa";
            this.btn_empresa.UseVisualStyleBackColor = true;
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.Location = new System.Drawing.Point(331, 55);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(216, 76);
            this.btn_factura.TabIndex = 3;
            this.btn_factura.Text = "Enviar Factura";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_remito
            // 
            this.btn_remito.Location = new System.Drawing.Point(331, 171);
            this.btn_remito.Name = "btn_remito";
            this.btn_remito.Size = new System.Drawing.Size(216, 76);
            this.btn_remito.TabIndex = 4;
            this.btn_remito.Text = "Enviar Remito";
            this.btn_remito.UseVisualStyleBackColor = true;
            this.btn_remito.Click += new System.EventHandler(this.btn_remito_Click);
            // 
            // btn_vendedor
            // 
            this.btn_vendedor.Location = new System.Drawing.Point(331, 297);
            this.btn_vendedor.Name = "btn_vendedor";
            this.btn_vendedor.Size = new System.Drawing.Size(216, 76);
            this.btn_vendedor.TabIndex = 5;
            this.btn_vendedor.Text = "Enviar Vendedor";
            this.btn_vendedor.UseVisualStyleBackColor = true;
            this.btn_vendedor.Click += new System.EventHandler(this.btn_vendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vendedor);
            this.Controls.Add(this.btn_remito);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.btn_empresa);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_producto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_remito;
        private System.Windows.Forms.Button btn_vendedor;
    }
}

