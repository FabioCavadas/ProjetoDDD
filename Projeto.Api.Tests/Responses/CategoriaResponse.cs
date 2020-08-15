using Projeto.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Api.Tests.Responses
{
    public class CategoriaResponse
    {
        public string Message { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}
