using System.Collections.Generic;

namespace EveESIClient.Models.Character
{
    public class GetCharacterRolesResponse
    {
        public List<string> Roles { get; set; }
        public List<string> Roles_at_hq { get; set; }
        public List<string> Roles_at_base { get; set; }
        public List<string> Roles_at_other { get; set; }
    }
}