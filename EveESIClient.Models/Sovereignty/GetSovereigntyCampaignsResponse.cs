using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Sovereignty
{
    public class GetSovereigntyCampaignsResponse
    {
        public int Campaign_id { get; set; }
        public int Structure_id { get; set; }
        public int Solar_system_id { get; set; }
        public int Constellation_id { get; set; }
        public string Event_type { get; set; }
        public DateTime Start_time { get; set; }
        public int? Defender_id { get; set; }
        public float? Attackers_score { get; set; }
        public List<Participant> Participants { get; set; }

        public class Participant
        {
            public int Alliance_id { get; set; }
            public float Score { get; set; }
        }
    }
}
