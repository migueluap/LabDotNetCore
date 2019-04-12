﻿// <auto-generated />
using FilmesCRUDRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmesCRUDRazor.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("FilmesCRUDRazor.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataLancamento");

                    b.Property<string>("Genero");

                    b.Property<decimal>("Preco");

                    b.Property<string>("Titulo");

                    b.HasKey("FilmeId");

                    b.ToTable("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}
