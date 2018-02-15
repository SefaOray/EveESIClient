using System;

namespace EveESIClient.Models.Contacts
{
    public class GetAllianceContactsResponse
    {
        /// <summary>
        /// Standing of the contact
        /// </summary>
        public float Standing { get; set; }

        public string Contact_type { get; set; }
        public Int64 Contact_id { get; set; }

        /// <summary>
        /// Custom label of the contact
        /// </summary>
        public Int64? Label_id { get; set; }
    }
}