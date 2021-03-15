using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Models
{
    public class Quest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Location { get; set; }
        public Tech Tech { get; set; }
        public int Price { get; set; }
        public Status Status { get; set; }
    }
}
