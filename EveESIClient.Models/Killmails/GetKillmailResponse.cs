using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Killmails
{
    public class GetKillmailResponse
    {
        public int Killmail_id { get; set; }
        public DateTime Killmail_time { get; set; }
        public KillmailVictim Victim { get; set; }
        public List<KillmailAttacker> Attackers { get; set; }
        public int Solar_system_id { get; set; }
        public int? Moon_id { get; set; }
        public int? War_id { get; set; }

        public class KillmailVictim
        {
            public int? Character_id { get; set; }
            public int? Corporation_id { get; set; }
            public int? Alliance_id { get; set; }
            public int? Faction_id { get; set; }
            public int Damage_taken { get; set; }
            public int Ship_type_id { get; set; }
            public List<KillmailItem> Items { get; set; }
            public KillmailPosition Position { get; set; }
        }

        public class KillmailItem
        {
            public int Item_type_id { get; set; }
            public int? Quantity_destroyed { get; set; }
            public int? Quantity_dropped { get; set; }
            public int Singleton { get; set; }
            public int Flag { get; set; }
            public List<KillmailItem> Items { get; set; }
        }

        public class KillmailPosition
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public class KillmailAttacker
        {
            public int? Character_id { get; set; }
            public int? Corporation_id { get; set; }
            public int? Alliance_id { get; set; }
            public int? Faction_id { get; set; }
            public float Security_status { get; set; }
            public bool Final_blow { get; set; }
            public int Damage_done { get; set; }
            public int? Ship_type_id { get; set; }
            public int? Weapon_type_id { get; set; }
        }
    }
}
