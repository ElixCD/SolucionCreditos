using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Data
{
    public class CuentaContext
    {
        public List<Cuenta> ListarCuentasPorCliente(Int64 idCliente)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Cuentas.Where(c => c.Cliente.IdCliente == idCliente).Select(c => c).ToList();
            }
        }

        public void GuardarCuenta(Cuenta cuenta)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                contexto.Cuentas.Add(cuenta);
                contexto.SaveChanges();
            }
        }
    }
}
