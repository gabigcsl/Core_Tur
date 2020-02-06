using Microsoft.EntityFrameworkCore;
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
    public class TestePacotes
    {
        
        [Fact]
        public void TestePacoteCadastrar()
        {

            var options = new DbContextOptionsBuilder<CodeTurContext>()
                .UseInMemoryDatabase(databaseName: "PacoteCadastrar")
                .Options;

            PacotesDominio pacote = new PacotesDominio()
            {
                Nome = "Estados Unidos, California",
                Valor = "a partir de R$1.500,00",
                Descricao = "Uma semana conhecendo uma nova cultura e adquirindo diversos conhecimentos na área de tecnologia",
                Imagem = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiOgILvsrjnAhWzGbkGHe-kCV0QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.dicasdelasvegas.com.br%2F2014%2F08%2Fseguro-viagem-para-san-francisco-na-california.html&psig=AOvVaw0iqiNDencWdPBlHiURCd6x&ust=1580922803794103",
                Ativo = true
            };
        }
    }
}
