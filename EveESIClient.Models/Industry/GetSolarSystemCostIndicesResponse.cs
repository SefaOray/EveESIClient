using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Industry
{
    public class GetSolarSystemCostIndicesResponse
    {
        public int Solar_system_id { get; set; }
        public List<SolarSystemCostIndices> Cost_indices { get; set; }

        public class SolarSystemCostIndices
        {
            public string Activity { get; set; }
            public float Cost_index { get; set; }
        }

    }
}
