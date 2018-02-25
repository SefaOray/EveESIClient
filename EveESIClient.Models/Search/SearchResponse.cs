using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Search
{
    public class SearchResponse
    {
        public List<int> Agent { get; set; }
        public List<int> Alliance { get; set; }
        public List<int> Character { get; set; }
        public List<int> Constellation { get; set; }
        public List<int> Corporation { get; set; }
        public List<int> Faction { get; set; }
        public List<int> Inventory_type { get; set; }
        public List<int> Region { get; set; }
        public List<int> Solar_system { get; set; }
        public List<int> Station { get; set; }
        public List<long> Structure { get; set; }
    }
}