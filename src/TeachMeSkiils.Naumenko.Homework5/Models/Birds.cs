using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class Birds : AnimalBase
    {
        public override void Say()
        {
            Console.WriteLine("I'm Bird");
        }

        public override void GoTo()
        {
            Console.WriteLine("To fly");
        }
    }
}

