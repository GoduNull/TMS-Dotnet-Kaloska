using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TeachMeSkills.Kaloska.Homework3_1
{

    class WeekDayHandler
    {
        public static DateTime DayOfWeek(string day)
        {
            DateTime date = new DateTime();
            string reg = @"\d{2}-[0-1]{1}[0-9]{1}-\d{4}";
            if (Regex.IsMatch(day, reg, RegexOptions.IgnoreCase))
            {
                DateTime.TryParse(day, out DateTime dates);
                Console.WriteLine("День недели:");
                Console.WriteLine(dates.DayOfWeek);
                date = dates;
            }
            else
            {
                Console.WriteLine("Некорректная дата");
            }
            return date;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату ");
            string dateInput = Console.ReadLine();
            //WeekDayHandler.AllDayofweek(WeekDayHandler.DayOfWeek(dateInput));
            Console.ReadKey();
        }
    }
}
