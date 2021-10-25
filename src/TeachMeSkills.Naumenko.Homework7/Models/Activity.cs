using System;
using TeachMeSkills.Naumenko.Homework7.Enums;

namespace TeachMeSkills.Naumenko.Homework7
{
    public class Activity : System.Object
    {
        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public ActivityType Type { get; set; }

        public override string ToString() =>
            $"Name: {Name};" +
            $"\nStart: {Start};" +
            $"\nEnd: {End};" +
            $"\nType: {Type}";
    }
}

