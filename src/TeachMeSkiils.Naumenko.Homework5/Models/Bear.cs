using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Bear :Predators
    {
        private string nameOfType = "Bear";

        public override string GetNameOfTypeAnimal()
        {
            return nameOfType;
        }

        public override void Say()
        {
            Console.WriteLine("I'm bear. Rrrrr");
            base.Say();
        }

        public override void GoTo()
        {
            Console.WriteLine("I want to sleep");
        }
    }
}

