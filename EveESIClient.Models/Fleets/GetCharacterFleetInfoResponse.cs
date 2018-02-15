using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Fleets
{
    public class GetCharacterFleetInfoResponse
    {
        public int Fleet_id { get; set; }
        public int Wing_id { get; set; }
        public int Squad_id { get; set; }
        public string Role { get; set; }
    }
}