using System;
using System.Threading;
using TeachMeSkills.Kaloska.Homework7.Enums;
using TeachMeSkills.Kaloska.Homework7.Interfaces;
using TeachMeSkills.Kaloska.Homework7.Models;
using TeachMeSkills.Kaloska.Homework7.Services;

namespace TeachMeSkills.Kaloska.Homework7.Manager
{
    public class ActivityManager
    {
       static public void Start()
        {
            try
            {
                Console.WriteLine("Welcome to Tracker app!");
                IStatisticService statisticService = new StatisticService();
                IFunctionalityService functionalityService = new FunctionalityService();
                UserManager userManager = new UserManager();
                userManager.Create();
                var user = userManager.Get();
                userManager.Show();
                functionalityService.MyHandler += MyHandlerManager.Show;
                //var user = new User("Name", 70.1, 160, 20, Gender.Male);
                // user input by while
                var run = new Run
                {
                    Name = "Minsk Marathon",
                    Speed = 10.2
                };
                var time1 = 4000; // 4000 ms = 4 sec
                run.Start = functionalityService.Execute($"Start {run.Name}: ");
                //run.Start = functionalityService.Execute(null);
                Thread.Sleep(time1);
                run.End = functionalityService.Execute($"End {run.Name}: ");
                run.Data = (decimal)(time1 * run.Speed);

                user.Runs.Add(run);

                functionalityService.ShowRuns(user);

                var exercise = new Exercise
                {
                    Name = "Jump",
                    Count = 200,
                };

                var time2 = 5000;
                exercise.Start = functionalityService.Execute($"Start {exercise.Name}: ");
                Thread.Sleep(time2);
                exercise.End = functionalityService.Execute($"End {exercise.Name}: ");
                exercise.Data = ((double)exercise.Count / time2) * 1000;

                user.Exercises.Add(exercise);

                Console.WriteLine("\n=======\n");

                functionalityService.ShowAll(user);

                Console.WriteLine("\n=======\n");

                var TrackerData = functionalityService.TrackerPpg();
                foreach (var val in TrackerData)
                {
                    Console.WriteLine(val);
                }

                Console.WriteLine("\n=======\n");

                var statistic = statisticService.Get(user, TrackerData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}