using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionCreditos.Models
{
    public class ClienteViewModel
    {
        public Int64 IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; set; }

        public List<Cuenta> Cuentas { get; set; }

    }
}
