﻿using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interface.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioDominio EfetuarLogin(string email, string senha);
    }
}
