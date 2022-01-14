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
                var movimientos = contexto.Movimientos
                    .Select(c => c).ToList();

                movimientos.ForEach(movimiento => {
                        movimiento.TipoMovimiento = contexto.TipoMovimientos.Where(mov => mov.IdTipoMovimiento == movimiento.IdTipoMovimiento).Select(p => p).FirstOrDefault();
                    movimiento.Cuenta = contexto.Cuentas.Where(mov => mov.IdCuenta == movimiento.IdCuenta).Select(p => p).FirstOrDefault();
                });

                return movimientos;
                
            }
        }

        public List<Movimiento> ListarMovimientosPorCuenta(Int64 idCuenta)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                var movimientos = contexto.Movimientos.Where(m => m.IdCuenta == idCuenta).Select(c => c).ToList();
                movimientos.ForEach(movimiento => {
                    movimiento.TipoMovimiento = contexto.TipoMovimientos.Where(mov => mov.IdTipoMovimiento == movimiento.IdTipoMovimiento).Select(p => p).FirstOrDefault();
                    movimiento.Cuenta = contexto.Cuentas.Where(mov => mov.IdCuenta == movimiento.IdCuenta).Select(p => p).FirstOrDefault();
                });

                return movimientos;
            }
        }

        public List<Movimiento> ListarMovimientosPorTipo(int idTipo)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                var movimientos = contexto.Movimientos.Where(t => t.IdTipoMovimiento == idTipo).Select(c => c).ToList();

                movimientos.ForEach(movimiento => {
                    movimiento.TipoMovimiento = contexto.TipoMovimientos.Where(mov => mov.IdTipoMovimiento == movimiento.IdTipoMovimiento).Select(p => p).FirstOrDefault();

                });

                return movimientos;
            }
        }

        public List<Movimiento> ListarMovimientosPorCuentaYTipo(Int64 idCuenta, int idTipo)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                var movimientos = contexto.Movimientos.Where(m => m.IdTipoMovimiento == idTipo && m.IdCuenta == idCuenta).Select(c => c).ToList();

                movimientos.ForEach(movimiento => {
                    movimiento.TipoMovimiento = contexto.TipoMovimientos.Where(mov => mov.IdTipoMovimiento == movimiento.IdTipoMovimiento).Select(p => p).FirstOrDefault();
                    movimiento.Cuenta = contexto.Cuentas.Where(mov => mov.IdCuenta == movimiento.IdCuenta).Select(p => p).FirstOrDefault();
                });

                return movimientos;
            }
        }

        public void CrearMovimiento(Movimiento movimiento)
        {
            using (var contexto = new SolucionCreditoContext())
            {

                Movimiento mov = new Movimiento()
                {
                    IdCuenta = movimiento.IdCuenta,
                    Cuenta = contexto.Cuentas.Where(i => i.IdCuenta == movimiento.IdCuenta).Select(c => c).FirstOrDefault(),
                    IdMovimiento = movimiento.IdMovimiento,
                    IdTipoMovimiento = movimiento.IdTipoMovimiento,
                    TipoMovimiento = contexto.TipoMovimientos.Where(i => i.IdTipoMovimiento == movimiento.IdTipoMovimiento).Select(c => c).FirstOrDefault(),
                    Monto = movimiento.Monto
                };

                contexto.Movimientos.Add(mov);
                contexto.SaveChanges();
            }
        }
    }
}
