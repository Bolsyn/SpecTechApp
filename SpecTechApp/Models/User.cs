using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
