using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Mail
{
    public class SendMailInput
    {
        public List<SendMailRecepient> Recepients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Int64 Approved_cost { get; set; }

        public class SendMailRecepient
        {
            public string Recipient_type { get; set; }
            public int Recipient_id { get; set; }
        }
    }
}
