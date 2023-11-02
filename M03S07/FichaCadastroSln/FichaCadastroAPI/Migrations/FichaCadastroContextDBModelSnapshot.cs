﻿// <auto-generated />
using System;
using FichaCadastroAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FichaCadastroAPI.Migrations
{
    [DbContext(typeof(FichaCadastroContextDB))]
    partial class FichaCadastroContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FichaCadastroAPI.Model.DetalheModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FichaId")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("Detalhe");
                });

            modelBuilder.Entity("FichaCadastroAPI.Model.FichaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Ficha");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCadastro = new DateTime(2023, 9, 18, 19, 27, 15, 25, DateTimeKind.Local).AddTicks(3010),
                            DataNascimento = new DateTime(2023, 9, 18, 19, 27, 15, 25, DateTimeKind.Local).AddTicks(3020),
                            Email = "teste1@email.com.br",
                            Nome = "teste umes"
                        },
                        new
                        {
                            Id = 2,
                            DataCadastro = new DateTime(2023, 9, 18, 19, 27, 15, 25, DateTimeKind.Local).AddTicks(3023),
                            DataNascimento = new DateTime(1993, 9, 18, 19, 27, 15, 25, DateTimeKind.Local).AddTicks(3023),
                            Email = "teste2@email.com.br",
                            Nome = "teste dois"
                        });
                });

            modelBuilder.Entity("FichaCadastroAPI.Model.DetalheModel", b =>
                {
                    b.HasOne("FichaCadastroAPI.Model.FichaModel", "Ficha")
                        .WithMany("DetalheModels")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("FichaCadastroAPI.Model.FichaModel", b =>
                {
                    b.Navigation("DetalheModels");
                });
#pragma warning restore 612, 618
        }
    }
}
