using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Industry
{
    public class GetCorporationObservedMiningResponse
    {
        public string Last_updated { get; set; }
        public int Character_id { get; set; }
        public int Recorded_corporation_id { get; set; }
        public int Type_id { get; set; }
        public long quantity { get; set; }
    }
}