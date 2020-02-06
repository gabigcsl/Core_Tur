using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Contextos
{
    public class CodeTurContext : DbContext 
    {
        public DbSet<UsuarioDominio> Usuario { get; set; }

        public DbSet<PacotesDominio> Pacotes { get; set; }

        //Metodo construtor passando como parametros as opções do Contexto
        public CodeTurContext(DbContextOptions<CodeTurContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress3t;Initial Catalog=CodeTur_tarde;User ID=sa;Password=sa132");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(new UsuarioDominio()
            {
                ID=1,
                Email = "fernando.guerra@sp.senai.br",
                Senha = "senai132",
                Tipo = "Administrador"
            });
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
