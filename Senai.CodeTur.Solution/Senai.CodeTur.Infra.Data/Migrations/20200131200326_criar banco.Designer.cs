﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senai.CodeTur.Infra.Data.Contextos;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    [DbContext(typeof(CodeTurContext))]
    [Migration("20200131200326_criar banco")]
    partial class criarbanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senai.CodeTur.Dominio.Entidades.UsuarioDominio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnName("Tipo")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new { ID = 1, Email = "fernando.guerra@sp.senai.br", Senha = "senai132", Tipo = "Administrador" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
