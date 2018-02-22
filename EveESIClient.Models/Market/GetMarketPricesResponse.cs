using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Market
{
    public class GetMarketPricesResponse
    {
        public int Type_id { get; set; }
        public double? Average_price { get; set; }
        public double? Adjusted_price { get; set; }
    }
}