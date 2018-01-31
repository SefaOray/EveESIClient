using EveESIClient.Alliance;
using EveESIClient.Client;
using EveESIClient.Models.Configuration;
using System;

namespace EveESIClient
{
    public class ESIClient
    {
        public static ClientConfiguration ClientConfiguration
        {
            get => ClientConfiguration ?? throw new InvalidOperationException("Client is not initialized.");
            set
            {
                ClientConfiguration = ClientConfiguration == null ? value : throw new InvalidOperationException("Client already initialized.");
            }
        }
        public AllianceClient Alliance => new AllianceClient(_clientFactory.GetClient());

        private static ClientFactory _clientFactory => new ClientFactory();

        public static void Configure(Action<ClientConfiguration> config)
        {
             config(ClientConfiguration);
        }
    }
}
