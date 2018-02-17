using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Mail
{
    public class GetMailHeadersResponse
    {
        public int? Mail_id { get; set; }
        public string Subject { get; set; }
        public int? From { get; set; }
        public DateTime? Timestamp { get; set; }
        public List<Int64> Labels { get; set; }
        public List<MailRecipients> Recipients { get; set; }
        public bool? Is_read { get; set; }

        public class MailRecipients
        {
            public string Recipient_type { get; set; }
            public int Recipient_id { get; set; }
        }
    }
}
