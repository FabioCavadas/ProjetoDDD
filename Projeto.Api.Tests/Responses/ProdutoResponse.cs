using Projeto.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Api.Tests.Responses
{
    public class ProdutoResponse
    {
        public string Message { get; set; }
        public ProdutoDTO Produto { get; set; }
    }
}
