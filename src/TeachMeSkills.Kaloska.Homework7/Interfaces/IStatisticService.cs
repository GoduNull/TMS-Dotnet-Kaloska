using System.Collections.Generic;
using TeachMeSkills.Kaloska.Homework7.Models;

namespace TeachMeSkills.Kaloska.Homework7.Interfaces
{
    public interface IStatisticService
    {
        Statistic Get(User user, IEnumerable<int> data);
    }
}