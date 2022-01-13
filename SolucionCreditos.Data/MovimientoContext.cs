using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Data
{
    public class MovimientoContext
    {
        public Movimiento ObtenerMovimiento(int idMovimiento)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Movimientos.Where(c => c.IdTipoMovimiento == idMovimiento).Select(c => c).FirstOrDefault();
            }
        }

        public List<Movimiento> ListarMovimientos()
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Movimientos.Select(c => c).ToList();
            }
        }

        public List<Movimiento> ListarMovimientosPorCuenta(Int64 idCuenta)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Movimientos.Where(m => m.IdCuenta == idCuenta).Select(c => c).ToList();
            }
        }

        public List<Movimiento> ListarMovimientosPorTipo(int idTipo)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Movimientos.Where(t => t.IdTipoMovimiento == idTipo).Select(c => c).ToList();
            }
        }

        public List<Movimiento> ListarMovimientosPorCuentaYTipo(Int64 idCuenta, int idTipo)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.Movimientos.Where(m => m.IdTipoMovimiento == idTipo && m.IdCuenta == idCuenta).Select(c => c).ToList();
            }
        }

        public void CrearMovimiento(Movimiento movimiento)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                contexto.Movimientos.Add(movimiento);
                contexto.SaveChanges();
            }
        }
    }
}
