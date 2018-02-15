using System;

namespace EveESIClient.Models.FactionWarfare
{
    public class GetFactionWarfareStatsResponse
    {
        public Int64 Faction_id { get; set; }
        public int Pilots { get; set; }
        public int Systems_controlled { get; set; }
        public FwStatsKills Kills { get; set; }
        public FwStatsVictoryPoints Victory_points { get; set; }

        public class FwStatsKills
        {
            public int Yesterday { get; set; }
            public int Last_week { get; set; }
            public int Total { get; set; }
        }

        public class FwStatsVictoryPoints
        {
            public int Yesterday { get; set; }
            public int Last_week { get; set; }
            public int Total { get; set; }
        }
    }
}