using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrograms
{
    public class VendingMachine
    {
        public void CountCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[8];

            for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            Console.WriteLine("Number of notes withdrawn");
            for (int i = 0; i < 8; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine("{1} note of {0}",notes[i],noteCounter[i]);
                }
            }
        }
    }
}
