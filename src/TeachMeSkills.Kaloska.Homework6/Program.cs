using System;
using TeachMeSkills.Kaloska.Homework6.Models;

namespace TeachMeSkills.Kaloska.Homework6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Atm<Account> atm = new Atm<Account>("Атм№1");
            atm.AtmHandler += Display;
            atm.Put(100, 1);
            atm.Withdraw(90, 1);
            atm.Put(100, 1);
            atm.Put(100, 1);
            atm.Withdraw(90, 1);
            atm.PutOnThePhone(50, 1, "+375445624321");
            atm.Withdraw(300, 1);
            atm.Put(100, 5);
            atm.Withdraw(90, 5);
            atm.Put(100, 5);
            atm.Put(100, 5);
            atm.Withdraw(90, 5);
            atm.PutOnThePhone(65, 5, "+375445624321");
            atm.Withdraw(300, 5);
            Console.ReadKey();
        }

        private static void Display(string str)
        {
            Console.WriteLine(new string('=', 20));
            Console.WriteLine(str);
        }
    }
}