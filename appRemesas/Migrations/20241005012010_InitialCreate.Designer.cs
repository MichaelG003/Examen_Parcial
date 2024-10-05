﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using appRemesas.Data;

#nullable disable

namespace appRemesas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241005012010_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("appRemesas.Models.Conversion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaConversion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("MontoBTC")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MontoUSD")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TasaCambio")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Conversiones");
                });

            modelBuilder.Entity("appRemesas.Models.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Destinatario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Moneda")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Monto")
                        .HasColumnType("numeric");

                    b.Property<string>("Remitente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
