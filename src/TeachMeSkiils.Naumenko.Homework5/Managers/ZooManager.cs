using System;
using System.Collections.Generic;
using TeachMeSkiils.Naumenko.Homework5.Interfaces;
using TeachMeSkiils.Naumenko.Homework5.Models;

namespace TeachMeSkiils.Naumenko.Homework5.Managers
{
    public class ZooManager : IZooManager
    {
        List<Animal> listAnimals = new List<Animal>();

        public void ActionShowAnimals()
        {
            listAnimals.Add(new Rabbit
            {
                Name = "Bob",
                Age = "2",
            });

            listAnimals.Add(new Wolf
            {
                Name = "Jeck",
                Age = "3",
            });

            listAnimals.Add(new Parrot
            {
                Name = "Jon",
                Age = "3",
            });

            listAnimals.Add(new Hawk
            {
                Name = "Ben",
                Age = "4",
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

        public void AddAnimal()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Select type of animal to added:\n Rabbit\n Wolf\n Parrot\n Hawk");
            string userInputTypeAnimal;
            bool isAdd = true;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Input type of animal: ");
                userInputTypeAnimal = Console.ReadLine();

                switch (userInputTypeAnimal.ToUpper())
                {
                    case "RABBIT":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Rabbit
                            {
                                Name = name,
                                Age = age,
                            });
                        }
                        break;
                    case "WOLF":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Wolf
                            {
                                Name = name,
                                Age = age,
                            });
                        }
                        break;
                    case "PARROT":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Parrot
                            {
                                Name = name,
                                Age = age,
                            });
                        }
                        break;
                    case "HAWK":
                        {
                            AddingAnAnimal(out string name, out string age);

                            listAnimals.Add(new Hawk
                            {
                                Name = name,
                                Age = age,
                            });
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Incorrect value. Try again ...");
                        }
                        break;
                }

                isAdd = IsAddAnimals();

            } while (isAdd);
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
            Console.Write("Show animals? (Press Y/y (Yes) or N/n (No)): ");

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
                    Console.WriteLine($"ID animal: {animal.ID}");
                    Console.WriteLine($"Name animal: {animal.Name}");
                    Console.WriteLine($"Age animal: {animal.Age}");
                    animal.Say();
                    animal.GoTo();
                }
            }
        }

        public bool IsEditAnimals()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Do you want to edit animals? (Press Y/y (Yes) or N/n (No)): ");

            var key = Console.ReadKey().Key;
            var isEditAnimals = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    isEditAnimals = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    isEditAnimals = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return isEditAnimals;
        }

        public void EditAnimal()
        {
            while (IsEditAnimals())
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Select ID to edit:\n");

                foreach (var animal in listAnimals)
                {
                    Console.WriteLine($"{animal.ID}");
                }

                Console.WriteLine("Input ID to edit the animal");
                var inputUserId = Console.ReadLine();

                foreach (var animal in listAnimals)
                {
                    if (animal.ID == inputUserId.ToUpperInvariant())
                    {
                        Console.WriteLine("\n");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        Console.Write("Input age: ");
                        var age = Console.ReadLine();

                        animal.Name = name;
                        animal.Age = age;
                    }
                }
            }
        }
    }
}

