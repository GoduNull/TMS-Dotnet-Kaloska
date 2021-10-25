using System;
using TeachMeSkills.Kaloska.Homework5.Managers;
using TeachMeSkills.Kaloska.Homework5.Models;

namespace TeachMeSkills.Kaloska.Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooManager zoo = new ZooManager();
            zoo.StartZoo();
            Console.ReadKey();
        }
    }
}
