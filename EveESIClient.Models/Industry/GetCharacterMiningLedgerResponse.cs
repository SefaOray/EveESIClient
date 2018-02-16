using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Industry
{
    public class GetCharacterMiningLedgerResponse
    {
        public DateTime Date { get; set; }
        public int Solar_system_id { get; set; }
        public int Type_id { get; set; }
        public Int64 Quantity { get; set; }
    }
}
