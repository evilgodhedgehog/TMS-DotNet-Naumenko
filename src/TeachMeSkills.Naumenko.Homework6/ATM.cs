using System;
using System.Collections.Generic;

namespace TeachMeSkills.Naumenko.Homework6
{
    internal enum Currency
    {
        BYN,
        USD,
        EUR,
        RUB
    }

    public class ATM
    {
        private decimal _balance;

        private event Func<decimal, Currency, bool> Transaction;

        private Action<decimal, Currency> ViewingTransactionInformation;

        private static Dictionary<Currency, decimal> ExchangeRates = new Dictionary<Currency, decimal>()
        {
            { Currency.BYN, 1.0M },
            { Currency.USD, 2.42M },
            { Currency.EUR, 2.81M },
            { Currency.RUB,  0.034M }
        };

        private bool PutMoney(decimal value, Currency currency)
        {
            _balance += value * ExchangeRates[currency];

            return true;
        }

        private bool WhithdrawMoney(decimal value, Currency currency)
        {
            if (value * ExchangeRates[currency] > _balance)
            {
                return false;
            }

            _balance -= value * ExchangeRates[currency];

            return true;
        }

        private void ViewBalance() => Console.WriteLine($"Balance: {Math.Round(_balance, 2)} BYN");

        private Currency GetCurrency()
        {
            while (true)
            {
                Console.WriteLine("Input currency (BYN, USD, EUR, RUB):");
                string input = Console.ReadLine();

                if (Enum.TryParse(input.ToUpperInvariant(), out Currency currency) && Enum.IsDefined(currency))
                {
                    return currency;
                }
                else
                {
                    Console.WriteLine("Incorrect currency value!");
                }
            }
        }

        private decimal GetAmountMoney()
        {
            while (true)
            {
                Console.WriteLine("Input sum value:");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal sumValue) && sumValue > 0)
                {
                    return sumValue;
                }
                else
                {
                    Console.WriteLine("Incorrect sum value!");
                }
            }
        }

        private void InfoSuccessfulTransaction(decimal sumValue, Currency currency)
        {
            if (Transaction == PutMoney)
            {
                Console.WriteLine($"Status: Success. {sumValue} {currency} has been successfully added to the balance");
            }
            if (Transaction == WhithdrawMoney)
            {
                Console.WriteLine($"Status: Success. {sumValue} {currency} has been successfully withdraw from the balance");
            }
        }

        private void InfoFailedTransaction(decimal sumValue, Currency currency) => Console.WriteLine($"Status: Failed");

        private void RunTransaction()
        {
            Currency currency = GetCurrency();
            decimal sumValue = GetAmountMoney();

            if (Transaction?.Invoke(sumValue, currency) == true)
            {
                ViewingTransactionInformation = InfoSuccessfulTransaction;
            }
            else
            {
                ViewingTransactionInformation = InfoFailedTransaction;
            }

            ViewingTransactionInformation?.Invoke(sumValue, currency);
        }

        public static void Modes()
        {
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Operating modes:");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Put - put money");
            Console.WriteLine("Withdraw - withdraw money");
            Console.WriteLine("View - view balance");
            Console.WriteLine("Exit - exit the program");
            Console.WriteLine(new string('=', 20));
        }

        public void Run()
        {
            Modes();

            while (true)
            {
                Console.WriteLine("Input operating modes:");
                string input = Console.ReadLine();
                switch (input.ToUpperInvariant())
                {
                    case "PUT":
                        {
                            Transaction = PutMoney;
                            RunTransaction();
                        }
                        break;
                    case "WITHDRAW":
                        {
                            Transaction = WhithdrawMoney;
                            RunTransaction();
                        }
                        break;
                    case "VIEW":
                        {
                            ViewBalance();
                        }
                        break;
                    case "EXIT":
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Incorrect operating mode!");
                        break;
                }
            }
        }
    }
}

