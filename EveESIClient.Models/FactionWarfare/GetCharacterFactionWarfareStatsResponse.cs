using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.FactionWarfare
{
    public class GetCharacterFactionWarfareStatsResponse
    {
        public Int64? Faction_id { get; set; }
        public DateTime? Enlisted_on { get; set; }
        public int? Current_rank { get; set; }
        public int? Highest_rank { get; set; }
        public FactionWarfareStatsKills Kills { get; set; }
        public FactionWarfareStatsVictoryPoints Victory_points { get; set; }

        public class FactionWarfareStatsKills
        {
            public int Yesterday { get; set; }
            public int Last_week { get; set; }
            public int Total { get; set; }
        }

        public class FactionWarfareStatsVictoryPoints
        {
            public int Yesterday { get; set; }
            public int Last_week { get; set; }
            public int Total { get; set; }
        }
    }
}
