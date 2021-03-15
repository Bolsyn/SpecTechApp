using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Models
{
    public class Feature
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Sign { get; set; }
    }
}
