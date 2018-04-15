using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Skills
{
    public class GetCharacterSkills
    {
        public List<Skill> Skills { get; set; }
        public int Total_sp { get; set; }
        public int? Unallocated_sp { get; set; }

        public class Skill
        {
            public int Skill_id { get; set; }
            public int Skillpoints_in_skill { get; set; }
            public int Trained_skill_level { get; set; }
            public int Active_skill_level { get; set; }
        }
    }

}
