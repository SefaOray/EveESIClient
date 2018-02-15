using System;

namespace EveESIClient.Models.Dogma
{
    public class GetDogmaAttributeInformationResponse
    {
        public Int64 Attbiute_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Int64? Icon_id { get; set; }
        public float? Defauşt_value { get; set; }
        public bool? Published { get; set; }
        public string Display_name { get; set; }
        public Int64? Unit_id { get; set; }
        public bool? Stackable { get; set; }
        public bool? High_is_good { get; set; }
    }
}