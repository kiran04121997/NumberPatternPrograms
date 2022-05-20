using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPatternCode
{
    class NumberPattern
    {
        public static void Main()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);     // for similar numbers to each row add "i" instead of j;
                }
                Console.WriteLine();
            }

            /*int count = 0;       // for traingular numbers
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write(count);    
                }
                Console.WriteLine();
            }*/
            Console.ReadLine();
        }
    }
}
