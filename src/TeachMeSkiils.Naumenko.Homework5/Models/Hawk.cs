using System;
namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public class Hawk : Birds
    {
        public string NameOfType = "Hawk";

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm Hawk");
        }
    }
}

