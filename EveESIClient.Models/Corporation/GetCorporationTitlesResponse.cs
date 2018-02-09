using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationTitlesResponse
    {
        public int Title_id { get; set; }
        public string Name { get; set; }
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
