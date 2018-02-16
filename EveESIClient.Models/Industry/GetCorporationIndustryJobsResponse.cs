using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Industry
{
    public class GetCorporationIndustryJobsResponse
    {
        public int Job_id { get; set; }
        public int Installer_id { get; set; }
        public int Facility_id { get; set; }
        public Int64 Station_id { get; set; }
        public int Activity_id { get; set; }
        public Int64 Blueprint_id { get; set; }
        public int Blueprint_type_id { get; set; }
        public Int64 Blueprint_location_id { get; set; }
        public Int64 Output_location_id { get; set; }
        public int Runs { get; set; }
        public double? Cost { get; set; }
        public int? Licensed_runs { get; set; }
        public float? Probality { get; set; }
        public int? Product_type_id { get; set; }
        /// <summary>
        /// [ active, cancelled, delivered, paused, ready, reverted ]
        /// </summary>
        public string Status { get; set; }
        public int Duration { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public DateTime? Pause_date { get; set; }
        public DateTime? Completed_date { get; set; }
        public int? Completed_character_id { get; set; }
        public int? Successful_runs { get; set; }
    }
}
