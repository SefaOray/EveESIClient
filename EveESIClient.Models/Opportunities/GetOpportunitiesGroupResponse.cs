using System.Collections.Generic;

namespace EveESIClient.Models.Opportunities
{
    public class GetOpportunitiesGroupResponse
    {
        public int Group_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notification { get; set; }
        public List<int> Required_tasks { get; set; }
        public List<int> Connected_groups { get; set; }

    }
}