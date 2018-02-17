using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Killmails
{
    public class GetCharacterKillmailsResponse
    {
        public int Killmail_id { get; set; }
        public string Killmail_hash { get; set; }
    }
}