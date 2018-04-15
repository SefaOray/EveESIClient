using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Skills
{
    public class GetCharacterAttributesResponse
    {
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Memory { get; set; }
        public int Perception { get; set; }
        public int Willpower { get; set; }
        public int? Bonus_remaps { get; set; }
        public DateTime? Last_remap_date { get; set; }
        public DateTime? Accrued_remap_colldown_date { get; set; }
    }
}
