﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetCharacterStandingsResponse
    {
        public Int64 From_id { get; set; }
        public string From_type { get; set; }
        public float Standing { get; set; }
    }
}
