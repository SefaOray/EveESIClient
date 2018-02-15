using System;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationAllianceHistoryResponse
    {
        public DateTime Start_date { get; set; }
        public Int64 Alliance_id { get; set; }
        public bool? Is_deleted { get; set; }

        /// <summary>
        /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>
        public Int64 Record_id { get; set; }
    }
}