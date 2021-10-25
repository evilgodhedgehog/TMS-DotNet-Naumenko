using System;
using TeachMeSkills.Naumenko.Homework7.Enums;
using TeachMeSkills.Naumenko.Homework7.Constants;

namespace TeachMeSkills.Naumenko.Homework7.Extensions
{
    public static class ActivityExtensions
    {
        public static double ConvertToCoef(this ActivityType activityType)
        {
            return activityType switch
            {
                ActivityType.Unknown => 0,
                ActivityType.Run => CommonConstants.Run,
                ActivityType.Swim => CommonConstants.Swim,
                _ => 0,
            };
        }
    }
}

