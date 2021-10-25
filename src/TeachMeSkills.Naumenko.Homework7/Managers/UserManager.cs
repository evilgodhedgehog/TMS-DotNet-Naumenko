using System;
using TeachMeSkills.Naumenko.Homework7.Models;

namespace TeachMeSkills.Naumenko.Homework7.Managers
{
    public class UserManager
    {
        private User _user;

        public void Create()
        {
            _user = new User();

            Console.WriteLine("Input your user data:");
            Console.WriteLine(new string('=', 25));

            Console.Write("Input name: ");
            _user.Name = Console.ReadLine();

            while (true)
            {
                Console.Write("Input age: ");
                var correctUserInput = int.TryParse(Console.ReadLine(), out int age);
                if (correctUserInput)
                {
                    _user.Age = age;
                    break;
                }

                Console.WriteLine("Incorrect input age..");
            }

            while (true)
            {
                Console.Write("Input weight: ");
                var correctUserInput = double.TryParse(Console.ReadLine(), out double weight);
                if (correctUserInput)
                {
                    _user.Weight = weight;
                    break;
                }

                Console.WriteLine("Incorrect input weight..");
            }

            while (true)
            {
                Console.Write("Input height: ");
                var correctUserInput = double.TryParse(Console.ReadLine(), out double height);
                if (correctUserInput)
                {
                    _user.Height = height;
                    break;
                }

                Console.WriteLine("Incorrect input height..");
            }

            Console.WriteLine(new string('=', 25));
        }

        public void Show()
        {
            Console.WriteLine(new string('=', 15));
            Console.WriteLine("User data:");
            Console.WriteLine(new string('=', 15));
            Console.WriteLine($"Name: {_user.Name}");
            Console.WriteLine($"Age: {_user.Age}");
            Console.WriteLine($"Weight: {_user.Weight}");
            Console.WriteLine($"Height: {_user.Height}");
            Console.WriteLine(new string('=', 15));
        }

        public User Get() => _user;
    }
}

