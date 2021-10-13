using System;
using System.Collections.Generic;
using TeachMeSkiils.Naumenko.Homework5.Interfaces;
using TeachMeSkiils.Naumenko.Homework5.Models;

namespace TeachMeSkiils.Naumenko.Homework5.Managers
{
    public class ZooManager : IZooManager
    {
        List<AnimalBase> listAnimals { get; set; } = new List<AnimalBase>();

        public void StartValueAnimal()
        {
            listAnimals.Add(new Bear
            {
                nameAnimal = "Bob",
                ageAnimal = "2",
            });

            listAnimals.Add(new Wolf
            {
                nameAnimal = "Jeck",
                ageAnimal = "3",
            });

            listAnimals.Add(new Parrot
            {
                nameAnimal = "Jon",
                ageAnimal = "3",
            });

            listAnimals.Add(new Hawk
            {
                nameAnimal = "Ben",
                ageAnimal = "4",
            });
        }

        public bool IsAddAnimals()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Do you want to add an animals? (Press Y/y (Yes) or N/n (No)): ");

            var key = Console.ReadKey().Key;
            var isAddAnimals = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    isAddAnimals = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    isAddAnimals = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return isAddAnimals;
        }

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

                isStop = IsAddAnimals();

            } while (!isStop);
        }

        public void AddingAnAnimal(out string name, out string age)
        {
            Console.WriteLine("Input name for animal");
            name = Console.ReadLine();
            Console.WriteLine("Input age for animal");
            age = Console.ReadLine();
        }

        public bool IsShowAnimals()
        {
            Console.WriteLine("\n");
            Console.Write("Show tasks? (Press Y/y (Yes) or N/n (No)): ");

            var key = Console.ReadKey().Key;
            var isShowAnimals = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    isShowAnimals = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    isShowAnimals = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return isShowAnimals;
        }

        public void ShowAnimals()
        {
            if (IsShowAnimals())
            {
                foreach (var animal in listAnimals)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"ID animal: {animal.GetID()}");
                    Console.WriteLine($"Type animal: {animal.GetTypeAnimal()}");
                    Console.WriteLine($"Name type animal: {animal.GetNameOfTypeAnimal()}");
                    Console.WriteLine($"Name animal: {animal.nameAnimal}");
                    Console.WriteLine($"Age animal: {animal.ageAnimal}");
                }
            }
            
        }
    }
}

