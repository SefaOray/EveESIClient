using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Assets
{
    public class GetCorporationAssetsLocationsResponse
    {
        public Int64 Item_id { get; set; }

        public AssetPosition Position { get; set; }

        public class AssetPosition
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }
    }
}
