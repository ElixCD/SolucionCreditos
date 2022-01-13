using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SolucionCreditos.Entities
{
    public class Cuenta
    {        

        [Key]
        public Int64 IdCuenta { get; set; }

        [Required]
        public string NumeroCuenta { get; set; }

        [Required]
        public double Saldo { get; set; }

        [ForeignKey("Cliente")]
        public Int64 IdCliente { get; set; }
        
        public virtual Cliente Cliente { get; set; }
        
        public virtual List<Movimiento> Movimientos { get; set; }

    }
}
