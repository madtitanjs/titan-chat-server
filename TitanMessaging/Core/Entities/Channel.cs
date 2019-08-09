using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TitanMessaging.Core.Entities
{
    public class Channel : BaseEntity
    {
        public Channel()
        {
            UserChannels = new HashSet<UserChannel>();
            Messages = new HashSet<Message>();
        }

        public Guid ChannelID { get; set; }

        [Required]
        public string ChannelName { get; set; }

        public virtual ICollection<UserChannel> UserChannels { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
