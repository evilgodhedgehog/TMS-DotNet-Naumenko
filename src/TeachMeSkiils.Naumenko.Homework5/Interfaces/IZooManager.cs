using System;
using System.Collections.Generic;
using TeachMeSkiils.Naumenko.Homework5.Models;

namespace TeachMeSkiils.Naumenko.Homework5.Interfaces
{
    public interface IZooManager
    {
        bool IsAddAnimals();
        bool IsShowAnimals();
        void StartValueAnimal();
        void ShowAnimals();
        void AddAnimals();
    }
}

