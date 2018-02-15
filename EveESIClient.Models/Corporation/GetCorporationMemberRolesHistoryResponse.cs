using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationMemberRolesHistoryResponse
    {
        public Int64 Character_id { get; set; }
        public DateTime Changed_at { get; set; }
        public Int64 Issuer_id { get; set; }
        public string Role_type { get; set; }
        public List<string> Old_roles { get; set; }
        public List<string> New_roles { get; set; }
    }
}