using System;
using System.Collections.Generic;
using TeachMeSkills.Naumenko.Homework7.Enums;
using TeachMeSkills.Naumenko.Homework7.Models;

namespace TeachMeSkills.Naumenko.Homework7
{
    public class ActivityManager : IActivityManager
    {
        private List<ActivityResult> _activityResults = new List<ActivityResult>();

        public Activity Create()
        {
            var activity = new Activity();

            Console.WriteLine();
            Console.WriteLine("Input your activity:");
            Console.WriteLine(new string('=', 20));

            Console.Write("Input name: ");
            activity.Name = Console.ReadLine();

            while (true)
            {
                Console.Write("Input start: ");
                var correctUserInput = DateTime.TryParse(Console.ReadLine(), out DateTime start);
                if (correctUserInput)
                {
                    activity.Start = start;
                    break;
                }

                Console.WriteLine("Incorrect input time");
            }

            while (true)
            {
                Console.Write("Input end: ");
                var correctUserInput = DateTime.TryParse(Console.ReadLine(), out DateTime end);
                if (correctUserInput)
                {
                    if (activity.Start < end)
                    {
                        activity.End = end;
                        break;
                    }
                }

                Console.WriteLine("Incorrect input time");
            }

            while (true)
            {
                Console.Write("Input type: ");
                var correctUserInput = Enum.TryParse(Console.ReadLine(), out ActivityType type);
                if (correctUserInput)
                {
                    activity.Type = type;
                    break;
                }

                Console.WriteLine("Incorrect input type");
            }

            Console.WriteLine(new string('=', 20));

            return activity;
        }

        public void Show(Activity activity)
        {
            Console.WriteLine(new string('=', 35));
            Console.WriteLine(activity.ToString());
            Console.WriteLine(new string('=', 35));
        }

        public void Show(ActivityResult activityResult) =>
            Console.WriteLine(activityResult.ToString());

        public void CreateAndSaveResult(Activity activity, double calories)
        {
            _activityResults.Add(new ActivityResult
            {
                Name = activity.Name,
                Start = activity.Start,
                End = activity.End,
                Type = activity.Type,
                Calories = calories,
            });
        }

        public void ShowAllResults()
        {
            Console.WriteLine();
            Console.WriteLine("Your activities list:");
            Console.WriteLine(new string('=', 30));
            foreach (var activityResult in _activityResults)
            {
                Show(activityResult);
            }
            Console.WriteLine(new string('=', 30));
        }
    }
}

