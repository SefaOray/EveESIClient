using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Incursions
{
    public class ListIncursionsResponse
    {
        public string Type { get; set; }
        /// <summary>
        /// [ withdrawing, mobilizing, established ]
        /// </summary>
        public string State { get; set; }
        public float Influence { get; set; }
        public bool Has_boss { get; set; }
        public int Faction_id { get; set; }
        public int Constellation_id { get; set; }
        public int Staging_solar_system_id { get; set; }
        public List<int> Infested_solar_systems { get; set; }
    }
}
