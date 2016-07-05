using System;
using PropertyChanged;

namespace ListAndDetails
{
    [ImplementPropertyChanged]
    public class PersonVm
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public double Salary { get; set; } = new Random().NextDouble() * 100;
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow.AddDays(new Random().Next(90));

        public PersonVm(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
