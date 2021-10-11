using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Parrot : Birds
    {
        private string nameOfType = "Parrot";

        public override string GetNameOfTypeAnimal()
        {
            return nameOfType;
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Parrot");
        }
    }
}

