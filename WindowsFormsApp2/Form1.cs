using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto();
            productoNuevo.Nombre = "Teléfono";
            productoNuevo.Descripcion = "Es un teléfono";
            productoNuevo.PrecioCosto = 300;
            productoNuevo.Margen = 0.40;
            productoNuevo.IVA = 0.21;
            productoNuevo.Proveedor = "Samsung";
            productoNuevo.Categoria = "Tecnología";
            productoNuevo.SubCategoria = "Móviles";
            MessageBox.Show("Nombre: " + productoNuevo.Nombre + ".\nDescripción: " + productoNuevo.Descripcion + ".\nPrecio Costo: " + productoNuevo.PrecioCosto + ".\nMargen: " +
                productoNuevo.Margen * 100 + "%.\nIVA: " + productoNuevo.IVA * 100 + "%. \nPrecio Bruto: " + productoNuevo.PrecioBruto + ". \nPrecio Venta: " + productoNuevo.PrecioVenta + ". \nProveedor: " + productoNuevo.Proveedor + ".\nCategoría: " +
                productoNuevo.Categoria + ".\nSubcategoría: " + productoNuevo.SubCategoria + ".");

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIn = new ClienteIndividuo();
            clienteIn.Nombre = "Andrés";
            clienteIn.Apellido = "Ramirez";
            clienteIn.CUIT = "24-93201234-7";
            clienteIn.Email = "andresramirez@gmail.com";
            clienteIn.Telefono = "+54 123456";
            clienteIn.Direccion = "25 de Mayo 120, Buenos Aires";
            MessageBox.Show("Nombre: " + clienteIn.Nombre + ".\nApellido: " + clienteIn.Apellido +
                ".\nCUIT: " + clienteIn.CUIT + ".\nEmail: " + clienteIn.Email + ".\nTelefono: " + clienteIn.Telefono +
                ".\nDireccion: " + clienteIn.Direccion + ".");
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Nombre = "DCDB";
            empresa.CUIT = "249555885";
            empresa.Contacto = "secretaria";
            empresa.Email = "secretaria@hotmail.com";
            empresa.Telefono = "+54 11220202";
            empresa.Direccion = "9 de Julio al 5005";
            MessageBox.Show("Nombre: " + empresa.Nombre + ".\nCUIT: " + empresa.CUIT +
                ".\nContacto: " + empresa.Contacto + ".\nEmail: " + empresa.Email + ".\nTelefono: " + empresa.Telefono +
                ".\nDireccion: " + empresa.Direccion + ".");
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Numero = "22";
            factura.Fecha = DateTime.Now;
            factura.Cliente = "José Pérez";
            factura.Direccion = "Almagro";
            factura.CondicionIva = "Responsable inscripto";
            factura.CondicionVenta = "Cobranzzas";
            factura.Detalle = "Detalle de venta";
            factura.Total = 4000;
            factura.Tipo = "B";
            MessageBox.Show("Número: " + factura.Numero + ".\nTipo: " + factura.Tipo + ".\nFecha: " + factura.Fecha.ToString() + ".\nCliente: " + factura.Cliente + ".\nDireccion: " + factura.Direccion +
            ".\nCondición Iva: " + factura.CondicionIva + ".\nCondición Venta: " + factura.CondicionVenta + ".\nDetalle: " + factura.Detalle + ".\n Total: " + factura.Total.ToString()); 
        }

        private void btn_remito_Click(object sender, EventArgs e)
        {
            Remito remito = new Remito();
            remito.Numero = "50";
            remito.Fecha = DateTime.Now;
            remito.Cliente = "María Pérez";
            remito.Direccion = "Corrientes 2022";
            remito.CondicionIva = "Responsable inscripto";
            remito.CondicionVenta = "Cobranzzas";
            remito.Detalle = "Texto detalle de venta";
            remito.Total = 9000;
            remito.FechaEntrega = DateTime.Now.AddDays(1);
            MessageBox.Show("Número: " + remito.Numero + ".\nFechaEntrega: " + remito.FechaEntrega + ".\nFecha: " + remito.Fecha.ToString() + ".\nCliente: " + remito.Cliente + ".\nDireccion: " + remito.Direccion +
            ".\nCondición Iva: " + remito.CondicionIva + ".\nCondición Venta: " + remito.CondicionVenta + ".\nDetalle: " + remito.Detalle + ".\n Total: " + remito.Total.ToString());

        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
           Vendedor vendedor = new Vendedor();
            vendedor.Nombre = "Horacio";
            vendedor.Apellido = "Jimenez";
            vendedor.DNI = "50444033";
            vendedor.Email = "horaciojimenez@gmail.com";
            vendedor.Telefono = "+54 1234543";
            vendedor.Direccion = "Julian Alvarez 3021";
            MessageBox.Show("Nombre: " + vendedor.Nombre + ".\nApellido: " +vendedor.Apellido +
                ".\nDNI: " + vendedor.DNI + ".\nEmail: " + vendedor.Email + ".\nTelefono: " + vendedor.Telefono +
                ".\nDireccion: " + vendedor.Direccion + ".");

        }
    }
}
