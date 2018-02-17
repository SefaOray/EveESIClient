using EveESIClient.Alliance;
using EveESIClient.Assets;
using EveESIClient.Bookmarks;
using EveESIClient.Calendar;
using EveESIClient.Character;
using EveESIClient.Client;
using EveESIClient.Clones;
using EveESIClient.Contacts;
using EveESIClient.Contracts;
using EveESIClient.Corporation;
using EveESIClient.Dogma;
using EveESIClient.FactionWarfare;
using EveESIClient.Fittings;
using EveESIClient.Fleets;
using EveESIClient.Industry;
using EveESIClient.Insurance;
using EveESIClient.Killmails;
using EveESIClient.Location;
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

        #endregion Configuration

        #region Clients

        public AllianceClient Alliance => new AllianceClient(_clientFactory.GetClient());
        public AssetsClient Assets => new AssetsClient(_clientFactory.GetClient());
        public BookmarksClient Bookmarks => new BookmarksClient(_clientFactory.GetClient());
        public CalendarClient Calendar => new CalendarClient(_clientFactory.GetClient());
        public CharacterClient Character => new CharacterClient(_clientFactory.GetClient());
        public ClonesClient Implants => new ClonesClient(_clientFactory.GetClient());
        public ContactsClient Contacts => new ContactsClient(_clientFactory.GetClient());
        public ContractsClient Contracts => new ContractsClient(_clientFactory.GetClient());
        public CorporationClient Corporation => new CorporationClient(_clientFactory.GetClient());
        public DogmaClient Dogma => new DogmaClient(_clientFactory.GetClient());
        public FactionWarfareClient FactionWarfare => new FactionWarfareClient(_clientFactory.GetClient());
        public FittingsClient Fittings => new FittingsClient(_clientFactory.GetClient());
        public FleetsClient Fleets => new FleetsClient(_clientFactory.GetClient());
        public IndustryClient Industry => new IndustryClient(_clientFactory.GetClient());
        public InsuranceClient Insurance => new InsuranceClient(_clientFactory.GetClient());
        public KillmailsClient Killmails => new KillmailsClient(_clientFactory.GetClient());
        public LocationClient Location => new LocationClient(_clientFactory.GetClient());

        #endregion Clients

        public static void Configure(Func<ClientConfiguration> config)
        {
            ClientConfiguration = config();
        }
    }
}