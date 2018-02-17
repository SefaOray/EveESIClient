using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Loyalty
{
    public class GetLoyaltyStoreOffersResponse
    {
        public int Offer_id { get; set; }
        public int Type_id { get; set; }
        public int Quantity { get; set; }
        public int Lp_cost { get; set; }
        public Int64 Isk_cost { get; set; }
        public List<LoyaltyOfferRequiredItem> Required_items { get; set; }
        

        public class LoyaltyOfferRequiredItem
        {
            public int Type_id { get; set; }
            public int Quantity { get; set; }
        }
    }
}