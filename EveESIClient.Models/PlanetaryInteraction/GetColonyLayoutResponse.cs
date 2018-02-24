using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.PlanetaryInteraction
{
    public class GetColonyLayoutResponse
    {
        
        public List<Link> Links { get; set; }
        public List<Pin> Pins { get; set; }
        public List<Route> Routes { get; set; }

        public class Link
        {
            public long Source_pin_id { get; set; }
            public long Destination_pin_id { get; set; }
            public int Link_level { get; set; }
        }

        public class Pin
        {
            public float Longitude { get; set; }
            public bool Is_running { get; set; }
            public int Type_id { get; set; }
            public long Pin_id { get; set; }
            public float Latitude { get; set; }
            public int? Schematic_id { get; set; }
            public ExtractorDetail Extractor_details { get; set; }
            public FactoryDetails Factory_details { get; set; }
            public List<Content> Contents { get; set; }
            public DateTime? Install_time { get; set; }
            public DateTime? Expiry_time { get; set; }
            public DateTime? Last_cycle_start { get; set; }

            public class ExtractorDetail
            {
                public List<Head> Heads { get; set; }
                public int? Product_type_id { get; set; }
                public int? Cycle_time { get; set; }
                public float? Head_radius { get; set; }
                public int? Qty_per_cycle { get; set; }

                public class Head
                {
                    public int Head_id { get; set; }
                    public float Latitude { get; set; }
                    public float Longitude { get; set; }
                }
            }
            public class FactoryDetails
            {
                public int Cchematic_id { get; set; }
            }
            public class Content
            {
                public int Type_id { get; set; }
                public long Amount { get; set; }
            }

        }

        public class Route
        {
            public long Source_pin_id { get; set; }
            public float Quantity { get; set; }
            public int Content_type_id { get; set; }
            public long Route_id { get; set; }
            public long Destination_pin_id { get; set; }
            public List<int> Waypoints { get; set; }
        }

    }
}
