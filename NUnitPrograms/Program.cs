using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit program");
            Console.WriteLine("Choose the option for the program want to perform");
            Console.WriteLine("1: Vending Machine");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    VendingMachine machine=new VendingMachine();
                    Console.WriteLine("Enter the amount you want to withdraw");
                    int amount=Convert.ToInt32(Console.ReadLine());
                    machine.CountCurrency(amount);
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
