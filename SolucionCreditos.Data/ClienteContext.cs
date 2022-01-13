using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolucionCreditos.Data
{
    public class ClienteContext
    {
        public Cliente ObtenerCliente(Int64 idCliente)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Clientes.Where(c => c.IdCliente == idCliente).Select(c => c).FirstOrDefault();
            }
        }

        public List<Cliente> ListarClientes()
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Clientes.Select(c => c).ToList();
            }
        }

        public void CrearCliente(Cliente cliente)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            }
        }
    }
}
