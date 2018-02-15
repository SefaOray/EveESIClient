using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationOutpostDetailResponse
    {
        public Int64 Owner_id { get; set; }
        public Int64 System_id { get; set; }
        public Int64 Docking_cost_per_ship_volume { get; set; }
        public Int64 Office_rental_cost { get; set; }
        public Int64 Type_id { get; set; }
        public float Reprocessing_efficiency { get; set; }
        public float Reprocessing_station_take { get; set; }
        public Int64 Standing_owner_id { get; set; }
        public OutpostDetailCoordinates Coordinates { get; set; }
        public List<OutpostDetailService> Services { get; set; }

        public class OutpostDetailCoordinates
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public class OutpostDetailService
        {
            /// <summary>
            /// [ Bounty Missions, Assassination Missions, Courier Missions,
            /// Interbus, Reprocessing Plant, Refinery, Market, Black Market,
            /// Stock Exchange, Cloning, Surgery, DNA Therapy, Repair Facilities,
            /// Factory, Laboratory, Gambling, Fitting, Paintshop, News, Storage,
            /// Insurance, Docking, Office Rental, Jump Clone Facility, Loyalty Point Store,
            /// Navy Offices, Security Office ]
            /// </summary>
            public string Service_name { get; set; }

            public Int64 Owner_id { get; set; }
            public Double minimum_standing { get; set; }
            public Double surcharge_per_bad_standing { get; set; }
            public Double discount_per_good_standing { get; set; }
        }
    }
}