using EveESIClient.Alliance;
using EveESIClient.Assets;
using EveESIClient.Bookmarks;
using EveESIClient.Client;
using EveESIClient.Models.Configuration;
using System;

namespace EveESIClient
{
    public class ESIClient
    {
        #region Configuration
        private static ClientConfiguration _clientConfiguration;
        public static ClientConfiguration ClientConfiguration
        {
            get => _clientConfiguration;
            private set => _clientConfiguration = value;
        }
        private static ClientFactory _clientFactory => new ClientFactory();
        #endregion

        #region Clients
        public AllianceClient Alliance => new AllianceClient(_clientFactory.GetClient());
        public AssetsClient Assets => new AssetsClient(_clientFactory.GetClient());
        public BookmarksClient Bookmarks => new BookmarksClient(_clientFactory.GetClient());
        #endregion

        public static void Configure(Func<ClientConfiguration> config)
        {
            ClientConfiguration = config();
        }
    }
}