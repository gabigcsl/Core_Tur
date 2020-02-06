using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interface.Repositorio;
using Senai.CodeTur.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private CodeTurContext _context;

        public UsuarioRepositorio(CodeTurContext context)
        {
            _context = context;
        }

        public UsuarioDominio EfetuarLogin(string email, string senha)
        {

            if (string.IsNullOrEmpty(senha))
                throw new ArgumentException("A senha não pode ser nula");

           
                return _context.Usuario.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            
        }
    }
}
