using SolucionCreditos.Data;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;

namespace SolucionCreditos.Business
{
    public class MovimientoBusiness
    {
        private readonly MovimientoContext movimientoContext;

        public MovimientoBusiness()
        {
            this.movimientoContext = new MovimientoContext();
        }

        public Movimiento ObtenerMovimiento(int idMovimiento)
        {
            return movimientoContext.ObtenerMovimiento(idMovimiento);
        }

        public List<Movimiento> ListarMovimientos()
        {
            return movimientoContext.ListarMovimientos();
        }

        public List<Movimiento> ListarMovimientosPorCuenta(Int64 idCuenta)
        {
            return movimientoContext.ListarMovimientosPorCuenta(idCuenta);
        }

        public List<Movimiento> ListarMovimientosPorTipo(int idTipo)
        {
            return movimientoContext.ListarMovimientosPorTipo(idTipo);
        }

        public List<Movimiento> ListarMovimientosPorCuentaYTipo(Int64 idCuenta, int idTipo)
        {
            return movimientoContext.ListarMovimientosPorCuentaYTipo(idCuenta, idTipo);
        }

        /**
         * param name="movimiento"
         * returns 0 si exito, 1 si es una operación no valida y -1 si ha ocurrido un error
         **/
        public int CrearMovimiento(Movimiento movimiento)
        {
            int salida = 0;
            CuentaBusiness cuentaBusiness = new CuentaBusiness();
            Cuenta cuenta = cuentaBusiness.ListarCuentasPorIdCuenta(movimiento.IdCuenta);

            TipoMovimientoBusiness tipoMovimientoBusiness = new TipoMovimientoBusiness();
            TipoMovimiento tipoMovimiento = tipoMovimientoBusiness.ObtenerTipoMovimiento(movimiento.IdTipoMovimiento);

            if (tipoMovimiento.Deposito)
            {
                cuenta.Saldo = cuenta.Saldo + movimiento.Monto;               
            }
            else
            {
                if (cuenta.Saldo < movimiento.Monto) 
                    salida = 1;
                else
                    cuenta.Saldo = cuenta.Saldo - movimiento.Monto;
            }

            if(salida == 0)
            {
                salida = movimientoContext.CrearMovimiento(movimiento);
                salida = cuentaBusiness.ActualizarCuenta(cuenta);
            }
            
            return 0;
        }
    }
}
