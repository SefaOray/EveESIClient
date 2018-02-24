using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.PlanetaryInteraction
{
    public class GetCorporationCustomsOfficesResponse
    {
        public long Office_id { get; set; }
        public int System_id { get; set; }
        public int Reinforce_exit_start { get; set; }
        public int Reinforce_exit_end { get; set; }
        public bool Alow_alliance_access { get; set; }
        public bool Allow_access_with_standings { get; set; }
        public string Standing_level { get; set; }
        public float? Corporation_tax_rate { get; set; }
        public float? Alliance_tax_rate { get; set; }
        public float? Excellent_standing_tax_rate { get; set; }
        public float? Good_standing_tax_rate { get; set; }
        public float? Neutral_standing_tax_rate { get; set; }
        public float? Bad_standing_tax_rate { get; set; }
        public float? Terrible_standing_tax_rate { get; set; }
    }
}