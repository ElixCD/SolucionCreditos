using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Data
{
    public class CuentaContext
    {
        public Cuenta ObtenerCuentasPorCliente(Int64 idCliente)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Cuentas.Where(c => c.Cliente.IdCliente == idCliente).Select(c => c).FirstOrDefault();
            }
        }

        public Cuenta ObtenerCuentasPorId(Int64 idCuenta)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Cuentas.Where(c => c.IdCuenta == idCuenta).Select(c => c).FirstOrDefault();
            }
        }

        public List<Cuenta> ListarCuentasPorCliente(Int64 idCliente)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Cuentas.Where(c => c.Cliente.IdCliente == idCliente).Select(c => c).ToList();
            }
        }

        public Cuenta ListarCuentasPorIdCuenta(Int64 idCuenta)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Cuentas.Where(c => c.IdCuenta == idCuenta).Select(c => c).FirstOrDefault();
            }
        }

        /**
         * @returns 0 si exito y -1 si ha ocurrido un error
         **/
        public int NuevaCuenta(Cuenta cuenta)
        {
            try
            {
                using (var contexto = new SolucionCreditoContext())
                {
                    contexto.Cuentas.Add(cuenta);
                    contexto.SaveChanges();
                }
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        /**
         * returns 0 si exito y -1 si ha ocurrido un error
         **/
        public int ActualizarCuenta(Cuenta cuenta)
        {
            try
            {
                using (var contexto = new SolucionCreditoContext())
                {
                    Cuenta current = contexto.Cuentas.Where(c => c.IdCuenta == cuenta.IdCuenta).FirstOrDefault();
                    current.Saldo = cuenta.Saldo;
                    contexto.SaveChanges();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

    }
}
