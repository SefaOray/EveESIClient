using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Dogma
{
    public class GetDogmaEffectInformationResponse
    {
        public Int64 Effect_id { get; set; }
        public string Name { get; set; }
        public string Display_name { get; set; }
        public string Description { get; set; }
        public Int64? Icon_id { get; set; }
        public Int64? Effect_category { get; set; }
        public Int64? Pre_expression { get; set; }
        public Int64? Post_expression { get; set; }
        public bool? Is_offensive { get; set; }
        public bool? Is_assistance { get; set; }
        public bool? Disallow_auto_repeat { get; set; }
        public bool? Published { get; set; }
        public bool? Is_warp_safe { get; set; }
        public bool? Range_chance { get; set; }
        public bool? Electronic_chance { get; set; }
        public Int64? Duration_attribute_id { get; set; }
        public Int64? Tracking_speed_attbiute_id { get; set; }
        public Int64? Discharge_attbiute_id { get; set; }
        public Int64? Range_attribute_id { get; set; }
        public Int64? Falloff_attribute_id { get; set; }
        public List<EffectInformationModifiers> Modifiers { get; set; }

        public class EffectInformationModifiers
        {
            public string Func { get; set; }
            public string Domain { get; set; }
            public Int64? Modified_attribute_id { get; set; }
            public Int64? Modifing_attribute_id { get; set; }
            public Int64? Effect_id { get; set; }
            public Int64? Operator { get; set; }
        }
    }
}
