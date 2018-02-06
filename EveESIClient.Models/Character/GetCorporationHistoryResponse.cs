using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetCorporationHistoryResponse
    {
        public DateTime start_date { get; set; }
        public Int64 Corporation_id { get; set; }
        public bool Is_deleted { get; set; }
        public int Record_id { get; set; }
    }
}
