using SolucionCreditos.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Data
{
    public class TipoMovimientoContext
    {
        public TipoMovimiento ObtenerTipoMovimiento(int idTipoMovimiento)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.TipoMovimientos.Where(c => c.IdTipoMovimiento == idTipoMovimiento).Select(c => c).FirstOrDefault();
            }
        }

        public List<TipoMovimiento> ListarTipoMovimientos()
        {
            using (var contexto = new SolucionCreditoContext())
            {
                return contexto.TipoMovimientos.Select(c => c).ToList();
            }
        }

        public void CrearTipoMovimiento(TipoMovimiento tipoMovimiento)
        {
            using (var contexto = new SolucionCreditoContext())
            {
                contexto.TipoMovimientos.Add(tipoMovimiento);
                contexto.SaveChanges();
            }
        }
    }
}
