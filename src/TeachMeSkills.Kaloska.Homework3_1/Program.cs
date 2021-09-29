using System;
using System.Text.RegularExpressions;

namespace TeachMeSkills.Kaloska.Homework3_1
{

    class WeekDayHandler
    {


        public static void DayOfWeek(string day)
        {
            string reg = @"\d{2}-[0-1]{1}[0-9]{1}-\d{4}"; 
            if (Regex.IsMatch(day, reg, RegexOptions.IgnoreCase))
            {
                DateTime.TryParse(day, out DateTime date);
                Console.WriteLine("День недели:");
                Console.WriteLine(date.DayOfWeek); ;
            }
            else
            {
                Console.WriteLine("Некорректная дата");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату ");
            string dateInput = Console.ReadLine();
            WeekDayHandler.DayOfWeek(dateInput);
            Console.ReadKey();
        }
    }
}
