using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Models
{
    public class Tech
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public TypeOfTech TypeofTech { get; set; }
        public string Description { get; set; }
        public string GovNumber { get; set; }
    }
}
