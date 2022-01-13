using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SolucionCreditos.Entities
{
    public class Movimiento
    {
        [Key]
        public Int64 IdMovimiento { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [ForeignKey("Cuenta")]
        public Int64 IdCuenta { get; set; }

        [ForeignKey("TipoMovimiento")]
        public int IdTipoMovimiento { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual TipoMovimiento TipoMovimiento { get; set; }
    }
}
