using System;

namespace TeachMeSkiils.Naumenko.Homework5.Models
{
    public abstract class AnimalBase
    {
        private string ID = Guid.NewGuid().ToString().ToUpper().Substring(0, 3);

        private string animalType;

        private string nameOfType;

        public virtual string GetTypeAnimal()
        {
            return animalType;
        }

        public virtual string GetNameOfTypeAnimal()
        {
            return nameOfType;
        }

        public string nameAnimal { get; set; }

        public string ageAnimal { get; set; }

        public string GetID()
        {
            return ID;
        }

        public virtual void Say()
        {
            Console.WriteLine("Sound of the animal");
        }

        public virtual void GoTo()
        {
            Console.WriteLine("Movement of the animal");
        }
    }
}

