using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Clones
{
    public class GetClonesResponse
    {
        public DateTime? Last_clone_jump_date { get; set; }
        public ClonesHomeLocation Home_location { get; set; }
        public List<ClonesJumpClones> Jump_clones { get; set; }

        public class ClonesHomeLocation
        {
            public Int64? Location_id { get; set; }
            public string LocationType { get; set; }
        }

        public class ClonesJumpClones
        {
            public Int64 Jump_clone_id { get; set; }
            public string Name { get; set; }
            public Int64 Location_id { get; set; }
            public string Location_type { get; set; }
            public List<Int64> Implants { get; set; }
        }
    }
}