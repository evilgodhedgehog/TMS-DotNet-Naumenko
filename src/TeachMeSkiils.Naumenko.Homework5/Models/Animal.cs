using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class Animal
    {
        private string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 3);

        public string ID
        {
            get
            {
                return Id;
            }
        }

        public string Name { get; set; }

        public string Age { get; set; }

        public virtual void Say()
        {
            Console.WriteLine("I'm an animal");
        }

        public virtual void GoTo()
        {
            Console.WriteLine("I go");
        }
    }
}

