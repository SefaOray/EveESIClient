using System;

namespace EveESIClient.Models.Character
{
    public class GetFatigueResponse
    {
        /// <summary>
        /// Character’s last jump activation
        /// </summary>
        public DateTime Last_jump_date { get; set; }

        /// <summary>
        /// Character’s jump fatigue expiry
        /// </summary>
        public DateTime Jump_fatigue_expire_date { get; set; }

        /// <summary>
        /// Character’s last jump update
        /// </summary>
        public DateTime Last_update_date { get; set; }
    }
}
