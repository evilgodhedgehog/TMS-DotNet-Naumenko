using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Parrot : Birds
    {
        public string NameOfType = "Parrot";

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Parrot");
        }
    }
}

