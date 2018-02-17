using System;

namespace EveESIClient.Models.Location
{
    public class GetCharacterOnlineResponse
    {
        public bool Online { get; set; }
        public DateTime? Last_login { get; set; }
        public DateTime? Last_logout { get; set; }
        public int? Logins { get; set; }
    }
}