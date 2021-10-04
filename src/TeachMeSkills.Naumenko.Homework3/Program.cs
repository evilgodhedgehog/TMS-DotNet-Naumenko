using System;
using System.Globalization;

namespace TeachMeSkills.Naumenko.Homework3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате (число, месяц, год), например: 23.09.2021");
            string dateAdd = Console.ReadLine();
            checkTheAddedDate(dateAdd, out string result);
            Console.WriteLine($"{result}");
        }

        static void checkTheAddedDate(string dateAdd, out string result)
        {
            if (DateTime.TryParse(dateAdd, out DateTime day))
            {
                result = day.ToString("dddd", CultureInfo.GetCultureInfo("ru-RU"));
            }
            else
            {
                result = "Вы ввели некорректное значение. Попробуйте ещё раз.";
            }
        }
    }
}
