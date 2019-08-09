using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Entities
{
    public class UserChannel
    {
        public Guid ChannelID { get; set; }
        public virtual Channel Channel { get;set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}
