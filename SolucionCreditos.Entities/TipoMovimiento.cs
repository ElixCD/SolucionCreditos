using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SolucionCreditos.Entities
{
    public class TipoMovimiento
    {
        [Key]
        public int IdTipoMovimiento { get; set; }

        [Required]
        public string Concepto { get; set; }

        [Required]
        public bool Deposito { get; set; }

        public List<Movimiento> Movimientos { get; set; }

        public TipoMovimiento()
        {
            this.Movimientos = new List<Movimiento>();
        }
    }
}
