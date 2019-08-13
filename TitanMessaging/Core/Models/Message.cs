using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Models
{
    public class Message
    {
        public Guid MessageID { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public string Sender { get { return User.Name; } }
        public string SenderImage { get { return User.Image; } }
        public Channel Channel { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
