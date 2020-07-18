using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Usuarios.Exceptions
{
    public class EmailUnicoException : Exception
    {
        public override string Message => "Já existe um usuário com este email cadastrado.";

    }
}
