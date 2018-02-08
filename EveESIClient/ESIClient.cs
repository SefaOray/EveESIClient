using EveESIClient.Alliance;
using EveESIClient.Assets;
using EveESIClient.Bookmarks;
using EveESIClient.Calendar;
using EveESIClient.Character;
using EveESIClient.Client;
using EveESIClient.Clones;
using EveESIClient.Contacts;
using EveESIClient.Contracts;
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
        public CalendarClient Calendar => new CalendarClient(_clientFactory.GetClient());
        public CharacterClient Character => new CharacterClient(_clientFactory.GetClient());
        public ClonesClient Implants => new ClonesClient(_clientFactory.GetClient());
        public ContactsClient Contacts => new ContactsClient(_clientFactory.GetClient());
        public ContractsClient Contracts => new ContractsClient(_clientFactory.GetClient());
        #endregion

        public static void Configure(Func<ClientConfiguration> config)
        {
            ClientConfiguration = config();
        }
    }
}