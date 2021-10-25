using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Parrot : Herbivore
    {
        private string typeHerbivore = "Parrot";

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
            Console.WriteLine("I'm Parrot");
        }

        public override void GoTo()
        {
            Console.WriteLine("To fly");
        }
    }
}

