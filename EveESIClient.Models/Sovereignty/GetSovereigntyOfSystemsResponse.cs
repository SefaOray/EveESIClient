using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Sovereignty
{
    public class GetSovereigntyOfSystemsResponse
    {
        public int System_id { get; set; }
        public int? Alliance_id { get; set; }
        public int? Corporation_id { get; set; }
        public int? Faction_id { get; set; }
    }
}
