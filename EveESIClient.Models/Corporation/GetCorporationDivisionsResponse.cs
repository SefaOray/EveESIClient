using System.Collections.Generic;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationDivisionsResponse
    {
        public List<CorporationDivisionsHangar> Hangar { get; set; }
        public List<CorporationDivisionsWallet> Wallet { get; set; }

        public class CorporationDivisionsHangar
        {
            public int? Division { get; set; }
            public string Name { get; set; }
        }

        public class CorporationDivisionsWallet
        {
            public int? Division { get; set; }
            public string Name { get; set; }
        }
    }
}