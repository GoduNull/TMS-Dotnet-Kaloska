using System.Collections.Generic;
using TeachMeSkills.Kaloska.Homework7.Enums;

namespace TeachMeSkills.Kaloska.Homework7.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string name, double weight, int height, int age, Gender gender)
        {
            this.FullName = name;
            this.Weight = weight;
            this.Height = height;
            this.Age = age;
            this.Gender = gender;
        }

        public string FullName { get; set; }

        public double Weight { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public List<Run> Runs { get; set; } = new List<Run>();

        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}