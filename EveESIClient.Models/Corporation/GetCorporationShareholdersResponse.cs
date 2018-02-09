using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationShareholdersResponse
    {
        public Int64 Shareholder_id { get; set; }

        /// <summary>
        /// [ character, corporation ]
        /// </summary>
        public string Shareholder_type { get; set; }
        public Int64 Share_count { get; set; }
    }
}
