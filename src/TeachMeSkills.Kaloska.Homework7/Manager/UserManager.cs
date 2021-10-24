using System;
using TeachMeSkills.Kaloska.Homework7.Enums;
using TeachMeSkills.Kaloska.Homework7.Models;

namespace TeachMeSkills.Kaloska.Homework7.Manager
{
    internal class UserManager
    {
        private User _user;

        /// <summary>
        /// Создать пользователя.
        /// </summary>
        public void Create()
        {
            _user = new User();

            Console.WriteLine("Enter your user data:");
            Console.WriteLine(new string('=', 20));

            Console.Write("Enter name: ");
            _user.FullName = Console.ReadLine();
            while (true)
            {
                Console.Write("Enter age: ");
                var correctUserInput = int.TryParse(Console.ReadLine(), out int age);
                if (correctUserInput)
                {
                    _user.Age = age;
                    break;
                }

                Console.WriteLine("Incorrect input data..");
            }

            while (true)
            {
                Console.Write("Enter weight: ");
                var correctUserInput = double.TryParse(Console.ReadLine(), out double weight);
                if (correctUserInput)
                {
                    _user.Weight = weight;
                    break;
                }

                Console.WriteLine("Incorrect input data..");
            }

            while (true)
            {
                Console.Write("Enter height: ");
                var correctUserInput = int.TryParse(Console.ReadLine(), out int height);
                if (correctUserInput)
                {
                    _user.Height = height;
                    break;
                }

                Console.WriteLine("Incorrect input data..");
            }

            Console.WriteLine(new string('=', 20));

            while (true)
            {
                Console.Write("Enter Gender: ");
                Console.Write("0: Unknown 1: Female 2: Male\n");
                var correctUserInput = int.TryParse(Console.ReadLine(), out int gender);
                if (correctUserInput)
                {
                    switch (gender)
                    {
                        case 0:
                            {
                                _user.Gender = Gender.Unknown;
                                break;
                            }

                        case 1:
                            {
                                _user.Gender = Gender.Female;
                                break;
                            }
                        case 2:
                            {
                                _user.Gender = Gender.Male;
                                break;
                            }
                    }
                    break;
                }

                Console.WriteLine("Incorrect input data..");
            }

            Console.WriteLine(new string('=', 20));
            Console.WriteLine(new string('=', 20));
        }

        /// <summary>
        /// Показать информацию о пользователе.
        /// </summary>
        public void Show()
        {
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("User data:");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine($"Name: {_user.FullName}");
            Console.WriteLine($"Age: {_user.Age}");
            Console.WriteLine($"Weight: {_user.Weight}");
            Console.WriteLine($"Height: {_user.Height}");
            Console.WriteLine($"Gender: {_user.Gender}");
            Console.WriteLine(new string('=', 20));
        }

        /// <summary>
        /// Получить пользовательские данные.
        /// </summary>
        /// <returns>Данные пользователя.</returns>
        public User Get() => _user;
    }
}