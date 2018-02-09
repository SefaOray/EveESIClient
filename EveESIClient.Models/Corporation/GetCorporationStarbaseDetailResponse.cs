using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationStarbaseDetailResponse
    {
        public string Fuel_bay_view { get; set; }
        public string Fuel_bay_take { get; set; }
        public string Anchor { get; set; }
        public string Online { get; set; }
        public string Offline { get; set; }
        public bool Allow_corporation_members { get; set; }
        public bool Allow_alliance_members { get; set; }
        public bool Use_alliance_standings { get; set; }
        public float? Attack_standing_treshhold { get; set; }
        public float? Attack_security_status_trehshold { get; set; }
        public bool Attack_if_other_security_status_dropping { get; set; }
        public bool Attack_if_at_war { get; set; }
        public StarbaseDetailFuel Fuels { get; set; }

        public class StarbaseDetailFuel
        {
            public int Type_id { get; set; }
            public int Quantity { get; set; }
        }
    }
}
