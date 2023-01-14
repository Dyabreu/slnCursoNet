using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto() { }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }

        public string Proveedor { get; set; }
        public string Categoria { get; set; }

        public string SubCategoria { get; set; }

        public decimal PrecioBruto
        {
            get
            {
                return this.PrecioCosto + (Convert.ToDecimal(this.Margen) * this.PrecioCosto);
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                return this.PrecioBruto + (Convert.ToDecimal(this.IVA) * this.PrecioBruto);
            }
        }
        
        }
}
