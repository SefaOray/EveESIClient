using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetChatChannelsResponse
    {
        public Int64 Channel_id { get; set; }
        public string Name { get; set; }
        public Int64 Owner_id { get; set; }
        public string Comparison_key { get; set; }
        public bool Has_password { get; set; }
        public string Motd { get; set; }
        public List<ChatChannelsAllowed> allowed { get; set; }
        public List<ChatChannelsOperators> operators { get; set; }
        public List<ChatChannelsBlocked> blocked { get; set; }
        public List<ChatChannelsMuted> muted { get; set; }
        
        public class ChatChannelsAllowed
        {
            public Int64 Accessor_id { get; set; }
            public string Accessor_type { get; set; }
        }

        public class ChatChannelsOperators
        {
            public Int64 Accessor_id { get; set; }
            public string Accessor_type { get; set; }
        }

        public class ChatChannelsBlocked
        {
            public Int64 Accessor_id { get; set; }
            public string Accessor_type { get; set; }
            public string Reason { get; set; }
            public DateTime End_at { get; set; }
        }

        public class ChatChannelsMuted
        {
            public Int64 Accessor_id { get; set; }
            public string Accessor_type { get; set; }
            public string Reason { get; set; }
            public DateTime End_at { get; set; }
        }
    }
}
