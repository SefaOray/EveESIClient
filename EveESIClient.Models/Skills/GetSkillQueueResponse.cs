using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Skills
{
    public class GetSkillQueueResponse
    {
        public int Skill_id { get; set; }
        public DateTime? Finish_date { get; set; }
        public DateTime? Start_date { get; set; }
        public int Finished_level { get; set; }
        public int Queue_position { get; set; }
        public int? Training_start_sp { get; set; }
        public int? Level_end_sp { get; set; }
        /// <summary>
        /// Amount of SP that was in the skill when it started training it’s current level. Used to calculate % of current level complete
        /// </summary>
        public int Level_start_sp { get; set; }
    }
}
