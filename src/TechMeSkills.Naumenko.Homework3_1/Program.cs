using System;
using System.Globalization;

namespace TechMeSkills.Naumenko.Homework3_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DayOfWeek dayName = checkTheDayValue();
            int month = checkTheMonthValue();
            int year = checkTheYearValue();
            int days = DateTime.DaysInMonth(year, month);

            displaingTheDateOfTheInputDay(dayName, month, year, days);
            Console.ReadKey();
        }

        static int checkTheMonthValue()
        {
            bool monthParse = false;
            int monthNumber = 0;

            do
            {
                Console.WriteLine("Input the month number");
                monthParse = int.TryParse(Console.ReadLine(), out monthNumber);
            }
            while (!monthParse || monthNumber < 1 || monthNumber > 12);

            return monthNumber;
        }

        static int checkTheYearValue()
        {
            bool yearParse = false;
            int yearhNumber = 0;

            do
            {
                Console.WriteLine("Input the year number");
                yearParse = int.TryParse(Console.ReadLine(), out yearhNumber);
            }
            while (!yearParse || yearhNumber < 1);

            return yearhNumber;
        }

        static DayOfWeek checkTheDayValue()
        {
            bool parse = false;
            string inputDayName;
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            do
            {
                Console.WriteLine("Input the day name");
                inputDayName = Console.ReadLine().ToLowerInvariant();
                switch (inputDayName)
                {
                    case "monday":
                        {
                            dayOfWeek = DayOfWeek.Monday;
                            parse = true;
                        }
                        break;
                    case "tuesday":
                        {
                            dayOfWeek = DayOfWeek.Tuesday;
                            parse = true;
                        }
                        break;
                    case "wednesday":
                        {
                            dayOfWeek = DayOfWeek.Wednesday;
                            parse = true;
                        }
                        break;
                    case "thrusday":
                        {
                            dayOfWeek = DayOfWeek.Thursday;
                            parse = true;
                        }
                        break;
                    case "friday":
                        {
                            dayOfWeek = DayOfWeek.Friday;
                            parse = true;
                        }
                        break;
                    case "saturday":
                        {
                            dayOfWeek = DayOfWeek.Saturday;
                            parse = true;
                        }
                        break;
                    case "sunday":
                        {
                            dayOfWeek = DayOfWeek.Sunday;
                            parse = true;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (parse == false);

            return dayOfWeek;
        }

        static void displaingTheDateOfTheInputDay(DayOfWeek dayName, int month, int year, int days)
        {
            DateTime[] dates = new DateTime[days];

            for (int i = 0; i < days; i++)
            {
                dates[i] = new DateTime(year, month, i + 1);

                if (dates[i].DayOfWeek == dayName)
                {
                    Console.WriteLine($"{dates[i].ToShortDateString()}");
                }
            }
        }
    }
}
