using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationStarbasesResponse
    {
        public Int64 Startbase_id { get; set; }
        public string Type_id { get; set; }
        public Int64 System_id { get; set; }
        public Int64? Moon_id { get; set; }

        /// <summary>
        /// [ offline, online, onlining, reinforced, unanchoring ]
        /// </summary>
        public string State { get; set; }

        public DateTime? Unanchor_at { get; set; }
        public DateTime? Reinforced_until { get; set; }
        public DateTime? Onlined_since { get; set; }

    }
}
