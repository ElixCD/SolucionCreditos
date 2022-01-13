using SolucionCreditos.Data;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionCreditos.Business
{
    public class MovimientoBusiness
    {
        private readonly MovimientoContext movimientoContext;

        public MovimientoBusiness()
        {
            this.movimientoContext = new MovimientoContext();
        }

        public Movimiento ObtenerMovimiento(int idTipoMovimiento)
        {
            return this.movimientoContext.ObtenerMovimiento(idTipoMovimiento);
        }

        public List<Movimiento> ListarMovimiento()
        {
            return this.movimientoContext.ListarMovimientos();
        }

        public List<Movimiento> ListarMovimiento(int idTipo)
        {
            return this.movimientoContext.ListarMovimientosPorTipo(idTipo);
        }

        public void GuardarMovimiento(Movimiento tipoMovimiento)
        {
            this.movimientoContext.CrearMovimiento(tipoMovimiento);
        }
    }
}
