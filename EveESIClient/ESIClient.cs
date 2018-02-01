using EveESIClient.Alliance;
using EveESIClient.Client;
using EveESIClient.Models.Configuration;
using System;
using System.Reflection.Metadata.Ecma335;

namespace EveESIClient
{
    public class ESIClient
    {
        private static ClientConfiguration _clientConfiguration;
        public static ClientConfiguration ClientConfiguration
        {
            get => _clientConfiguration;
            private set => _clientConfiguration = value;
        }
        public AllianceClient Alliance => new AllianceClient(_clientFactory.GetClient());

        private static ClientFactory _clientFactory => new ClientFactory();

        public static void Configure(Action<ClientConfiguration> config)
        {
             config(ClientConfiguration);
        }
    }
}
