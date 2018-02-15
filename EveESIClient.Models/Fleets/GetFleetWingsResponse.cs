using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Fleets
{
    public class GetFleetWingsResponse
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public List<FleetWingSquad> Squads { get; set; }


        public class FleetWingSquad
        {
            public string Name { get; set; }
            public long Id { get; set; }
        }

    }
}
