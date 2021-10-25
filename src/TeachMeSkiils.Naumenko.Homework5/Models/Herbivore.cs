using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class Herbivore : Animal
    {
        private string type = "Herbivore";

        public string Type
        {
            get
            {
                return type;
            }
        }

        public override void Say()
        {
            Console.WriteLine("I'm Herbivore");
        }
    }
}

