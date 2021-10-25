using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Wolf : Predator
    {
        private string typePredator = "Wolf";

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
            Console.WriteLine("I'm wolf. Ayyyyyyyy");
        }

        public override void GoTo()
        {
            Console.WriteLine("To run");
        }
    }
}

