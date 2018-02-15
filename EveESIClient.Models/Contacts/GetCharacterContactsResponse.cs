using System;

namespace EveESIClient.Models.Contacts
{
    public class GetCharacterContactsResponse
    {
        public float Standing { get; set; }
        public string Contact_type { get; set; }
        public Int64 Contact_id { get; set; }
        public bool? Is_watched { get; set; }
        public bool? Is_blocked { get; set; }
        public Int64? Label_id { get; set; }
    }
}