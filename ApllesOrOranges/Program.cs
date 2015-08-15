using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApllesOrOranges
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0;
            int sumOdd = 0;
            string inputNumber = Console.ReadLine();

            for (int i = 0; i < inputNumber.Length; i++)
            {

                if ((int.Parse(inputNumber[i].ToString()) % 2) == 0)
                {

                    sumEven += int.Parse(inputNumber[i].ToString());

                }
                else
                {

                    sumOdd += int.Parse(inputNumber[i].ToString());

                }

            }

            if (sumOdd < sumEven)
            {
                Console.WriteLine("{0} {1}", "apples", sumEven);
            }
            else if(sumEven < sumOdd)
            {
                Console.WriteLine("{0} {1}", "oranges", sumOdd);
            }
            else
            {
                Console.WriteLine("{0} {1}", "both", sumOdd);
            }

        }
    }
}
