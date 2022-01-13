using SolucionCreditos.Data;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;

namespace SolucionCreditos.Business
{
    public class ClientesBusiness
    {
        private readonly ClienteContext clienteContext;

        public ClientesBusiness( )
        {
            this.clienteContext = new ClienteContext();
        }

        public Cliente ObtenerCliente(Int64 idCliente)
        {
            return this.clienteContext.ObtenerCliente(idCliente);
        }

        public List<Cliente> ListarClientes()
        {
            return this.clienteContext.ListarClientes();
        }
        
        public void GuardarCliente(Cliente cliente)
        {
            this.clienteContext.CrearCliente(cliente);
        }


    }
}
