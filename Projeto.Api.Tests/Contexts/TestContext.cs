using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Projeto.Api.Tests.Contexts
{
    public class TestContext
    {
        //atributo
        private TestServer testServer;

        //propriedade para realizar acesso à API
        public HttpClient HttpClient { get; set; }

        //construtor 
        public TestContext()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            testServer = new TestServer(new WebHostBuilder()
                .UseConfiguration(configuration)
                .UseStartup<Presentation.Api.Startup>());

            HttpClient = testServer.CreateClient();
        }
    }
}
