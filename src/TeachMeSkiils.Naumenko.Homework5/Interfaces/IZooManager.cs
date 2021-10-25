using System;
using System.Collections.Generic;
using TeachMeSkiils.Naumenko.Homework5.Models;

namespace TeachMeSkiils.Naumenko.Homework5.Interfaces
{
    public interface IZooManager
    {
        void ActionShowAnimals();
        bool IsShowAnimals();
        bool IsAddAnimals();
        bool IsEditAnimals();
        void ShowAnimals();
        void AddAnimal();
        void EditAnimal();
    }
}

