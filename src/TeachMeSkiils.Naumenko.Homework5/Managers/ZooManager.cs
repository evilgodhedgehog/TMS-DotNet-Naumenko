using System;
using System.Collections.Generic;
using TeachMeSkiils.Naumenko.Homework5.Interfaces;
using TeachMeSkiils.Naumenko.Homework5.Models;

namespace TeachMeSkiils.Naumenko.Homework5.Managers
{
    public class ZooManager : IZooManager
    {
        List<AnimalBase> listAnimals { get; set; } = new List<AnimalBase>();

        public void AddAnimals()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Select type of animal to added:\n Bear\n Wolf\n Parrot\n Hawk\n");
            string userInputTypeAnimal;
            bool isStop = false;

            do
            {
                Console.WriteLine("Input type of animal: ");
                userInputTypeAnimal = Console.ReadLine();

                switch (userInputTypeAnimal.ToUpper())
                {
                    case "BEAR":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Bear
                            {
                                nameAnimal = name,
                                ageAnimal = age,
                            });
                            isStop = true;
                        }
                        break;
                    case "WOLF":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Wolf
                            {
                                nameAnimal = name,
                                ageAnimal = age,
                            });
                            isStop = true;
                        }
                        break;
                    case "PARROT":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Parrot
                            {
                                nameAnimal = name,
                                ageAnimal = age,
                            });
                            isStop = true;
                        }
                        break;
                    case "HAWK":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Hawk
                            {
                                nameAnimal = name,
                                ageAnimal = age,
                            });
                            isStop = true;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Incorrect value. Try again ...");
                        }
                        break;
                }
            } while (!isStop);
        }

        public void AddingAnAnimal(out string name, out string age)
        {
            Console.WriteLine("Input name for animal");
            name = Console.ReadLine();
            Console.WriteLine("Input age for animal");
            age = Console.ReadLine();
        }

        public void ShowAnimals()
        {
            foreach (var animal in listAnimals)
            {
                Console.WriteLine($"ID animal: {animal.GetID()}");
                Console.WriteLine($"Type animal: {animal.GetTypeAnimal()}");
                Console.WriteLine($"Name type animal: {animal.GetNameOfTypeAnimal()}");
                Console.WriteLine($"Name animal: {animal.nameAnimal}");
                Console.WriteLine($"Age animal: {animal.ageAnimal}");
            }
        }
    }
}

