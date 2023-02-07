using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrograms
{
    public class MonthlyPayment
    {        
        public static void CalculateMonthlyPayment()
        {
            double payment, n, r;
            Console.WriteLine("Enter the principal loan amount");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the interest rate");
            double R = Convert.ToDouble(Console.ReadLine());           
            n = 12 * Y;
            r = R / (12 * 100);
            payment = (P * r) / (1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly Payment is:" + payment);
        }
    }
}
