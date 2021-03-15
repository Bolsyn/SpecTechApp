using System;
using System.Collections.Generic;

namespace SpecTechApp.Models
{
    public class TypeOfTech
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public ICollection<Feature> Feauteres { get; set; }
    }
}