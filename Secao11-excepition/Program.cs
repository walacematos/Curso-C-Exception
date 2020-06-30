using Secao11_excepition.Entities;
using System;
using System.Globalization;
using Secao11_excepition.Entities.Exceptions;

namespace Secao11_excepition
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Inicial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch (DomainException exception)
            {
                Console.WriteLine("Withdraw error: " + exception.Message);
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Unexception error: " + e.Message);
            }
        }
    }
}
