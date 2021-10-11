using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class Predators : AnimalBase
    {
        private string animalType = "Predator";

        public override string GetTypeAnimal()
        {
            return animalType;
        }

        public override void Say()
        {
            Console.WriteLine("I'm Predator");
        }
    }
}

