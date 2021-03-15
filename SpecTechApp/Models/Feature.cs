using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Models
{
    public class Feature
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public double Value { get; set; }
        public Guid SignId { get; set; }
        public Sign Sign { get; set; }
    }
}
