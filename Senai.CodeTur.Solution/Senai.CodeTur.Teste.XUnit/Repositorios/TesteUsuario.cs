using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interface.Repositorio;
using Senai.CodeTur.Infra.Data.Contextos;
using Senai.CodeTur.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios
{
    public class TesteUsuario
    {
     

        [Fact]
        public void UsuarioInvalido()
        {
            var options = new DbContextOptionsBuilder<CodeTurContext>()
                .UseInMemoryDatabase(databaseName: "UsuarioEInvalido")
                .Options;

            // Use a clean instance of the context to run the test
            using (var context = new CodeTurContext(options))
            {
                var repo = new UsuarioRepositorio(context);
                var validacao = repo.EfetuarLogin("admin@gmail.co", "12345");

                Assert.Null(validacao);
            }
        }

        [Fact]
        public void UsuarioValido()
        {
            var options = new DbContextOptionsBuilder<CodeTurContext>()
               .UseInMemoryDatabase(databaseName: "UsuarioValido")
               .Options;

            using (var context = new CodeTurContext(options))
            {
                var repo = new UsuarioRepositorio(context);
                var validacao = repo.EfetuarLogin("fernando.guerra@sp.senai.br", "senai132");

                Assert.Null(validacao);
            }
        }

    }
}



   

    