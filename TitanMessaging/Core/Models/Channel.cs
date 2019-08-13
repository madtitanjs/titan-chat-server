using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Models
{
    public class Channel
    {
        public Guid ChannelID { get; set; }
        public string ChannelName { get; set; }
        public DateTime LastActiveDate { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
