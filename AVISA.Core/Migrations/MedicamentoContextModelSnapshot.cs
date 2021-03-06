﻿// <auto-generated />
using System;
using AVISA.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AVISA.Core.Migrations
{
    [DbContext(typeof(MedicamentoContext))]
    partial class MedicamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AVISA.Core.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Horario");

                    b.Property<string>("Nome");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
