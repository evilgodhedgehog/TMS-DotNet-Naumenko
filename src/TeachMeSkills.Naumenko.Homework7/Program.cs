using System;
using TeachMeSkills.Naumenko.Homework7.Extensions;
using TeachMeSkills.Naumenko.Homework7.Managers;
using TeachMeSkills.Naumenko.Homework7.Services;

namespace TeachMeSkills.Naumenko.Homework7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var userManager = new UserManager();
            IActivityManager activityManager = new ActivityManager();
            var calService = new CalcService();

            Console.WriteLine("Tracker app!");
            Console.WriteLine();

            userManager.Create();
            Console.WriteLine();
            userManager.Show();

            var key = default(ConsoleKey);
            while (key != ConsoleKey.E)
            {
                var activity = activityManager.Create();

                var calories = calService.GetCalories(
                    calService.GetSeconds(activity.Start, activity.End),
                    userManager.Get(),
                    activity.Type.ConvertToCoef());

                activityManager.CreateAndSaveResult(activity, calories);

                Console.Write("Press E to exit");
                key = Console.ReadKey().Key;
                Console.WriteLine();
            }

            activityManager.ShowAllResults();
        }
    }
}

