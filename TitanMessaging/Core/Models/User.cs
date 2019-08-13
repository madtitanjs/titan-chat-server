using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return $"{FirstName} {LastName}"; } }
        public string Image { get; set; }
    }
}
