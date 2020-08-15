using Projeto.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Api.Tests.Responses
{
    public class FornecedorResponse
    {
        public string Message { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
