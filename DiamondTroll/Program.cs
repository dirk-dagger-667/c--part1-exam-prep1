using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTroll
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine(new String('.', (numberN * 2 + 2 - numberN) / 2) + new String('*', numberN)
                + new String('.', (numberN * 2 + 2 - numberN) / 2));

            for (int i = 0; i < numberN - numberN/2 ; i++)
            {
                Console.WriteLine(new String('.', (numberN * 2 + 2 - numberN) / 2 - i - 1) + "*"
                    + new String('.', (numberN * 2 + 2 - numberN) / 2 + i - 1) + "*"
                    + new String('.', (numberN * 2 + 2 - numberN) / 2 + i - 1) + "*"
                    + new String('.', (numberN * 2 + 1 - numberN) / 2 - i - 1));
            }

            Console.WriteLine(new String('*', 2*numberN + 1));

            for (int i = 0; i < numberN - 2; i++)
            {
                Console.WriteLine(new String('.', numberN - (numberN - i - 1)) + "*" + new String('.', numberN - 2 - i)
                    + "*" + new String('.', numberN - 2 - i) + "*" + new String('.', numberN - (numberN - i - 1)));
            }

            Console.WriteLine(new String('.', numberN - 1) + "***" + new String('.', numberN - 1));
            Console.WriteLine(new String('.', numberN) + "*" + new String('.', numberN));
        }
    }
}
