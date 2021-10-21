using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Hawk : Predator
    {
        private string typePredator = "Hawk";

        public string TypePredator
        {
            get
            {
                return typePredator;
            }
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Hawk");
        }

        public override void GoTo()
        {
            Console.WriteLine("To fly");
        }
    }
}

