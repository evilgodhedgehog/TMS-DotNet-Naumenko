using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Wolf : Predators
    {
        public string NameOfType = "Wolf";

        public override void Say()
        {
            Console.WriteLine("I'm wolf. Ayyyyyyyy");
            base.Say();
        }

        public override void GoTo()
        {
            Console.WriteLine("To run");
        }
    }
}

