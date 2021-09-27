using System;
using System.Text.RegularExpressions;

namespace TeachMeSkills.Kaloska.Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            string reg = @"\d{2}-[0-1]{1}[0-9]{1}-\d{4}";
            Console.WriteLine("Введите дату ");
            string dateInput = Console.ReadLine();
            if (Regex.IsMatch(dateInput, reg, RegexOptions.IgnoreCase))
            {
                DateTime.TryParse(dateInput, out DateTime date);
                Console.WriteLine("День недели:");
                Console.WriteLine(date.DayOfWeek); ;
            }
            else
            {
                Console.WriteLine("Некорректная дата");
            }
        }
    }
}
