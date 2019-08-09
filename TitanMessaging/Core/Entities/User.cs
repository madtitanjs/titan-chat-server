using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TitanMessaging.Core.Entities
{
    public class User : BaseEntity
    {
        public User() {
            UserChannels = new HashSet<UserChannel>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserID { get; set; }

        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<UserChannel> UserChannels { get; set; }
    }
}
