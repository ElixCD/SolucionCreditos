using Microsoft.EntityFrameworkCore;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionCreditos.Data
{
   public  class SolucionCreditoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cuenta> Cuentas { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }

        public DbSet<TipoMovimiento> TipoMovimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=SolucionCredito00;Trusted_Connection=True;");
            }
        }
    }
}
