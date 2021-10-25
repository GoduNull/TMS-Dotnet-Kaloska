using System;
using System.Threading;
using TeachMeSkills.Kaloska.Homework7.Enums;
using TeachMeSkills.Kaloska.Homework7.Interfaces;
using TeachMeSkills.Kaloska.Homework7.Manager;
using TeachMeSkills.Kaloska.Homework7.Models;
using TeachMeSkills.Kaloska.Homework7.Services;

namespace TeachMeSkills.Kaloska.Homework7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ActivityManager.Start();
            Console.ReadKey();
        }  
    }
}