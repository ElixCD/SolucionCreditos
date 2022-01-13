﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolucionCreditos.Data;

namespace SolucionCreditos.Data.Migrations
{
    [DbContext(typeof(SolucionCreditoContext))]
    [Migration("20220113211618_SolucionesCreditoDB")]
    partial class SolucionesCreditoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SolucionCreditos.Entities.Cliente", b =>
                {
                    b.Property<long>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SolucionCreditos.Entities.Cuenta", b =>
                {
                    b.Property<long>("IdCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint");

                    b.Property<string>("NumeroCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.HasKey("IdCuenta");

                    b.HasIndex("IdCliente");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("SolucionCreditos.Entities.Movimiento", b =>
                {
                    b.Property<long>("IdMovimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("IdCuenta")
                        .HasColumnType("bigint");

                    b.Property<int>("IdTipoMovimiento")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdMovimiento");

                    b.HasIndex("IdCuenta");

                    b.HasIndex("IdTipoMovimiento");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("SolucionCreditos.Entities.TipoMovimiento", b =>
                {
                    b.Property<int>("IdTipoMovimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoMovimiento");

                    b.ToTable("TipoMovimientos");
                });

            modelBuilder.Entity("SolucionCreditos.Entities.Cuenta", b =>
                {
                    b.HasOne("SolucionCreditos.Entities.Cliente", "Cliente")
                        .WithMany("Cuentas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SolucionCreditos.Entities.Movimiento", b =>
                {
                    b.HasOne("SolucionCreditos.Entities.Cuenta", "Cuenta")
                        .WithMany("Movimientos")
                        .HasForeignKey("IdCuenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SolucionCreditos.Entities.TipoMovimiento", "TipoMovimiento")
                        .WithMany()
                        .HasForeignKey("IdTipoMovimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
