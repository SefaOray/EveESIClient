using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Sovereignty
{
    public class GetSovereigntyStructuresResponse
    {
        public int Alliance_id { get; set; }
        public int Solar_system_id { get; set; }
        public int Structure_id { get; set; }
        public float? Vulnerability_oppupancy_level { get; set; }
        public DateTime? Vulnerable_start_time { get; set; }
        public DateTime? Vulnerable_end_time { get; set; }
    }
}
