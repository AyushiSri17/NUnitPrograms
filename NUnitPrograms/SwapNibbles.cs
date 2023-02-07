using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrograms
{
    public class SwapNibbles
    {
        public static void Binary()
        {
            //Binary.ToBinary();
            String binary = "";
            Console.WriteLine("Enter a decimal number to convert in binary");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int remainder = num % 2;
                binary = remainder + binary;
                num = num / 2;
            }
            Console.WriteLine(binary);
            int bin=Convert.ToInt32(binary);            
            int result=SwapNibbles.SwapNib(bin);
            Console.WriteLine(result);
        }
        public static int SwapNib(int x)
        {
            return ((x & 0x0F) << 4 |(x & 0xF0) >> 4);
        }
    }
}
