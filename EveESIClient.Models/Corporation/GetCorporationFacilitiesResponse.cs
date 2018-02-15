using System;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationFacilitiesResponse
    {
        public Int64 Facility_id { get; set; }
        public Int64 Type_id { get; set; }
        public Int64 System_id { get; set; }
    }
}