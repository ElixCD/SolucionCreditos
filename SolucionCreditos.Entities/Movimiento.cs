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
        public double Monto { get; set; }

        public Int64 IdCuenta { get; set; }

        public int IdTipoMovimiento { get; set; }

        [ForeignKey("IdCuenta")]
        public Cuenta Cuenta { get; set; }

        [ForeignKey("IdTipoMovimiento")]
        public TipoMovimiento TipoMovimiento { get; set; }

        public Movimiento()
        {
            this.Cuenta = new Cuenta();
            this.TipoMovimiento = new TipoMovimiento();
        }
    }
}
