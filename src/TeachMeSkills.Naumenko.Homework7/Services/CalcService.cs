using System;
using TeachMeSkills.Naumenko.Homework7.Models;

namespace TeachMeSkills.Naumenko.Homework7.Services
{
    public class CalcService
    {
        public double GetSeconds(DateTime start, DateTime end)
        {
            var sub = end - start;
            return sub.TotalSeconds;
        }

        public double GetCalories(
            double time,
            User user,
            double commonCoef)
        {
            const double userCoef = 0.006;
            var userData = (user.Height - user.Weight) / user.Age * userCoef;
            return userData * time * commonCoef;
        }
    }
}

