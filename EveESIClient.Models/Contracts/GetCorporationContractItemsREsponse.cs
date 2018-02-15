using System;

namespace EveESIClient.Models.Contracts
{
    public class GetCorporationContractItemsResponse
    {
        public Int64 Record_id { get; set; }
        public Int64 Type_id { get; set; }
        public Int32 Quantity { get; set; }

        /// <summary>
        /// -1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy
        /// </summary>
        public Int32? Raw_quantity { get; set; }

        public bool Is_singleton { get; set; }

        /// <summary>
        /// true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract.
        /// </summary>
        public bool Is_included { get; set; }
    }
}
}