using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Hawk : Birds
    {
        private string nameOfType = "Hawk";

        public override string GetNameOfTypeAnimal()
        {
            return nameOfType;
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Hawk");
        }
    }
}

