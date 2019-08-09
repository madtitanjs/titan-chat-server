using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TitanMessaging.Core.Entities
{
    public class Message : BaseEntity
    {
        public Guid MessageID { get; set; }
        public string Content { get; set; }
        public virtual User User { get; set; }
        public virtual Channel Channel { get; set; }
    }
}
