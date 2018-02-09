using System;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationStandingsResponse
    {
        public Int64 From_id { get; set; }
        public string From_type { get; set; }
        public float Standing { get; set; }
    }
}