using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class admClientes
    {
  
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            List<ClienteIndividuo> listaIndividuos = new List<ClienteIndividuo>();
            return listaIndividuos;
        }

        public static ClienteIndividuo ListarClienteIndividuo(string CUIT)
        {
            ClienteIndividuo individuo = new ClienteIndividuo();
            return individuo;
        }

        public static List<Empresa> ListarEmpresa()
        {
            List<Empresa> listaEmpresas= new List<Empresa>();
            return listaEmpresas;
        }

        public static Empresa ListarEmpresa(string CUIT)
        {
            Empresa empresa = new Empresa();
            return empresa;
        }

    }
}
