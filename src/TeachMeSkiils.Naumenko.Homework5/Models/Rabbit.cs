using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Rabbit : Herbivore
    {
        private string typeHerbivore = "Rabbit";

        public string TypeHerbivore
        {
            get
            {
                return typeHerbivore;
            }
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Rabbit");
        }

        public override void GoTo()
        {
            Console.WriteLine("To jump");
        }
    }
}

