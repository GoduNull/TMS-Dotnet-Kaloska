using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Kaloska.Homework5.Interfaces;

namespace TeachMeSkills.Kaloska.Homework5.Models
{
    public abstract class AnimalBase : ISay
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age}";
        }
        public virtual void Say()
        {
            Console.WriteLine("Who am I");
        }
    }
}
