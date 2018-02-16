using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Industry
{
    public class GetCorporationMiningObserversResponse
    {
        public string Last_updated { get; set; }
        public long Observer_id { get; set; }
        public string Observer_type { get; set; }
    }
}