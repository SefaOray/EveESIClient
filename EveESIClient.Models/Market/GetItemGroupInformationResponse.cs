using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Market
{
    public class GetItemGroupInformationResponse
    {
        public int Market_group_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Types { get; set; }
        public int? Parent_group_id { get; set; }
    }
}