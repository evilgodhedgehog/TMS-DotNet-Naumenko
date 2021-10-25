using System;
namespace TeachMeSkills.Naumenko.Homework7.Models
{
    public class ActivityResult : Activity
    {
        public double Calories { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()};" +
                   $"\nCalories: {Calories}.";
        }
    }
}

