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

        public Cuenta ObtenerCuentasPorCliente(Int64 idCliente)
        {
            return this.cuentaContext.ObtenerCuentasPorCliente(idCliente);
        }

        public Cuenta ObtenerCuentasPorId(Int64 idCuenta)
        {
            return this.cuentaContext.ObtenerCuentasPorId(idCuenta);
        }


        public List<Cuenta> ListarCuentas(Int64 idCliente)
        {
            return this.cuentaContext.ListarCuentasPorCliente(idCliente);
        }

        public Cuenta ListarCuentasPorIdCuenta(Int64 idCuenta)
        {
            return cuentaContext.ListarCuentasPorIdCuenta(idCuenta);
        }

        public void GuardarCuenta(Cuenta cuenta, Int64 idCliente)
        {
            cuenta.IdCliente = idCliente;
            this.cuentaContext.NuevaCuenta(cuenta);
        }

        public void ActualizarCuenta(Cuenta cuenta)
        {
            this.cuentaContext.ActualizarCuenta(cuenta);
        }
    }
}
