using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Calendar
{
    public class GetCharacterCalendarResponse
    {
        public Int64 Event_id { get; set; }
        public DateTime Event_date { get; set; }
        public string Title { get; set; }
        public int Importance { get; set; }
        public string Event_response { get; set; }
    }
}
