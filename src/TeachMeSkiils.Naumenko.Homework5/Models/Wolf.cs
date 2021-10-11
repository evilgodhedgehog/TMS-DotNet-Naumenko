using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Wolf : Predators
    {
        private string nameOfType = "Wolf";

        public override string GetNameOfTypeAnimal()
        {
            return nameOfType;
        }

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

