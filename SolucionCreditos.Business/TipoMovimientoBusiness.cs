using SolucionCreditos.Data;
using SolucionCreditos.Entities;
using System.Collections.Generic;

namespace SolucionCreditos.Business
{
    public class TipoMovimientoBusiness
    {
        private readonly TipoMovimientoContext tipoMovimientoContext;

        public TipoMovimientoBusiness()
        {
            this.tipoMovimientoContext = new TipoMovimientoContext();
        }

        public TipoMovimiento ObtenerTipoMovimiento(int idTipoMovimiento)
        {
            return this.tipoMovimientoContext.ObtenerTipoMovimiento(idTipoMovimiento);
        }

        public List<TipoMovimiento> ListarTipoMovimiento()
        {
            return this.tipoMovimientoContext.ListarTipoMovimientos();
        }

        public void GuardarTipoMovimiento(TipoMovimiento tipoMovimiento)
        {
            this.tipoMovimientoContext.CrearTipoMovimiento(tipoMovimiento);
        }
    }
}
