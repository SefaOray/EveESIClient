using System;

namespace EveESIClient.Models.Calendar
{
    public class GetEventResponse
    {
        public Int64 Event_id { get; set; }
        public Int64 Owner_id { get; set; }
        public string Owner_name { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Importance { get; set; }
        public string Response { get; set; }
        public string Text { get; set; }
        public string Owner_type { get; set; }
    }
}