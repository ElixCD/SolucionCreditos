using SolucionCreditos.Data;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;

namespace SolucionCreditos.Business
{
    public class CuentaBusiness
    {

        private readonly CuentaContext cuentaContext;

        public CuentaBusiness()
        {
            this.cuentaContext = new CuentaContext();
        }

        public List<Cuenta> ListarCuentas(Int64 idCliente)
        {
            return this.cuentaContext.ListarCuentasPorCliente(idCliente);
        }

        public void GuardarCuenta(Cuenta cuenta, Int64 idCliente)
        {
            cuenta.IdCliente = idCliente;
            this.cuentaContext.GuardarCuenta(cuenta);
        }
    }
}
