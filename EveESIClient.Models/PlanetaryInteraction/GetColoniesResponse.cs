using System;

namespace EveESIClient.Models.PlanetaryInteraction
{
    public class GetColoniesResponse
    {
        public int Solar_system_id { get; set; }
        public int Upgrade_level { get; set; }
        public int Planet_id { get; set; }
        public DateTime Last_update { get; set; }
        public int Wwner_id { get; set; }
        /// <summary>
        /// [ temperate, barren, oceanic, ice, gas, lava, storm, plasma ]
        /// </summary>
        public string Planet_type { get; set; }
        public int Num_pins { get; set; }
    }
}