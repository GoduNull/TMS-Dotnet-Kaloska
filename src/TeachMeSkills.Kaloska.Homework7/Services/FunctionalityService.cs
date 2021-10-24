using System;
using System.Linq;
using TeachMeSkills.Kaloska.Homework7.Interfaces;
using TeachMeSkills.Kaloska.Homework7.Models;

namespace TeachMeSkills.Kaloska.Homework7.Services
{
    internal class FunctionalityService : IFunctionalityService
    {
        public event Action<string, DateTime> MyHandler;

        public DateTime Execute(string message)
        {
            if (message != null)
            {
                var currentTime = DateTime.Now;
                MyHandler?.Invoke(message, currentTime);
                return currentTime;
            }
            else
            {
                throw new NullReferenceException($"message пуст");
            }
        }

        public void ShowExercises(User user)
        {
            foreach (var run in user.Exercises)
            {
                Console.WriteLine($"{run.Name}, {run.End - run.Start}");
            }
        }

        public void ShowAll(User user)
        {
            var activities = user.Runs
               .Select(x => new
               {
                   x.Name,
                   Data = $"{x.Data} - {x.Speed}",
                   Date = x.Start,
               })
               .Concat(user.Exercises
                   .Select(x => new
                   {
                       x.Name,
                       Data = $"{x.Data} - {x.Count}",
                       Date = x.Start,
                   }))
               .OrderBy(x => x.Date);

            foreach (var activity in activities)
            {
                Console.WriteLine($"{activity.Name}, {activity.Date}: {activity.Data}");
            }
        }

        public void ShowRuns(User user)
        {
            foreach (var run in user.Runs)
            {
                Console.WriteLine($"{run.Name}, {run.End - run.Start}");
            }
        }
    }
}