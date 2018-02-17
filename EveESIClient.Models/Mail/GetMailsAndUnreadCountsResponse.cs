using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Mail
{
    public class GetMailsAndUnreadCountsResponse
    {
        public int? Total_unread_count { get; set; }
        public List<MailLabel> Labels { get; set; }
        public class MailLabel
        {
            public int? Unread_count { get; set; }
            public int? Label_id { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }
        }
    }
}
