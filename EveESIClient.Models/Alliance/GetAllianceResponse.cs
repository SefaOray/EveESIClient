using System;

namespace EveESIClient.Models.Alliance
{
    public class GetAllianceResponse
    {
        public string Name { get; set; }
        public int Creator_id { get; set; }
        public int Creator_corporation_id { get; set; }
        public string Ticker { get; set; }
        public int? Executor_corporation_id { get; set; }
        public DateTime Date_founded { get; set; }
        public int? Faction_id { get; set; }
    }
}