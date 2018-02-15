using System;

namespace EveESIClient.Models.Fleets
{
    public class GetFleetMembersResponse
    {
        public int Character_id { get; set; }
        public int Ship_type_id { get; set; }
        public long Wing_id { get; set; }
        public long Squad_id { get; set; }
        public string Role { get; set; }
        public string Role_name { get; set; }
        public DateTime Join_time { get; set; }
        public bool Takes_fleet_warp { get; set; }
        public int Solar_system_id { get; set; }
        public int? station_id { get; set; }
    }
}
