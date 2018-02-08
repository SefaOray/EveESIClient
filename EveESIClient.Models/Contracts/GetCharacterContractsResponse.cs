using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Contracts
{
    public class GetCharacterContractsResponse
    {
        public Int64 Contract_id { get; set; }
        public Int64 Issuer_id { get; set; }
        public Int64 Issuer_corporation_id { get; set; }
        public Int64 Assignee_id { get; set; }
        public Int64 Acceptor_id { get; set; }
        public Int64? Start_location_id { get; set; }
        public Int64? End_location_id { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// [ outstanding, in_progress, finished_issuer, finished_contractor, finished, cancelled, rejected, failed, deleted, reversed ]
        /// </summary>
        public string Status { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// true if the contract was issued on behalf of the issuer’s corporation
        /// </summary>
        public bool For_corporation { get; set; }

        /// <summary>
        /// [ public, personal, corporation, alliance ]
        /// </summary>
        public string Availability { get; set; }
        public DateTime Date_issued { get; set; }
        public DateTime Date_expired { get; set; }
        public DateTime? Date_accepted { get; set; }
        public int? Days_to_complate { get; set; }
        public DateTime? Date_completed { get; set; }
        public double? Price { get; set; }
        public double? Reward { get; set; }
        public double? Collateral { get; set; }
        public double? Buyout { get; set; }
        public double? Volume { get; set; }

    }
}
