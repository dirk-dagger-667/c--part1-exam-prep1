using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputInt = int.Parse(Console.ReadLine());
            int mask = 1;
            StringBuilder numberString = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                int lastDigit = inputInt & mask;

                if (lastDigit == 1)
                {

                    numberString.Append(@".#.
##.
.#.
###
");

                }
                else
                {

                    numberString.Append(@"###
#.#
#.#
###
");

                }

                if (i != 15)
                {

                    numberString.Append(@".
.
.
.
");

                }

                inputInt = inputInt >> 1;

            }

            Console.Write(numberString);
        }
    }
}
