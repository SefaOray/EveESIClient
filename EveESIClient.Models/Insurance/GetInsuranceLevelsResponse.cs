using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Insurance
{
    public class GetInsuranceLevelsResponse
    {
        public int Type_id { get; set; }
        public List<InsuranceLevel> Levels { get; set; }
        
        public class InsuranceLevel
        {
            public float Cost { get; set; }
            public float Payout { get; set; }
            public string Name { get; set; }
        }
    }
}