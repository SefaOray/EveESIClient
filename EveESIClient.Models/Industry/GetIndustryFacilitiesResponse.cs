

namespace EveESIClient.Models.Industry
{
    public class GetIndustryFacilitiesResponse
    {
        public long Facility_id { get; set; }
        public float Tax { get; set; }
        public int Owner_id { get; set; }
        public int Type_id { get; set; }
        public int Solar_system_id { get; set; }
        public int Region_id { get; set; }
    }
}
