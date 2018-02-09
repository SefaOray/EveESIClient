using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationBlueprintsResponse
    {
        public int Item_id { get; set; }
        public int Type_id { get; set; }
        public int Location_id { get; set; }
        public string Location_flag { get; set; }
        public int Quantity { get; set; }
        public int Time_efficiency { get; set; }
        public int Material_efficiency { get; set; }
        public int Runs { get; set; }
    }
}
