using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Usuarios.Exceptions
{
    public class PerfilUnicoException : Exception
    {
        public override string Message => "Já existe um perfil cadastrado com o nome informado.";
    }
}
