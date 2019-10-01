using System;
using GovApi.Core;
using JetBrains.Annotations;

namespace GovApi.Fda
{
    [PublicAPI]
    public class Client : JsonBaseClient
    {
        public Client(string apiKey) : base("https://api.fda.gov")
        {
            ApiKey = apiKey;
        }

        public string ApiKey { get; set; }
    }
}
