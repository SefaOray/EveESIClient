using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationStructuresResponse
    {
        public Int64 Structure_id { get; set; }
        public int Type_id { get; set; }
        public int Corporation_id { get; set; }
        public int System_id { get; set; }
        public int Profile_id { get; set; }
        public CorporationStructureVul Current_vul { get; set; }
        public CorporationStructureVul Next_vul { get; set; }
        public DateTime? Fuel_expires { get; set; }
        public List<CorporationStructureService> Services { get; set; }
        public DateTime? State_timer_start { get; set; }
        public DateTime? State_timer_end { get; set; }
        public DateTime? Unanchors_at { get; set; }

        public class CorporationStructureVul
        {
            public int Day { get; set; }
            public int Hour { get; set; }
        }

        public class CorporationStructureService
        {
            public string Name { get; set; }
            public string State { get; set; }
        }
    }
}