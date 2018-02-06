using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetContactNotificationsResponse
    {
        public int Notification_id { get; set; }
        public DateTime Send_date { get; set; }
        public float Standing_level { get; set; }
        public string Message { get; set; }
        public Int64 Sender_character_id { get; set; }
    }
}
