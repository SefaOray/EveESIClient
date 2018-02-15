using System;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationResponse
    {
        public string Name { get; set; }
        public string Ticker { get; set; }
        public int Member_count { get; set; }
        public Int64 Ceo_id { get; set; }
        public Int64? Alliance_id { get; set; }
        public string Description { get; set; }
        public float Tax_rate { get; set; }
        public DateTime? Date_founded { get; set; }
        public Int64 Creator_id { get; set; }
        public string Url { get; set; }
        public Int64? Faction_id { get; set; }
        public Int64 Home_station_id { get; set; }
        public Int64 Shares { get; set; }
    }
}