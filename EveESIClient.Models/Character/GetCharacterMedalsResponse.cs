using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Character
{
    public class GetCharacterMedalsResponse
    {
        public Int64 Medal_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Int64 Corporation_id { get; set; }
        public Int64 Issuer_id { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public List<CharacterMedalGraohic> Graphics { get; set; }

        public class CharacterMedalGraohic
        {
            public int Part { get; set; }
            public int Layer { get; set; }
            public string Graphic { get; set; }
            public int Color { get; set; }
        }
    }
}