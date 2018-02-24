using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Opportunities
{
    public class GetOpportunitiesTaskResponse
    {
        public int Task_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notification { get; set; }

    }
}