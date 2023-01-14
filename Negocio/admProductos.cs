using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class admProductos
    {
        public static List<Producto> Listar()
        {
            List<Producto> productos= new List<Producto>();
            return productos;
        }
        public static List<Producto> Listar(string categoria)
        {
            List<Producto> productos2= new List<Producto>();
            return productos2;
        }

        public static List<Producto> Listar(string categoria, string subcategoria)
        {
            List<Producto> productos3= new List<Producto>();
            return productos3;
        }

        public static Producto ListarDetalle()
        {
            Producto producto= new Producto();
            return producto;
        }
    }
}
