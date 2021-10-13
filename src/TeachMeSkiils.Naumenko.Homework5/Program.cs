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
            IZooManager zooManager = new ZooManager();
            zooManager.StartValueAnimal();
            Console.WriteLine("Welcome to the zoo");
            Console.WriteLine("Look at our animals");
            zooManager.ShowAnimals();

            if (zooManager.IsAddAnimals())
            {
                zooManager.AddAnimals();
            }
            Console.ReadKey();
        }        
    }
}

