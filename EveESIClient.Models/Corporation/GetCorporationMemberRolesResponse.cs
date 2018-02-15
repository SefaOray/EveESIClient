using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationMemberRolesResponse
    {
        public Int64 Character_id { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Grantable_roles { get; set; }
        public List<string> Roles_at_hq { get; set; }
        public List<string> Grantable_roles_at_hq { get; set; }
        public List<string> Roles_at_base { get; set; }
        public List<string> Grantable_roles_at_base { get; set; }
        public List<string> Roles_at_other { get; set; }
        public List<string> Grantable_roles_at_other { get; set; }
    }
}