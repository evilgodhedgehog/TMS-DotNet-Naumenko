using System;
using TeachMeSkills.Naumenko.Homework7.Models;

namespace TeachMeSkills.Naumenko.Homework7
{
    public interface IActivityManager
    {
        public Activity Create();

        public void Show(Activity activity);

        public void Show(ActivityResult activityResult);

        public void CreateAndSaveResult(Activity activity, double calories);

        public void ShowAllResults();
    }
}

