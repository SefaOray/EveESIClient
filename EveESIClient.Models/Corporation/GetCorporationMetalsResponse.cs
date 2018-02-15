using System;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationMetalsResponse
    {
        public Int64 Medal_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Int64 Creator_id { get; set; }
        public DateTime Created_at { get; set; }
    }
}