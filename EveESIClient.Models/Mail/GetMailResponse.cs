using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Mail
{
    public class GetMailResponse
    {
        public string Subject { get; set; }
        public int? From { get; set; }
        public DateTime? Timestamp { get; set; }
        public List<GetMailReiepient> Recipients { get; set; }
        public string Body { get; set; }
        public List<Int64> Labels { get; set; }
        public bool? Read { get; set; }
        public class GetMailReiepient
        {
            public string Recipient_type { get; set; }
            public int Recipient_id { get; set; }
        }
    }
}
