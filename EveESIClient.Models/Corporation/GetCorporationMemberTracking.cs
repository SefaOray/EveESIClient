using System;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationMemberTracking
    {
        public Int64 Character_id { get; set; }
        public DateTime? Start_date { get; set; }
        public Int64? Base_id { get; set; }
        public Int64? Logon_date { get; set; }
        public Int64? Logoff_date { get; set; }
        public Int64? Location_id { get; set; }
        public Int64? Ship_type_id { get; set; }
    }
}