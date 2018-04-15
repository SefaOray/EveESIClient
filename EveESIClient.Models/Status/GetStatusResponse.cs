using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Status
{
    public class GetStatusResponse
    {
        public DateTime Start_time { get; set; }
        public int Players { get; set; }
        public string Server_version { get; set; }
        public bool? vip { get; set; }
    }
}
