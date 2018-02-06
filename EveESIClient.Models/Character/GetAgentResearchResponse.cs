using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetAgentResearchResponse
    {
        public Int64 Agent_id { get; set; }
        public Int64 Skill_type_id { get; set; }
        public DateTime Started_at { get; set; }
        public float Points_per_day { get; set; }
        public float Remainder_points { get; set; }
    }
}
