using System;

namespace TeachMeSkills.Kaloska.Homework7.Manager
{
    public static class MyHandlerManager
    {
        public static void Show(string message, DateTime dateTime)
        {
            Console.WriteLine($"{message} {dateTime}");
        }
    }
}