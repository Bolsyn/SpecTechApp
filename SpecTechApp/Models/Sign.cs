using System;

namespace SpecTechApp.Models
{
    public class Sign
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}