using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetCharacterNotificationsResponse
    {
        public Int64 Notification_id { get; set; }
        public string Type { get; set; }
        public Int64 Sender_id { get; set; }
        public string Sender_type { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Is_read { get; set; }
        public string Text { get; set; }
    }
}
