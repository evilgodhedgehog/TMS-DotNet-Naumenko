using System;
using System.Globalization;

namespace TeachMeSkills.Naumenko.Homework2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате (число, месяц, год), например: 23.09.2021");
            string dateAdd = Console.ReadLine();
            string result;
            DateTime day;

            if (DateTime.TryParse(dateAdd, out day))
            {
                result = day.ToString("dddd", CultureInfo.GetCultureInfo("ru-RU"));
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение. Попробуйте ещё раз.");
            }
        }
    }
}
