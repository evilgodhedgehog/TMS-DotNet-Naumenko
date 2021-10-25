using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class Predator : Animal
    {
        private string type = "Predator";

        public string Type
        {
            get
            {
                return type;
            }
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Predator");
        }
    }
}

