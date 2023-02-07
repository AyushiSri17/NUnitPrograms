using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrograms
{
    public class TemperatureConversion
    {
        public static void Conversion()
        {
            double f, c;
            Console.WriteLine("Choose the conversion operation want to perform");
            Console.WriteLine("1: Celsius to Fahrenheit \n2: Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Celsius scale 0 to 100
                    Console.WriteLine("Enter the Temperature in celsius");
                    c = Convert.ToInt32(Console.ReadLine());
                    f = (c * 9 / 5) + 32;
                    Console.WriteLine("Temperature is {0} °F", f);
                    break;
                case 2:
                    //Fahrenheit scale 32 to 212
                    Console.WriteLine("Enter the Temperature in Fahrenheit");
                    f = Convert.ToInt32(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("Temperature is {0} °C", c);
                    break;
            }
        }
    }
}
