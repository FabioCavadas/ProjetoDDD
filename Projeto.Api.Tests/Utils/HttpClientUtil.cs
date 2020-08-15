using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Projeto.Api.Tests.Utils
{
    public class HttpClientUtil
    {
        //montar o corpo da requisição que será enviada para a API
        public static StringContent CreateContent(object model)
        {
            return new StringContent(JsonConvert.SerializeObject(model),
                Encoding.UTF8, "application/json");
        }

        //retornar o resultado obtido da API em JSON
        public static string GetContent(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
