using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetcharacterAffiliationsResponse
    {
        /// <summary>
        /// The character’s ID
        /// </summary>
        public Int64 Character_id { get; set; }

        /// <summary>
        /// The character’s corporation ID
        /// </summary>
        public Int64 Corporation_id { get; set; }

        /// <summary>
        /// The character’s alliance ID, if their corporation is in an alliance
        /// </summary>
        public Int64? Alliance_id { get; set; }

        /// <summary>
        /// The character’s faction ID, if their corporation is in a faction
        /// </summary>
        public Int64? Faction_id { get; set; }
    }
}
