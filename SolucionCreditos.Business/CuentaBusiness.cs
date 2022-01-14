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


        public List<Cuenta> ListarCuentasPorCliente(Int64 idCliente)
        {
            return this.cuentaContext.ListarCuentasPorCliente(idCliente);
        }

        public Cuenta ListarCuentasPorIdCuenta(Int64 idCuenta)
        {
            return cuentaContext.ListarCuentasPorIdCuenta(idCuenta);
        }

        /**
         * returns 0 si exito y -1 si ha ocurrido un error
         **/
        public int GuardarCuenta(Cuenta cuenta, Int64 idCliente)
        {
            cuenta.IdCliente = idCliente;
            return this.cuentaContext.NuevaCuenta(cuenta);
        }

        /**
         * returns 0 si exito y -1 si ha ocurrido un error
         **/
        public int ActualizarCuenta(Cuenta cuenta)
        {
            return this.cuentaContext.ActualizarCuenta(cuenta);
        }
    }
}
