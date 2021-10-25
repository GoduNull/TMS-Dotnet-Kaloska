using System.Collections.Generic;
using System.Linq;
using TeachMeSkills.Kaloska.Homework7.Interfaces;
using TeachMeSkills.Kaloska.Homework7.Models;

namespace TeachMeSkills.Kaloska.Homework7.Services
{
    public class StatisticService : IStatisticService
    {
        public Statistic Get(User user, IEnumerable<int> data)
        {
            return new Statistic
            {
                AveragePpg = GetAveragePpg(data),
                AverageSpeed = GetAverageSpeed(user),
                AverageCount = GetAverageCount(user),
            };
        }

        private double GetAverageSpeed(User user)
        {
            return user.Runs.Average(run => run.Speed);
        }

        private double GetAverageCount(User user)
        {
            return user.Exercises.Average(exercise => exercise.Count);
        }

        private double GetAveragePpg(IEnumerable<int> data)
        {
            return data.Average();
        }
    }
}