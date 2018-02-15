using System;

namespace EveESIClient.Models.FactionWarfare
{
    public class GetFactionWarfareSystemOwnershipsResponse
    {
        public Int64 Solar_system_id { get; set; }
        public Int64 Owner_faction_id { get; set; }
        public Int64 Occupier_faction_id { get; set; }
        public int Victory_points { get; set; }
        public int Victory_points_threshold { get; set; }
        public bool Contested { get; set; }
    }
}