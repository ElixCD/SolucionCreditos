using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionCreditos.Models
{
    public class MovimientoViewModel
    {
        public Movimiento Movimiento { get; set; }

        public List<TipoMovimiento> TipoMovimiento { get; set; }

    }
}
