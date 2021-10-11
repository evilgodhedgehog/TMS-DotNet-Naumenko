using System;
using System.Collections.Generic;
using TeachMeSkiils.Naumenko.Homework5.Interfaces;
using TeachMeSkiils.Naumenko.Homework5.Managers;
using TeachMeSkiils.Naumenko.Homework5.Models;


namespace TeachMeSkiils.Naumenko.Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var bear = new Bear
            {
                nameAnimal = "Bird",
                ageAnimal = "2",
            };

            IZooManager zooManager = new ZooManager();
            zooManager.AddAnimals();
            

            
            

            zooManager.ShowAnimals();


            // Show();
        }

        //public static void Show()
        //{
        //        var wolf = new Wolf
        //        {
        //            nameAnimal = Console.ReadLine(),
        //            ageAnimal = Console.ReadLine(),
        //            typeAnimal = Console.ReadLine(),
        //            NameOfType = Console.ReadLine(),
        //        };
        //    Console.WriteLine($"Wolf\n ID - {wolf.GetID()} Name - {wolf.nameAnimal}\n Age - {wolf.ageAnimal}\n Type animal - {wolf.typeAnimal}\n Name of type - {wolf.NameOfType}");
        //    wolf.Say();
        //    wolf.GoTo();
        //}
    }
}

