using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Projeto.Api.Tests.Contexts
{
    public class TestContext
    {
        public HttpClient HttpClient { get; set; }

        //construtor -> ctor + 2x[tab]
        public TestContext()
        {
            //ler o arquivo appsettings.json do projeto Presentation.Api
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            //executando o projeto Presentation.Api (Startup)
            var testServer = new TestServer(
                    new WebHostBuilder()
                    .UseConfiguration(configuration)
                    .UseStartup<Presentation.Api.Startup>()
                );

            //criando o HttpClient (cliente da api)
            HttpClient = testServer.CreateClient();
        }
    }
}
