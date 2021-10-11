using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class Predators : AnimalBase
    {
        public override void Say()
        {
            Console.WriteLine("I'm Predator");
        }
    }
}

