using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrograms
{
    public class Binary
    {
        public static void ToBinary()
        {
            String binary = "";
            Console.WriteLine("Enter a decimal number to convert in binary");
            int num=Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                int remainder=num%2;
                binary = remainder + binary;
                num = num / 2;
            }
            Console.WriteLine(binary);
        }
    }
}
