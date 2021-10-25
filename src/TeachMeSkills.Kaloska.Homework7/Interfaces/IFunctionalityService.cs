using System;
using System.Collections.Generic;
using TeachMeSkills.Kaloska.Homework7.Models;

namespace TeachMeSkills.Kaloska.Homework7.Interfaces
{
    internal interface IFunctionalityService
    {
        event Action<string, DateTime> MyHandler;

        DateTime Execute(string message);

        void ShowAll(User user);

        void ShowRuns(User user);

        void ShowExercises(User user);

        public List<int> TrackerPpg()
        {
            var list = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(40, 100));
            }
            return list;
        }
    }
}