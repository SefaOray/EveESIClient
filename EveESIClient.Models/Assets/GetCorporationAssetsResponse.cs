using System;

namespace EveESIClient.Models.Assets
{
    public class GetCorporationAssetsResponse
    {
        public Int64 Type_id { get; set; }
        public int Quantity { get; set; }
        public Int64 Location_id { get; set; }
        public string Location_type { get; set; }
        public Int64 Item_id { get; set; }
        public string Location_flag { get; set; }
        public bool Is_singleton { get; set; }
    }
}