using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationIssuedMedals
    {
        public Int64 Medal_id { get; set; }
        public Int64 Character_id { get; set; }
        public string Reason { get; set; }

        /// <summary>
        /// [ private, public ]
        /// </summary>
        public string Status { get; set; }
        public Int64 Issuer_id { get; set; }
        public DateTime Issued_at { get; set; }
    }
}
