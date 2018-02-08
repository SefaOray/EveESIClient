using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Contracts
{
    public class GetCharacterContractBidsResponse
    {
        public Int64 Bid_id { get; set; }
        public Int64 Bidder_id { get; set; }
        public string Date_bid { get; set; }
        public float Amount { get; set; }
    }
}
