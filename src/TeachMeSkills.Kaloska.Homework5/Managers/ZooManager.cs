using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Kaloska.Homework5.Interfaces;
using TeachMeSkills.Kaloska.Homework5.Models;

namespace TeachMeSkills.Kaloska.Homework5.Managers
{
    class ZooManager : IZooManager
    {
        List<AnimalBase> animals = new List<AnimalBase>();

        public void StartZoo()
        {
            Console.WriteLine("Welcome to the zoo" +
                "\n1: Get a new animal" +
                "\n2: View all animals");
            int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1:
                    AddAnimals();
                    StartZoo();
                    break;
                case 2:
                    Show();
                    StartZoo();
                    break;
                default:
                    Console.WriteLine("Сhoose option");
                    StartZoo();
                    break;
            }
        }
        public void AddAnimals()
        {
            Console.WriteLine("Whom do you want to add?\n" +
                "1:Parrot 2:Giraffe 3:Tiger 4:Rhinoceros ");
            int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1:
                    {
                        Input(out string name, out int age);
                        animals.Add(new Parrot { Name = name, Age = age });
                    }
                    break;
                case 2:
                    {
                        Input(out string name, out int age);
                        animals.Add(new Giraffe { Name = name, Age = age });
                    }
                    break;
                case 3:
                    {
                        Input(out string name, out int age);
                        animals.Add(new Tiger { Name = name, Age = age });
                    }
                    break;
                case 4:
                    {
                        Input(out string name, out int age);
                        animals.Add(new Rhinoceros { Name = name, Age = age });
                    }
                    break;
            }

        }
        public void Show()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.Say();
            }
        }
        static void Input(out string name, out int age)
        {
            Console.WriteLine("Name?");
            name = Console.ReadLine();
            Console.WriteLine("Age?");
            int.TryParse(Console.ReadLine(), out age);
        }
    }
}
