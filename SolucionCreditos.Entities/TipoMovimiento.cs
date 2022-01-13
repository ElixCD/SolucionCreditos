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
        public string Nombre { get; set; }

        [Required]
        public bool Entrada { get; set; }
    }
}
