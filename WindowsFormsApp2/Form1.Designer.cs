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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Enviar Factura";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(331, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 76);
            this.button5.TabIndex = 4;
            this.button5.Text = "Enviar Remito";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(331, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 76);
            this.button6.TabIndex = 5;
            this.button6.Text = "Enviar Vendedor";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

