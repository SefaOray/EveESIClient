using System;
using System.Collections.Generic;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationMemberTitlesResponse
    {
        public Int64 Character_id { get; set; }
        public List<int> Titles { get; set; }
    }
}