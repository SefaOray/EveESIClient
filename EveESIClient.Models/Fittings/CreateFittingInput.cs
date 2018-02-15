using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Fittings
{
    public class CreateFittingInput
    {
        public string Name { get; set; }
        public string Sescription { get; set; }
        public Int64 Ship_type_id { get; set; }
        public List<FittingItem> Items { get; set; }

        public class FittingItem
        {
            public int Type_id { get; set; }
            public int Flag { get; set; }
            public int Quantity { get; set; }
        }
    }
}