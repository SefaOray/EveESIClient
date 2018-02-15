using System;

namespace EveESIClient.Models.Character
{
    public class GetCharacterResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Int64 Corporation_id { get; set; }
        public Int64? Alliance_id { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public int Race_id { get; set; }
        public int Bloodline_id { get; set; }
        public int? Ancestry_id { get; set; }
        public float? Security_status { get; set; }
        public int? Faction_id { get; set; }
    }
}