using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interface.Repositorio;
using Senai.CodeTur.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorio
{
    public class PacotesRepositorio : IPacotesRepositorio
    {

        private CodeTurContext _context;
        public PacotesRepositorio(CodeTurContext context)
        {
            _context = context;
        }

        public PacotesDominio Cadastrar(PacotesDominio pacotes)
        {
            throw new NotImplementedException();
        }

        public List<PacotesDominio> Listar(bool? todos = null)
        {
            try
            {
                if (todos == null)
                {
                    return _context.Pacotes.ToList();
                }
                else if (todos == true)
                {
                    return _context.Pacotes.Where(x => x.Ativo == true).ToList();
                }
                else
                {
                    return _context.Pacotes.Where(x => x.Ativo == false).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PacotesDominio> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
