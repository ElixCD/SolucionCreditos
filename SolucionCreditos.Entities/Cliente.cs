using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SolucionCreditos.Entities
{
    public class Cliente
    {
        [Key]
        public Int64 IdCliente { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public virtual List<Cuenta> Cuentas { get; set; }
    }
}
