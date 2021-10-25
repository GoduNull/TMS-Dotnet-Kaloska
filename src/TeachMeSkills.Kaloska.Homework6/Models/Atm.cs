using System;
using System.Collections.Generic;
using System.Linq;

namespace TeachMeSkills.Kaloska.Homework6.Models
{
    internal class Atm<T> where T : Account
    {
        public event Action<string> AtmHandler;

        private List<T> accounts = new()
        {
            new Account(0m) as T,
            new Account(0m) as T,
            new Account(0m) as T,
            new Account(0m) as T,
            new Account(0m) as T,
            new Account(0m) as T,
            new Account(0m) as T,
        };

        public string NameAtm { get; private set; }

        public Atm(string name)
        {
            NameAtm = name;
        }

        public void Put(decimal sum, int id)
        {
            foreach (var acc in accounts.Where(n => n.Id == id))
            {
                acc.MyHandler = AtmHandler;
                acc.Put(sum);
            }
        }

        public void PutOnThePhone(decimal sum, int id, string phone)
        {
            foreach (var acc in accounts.Where(n => n.Id == id))
            {
                acc.MyHandler = AtmHandler;
                acc.PutOnThePhone(sum, phone);
            }
        }

        public void Withdraw(decimal sum, int id)
        {
            foreach (var acc in accounts.Where(n => n.Id == id))
            {
                acc.MyHandler = AtmHandler;
                acc.Withdraw(sum);
            }
        }
    }
}