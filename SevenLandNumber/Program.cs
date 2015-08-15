using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenLandNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputK = Console.ReadLine();
            double decimalNumber = 0;
            double lastValue = 0;
            StringBuilder nextNumber = new StringBuilder();

            for (int i = 0; i < inputK.Length; i++)
            {

                decimalNumber += double.Parse(inputK[inputK.Length - i - 1].ToString()) * Math.Pow(7,i);

            }

            decimalNumber += 1;
            int quotient;
            quotient = (int)decimalNumber;

            Console.WriteLine(decimalNumber);

            while (quotient != 0)
            {
                lastValue = quotient % 7;
                quotient = quotient / 7;
                nextNumber.Append(lastValue);
            }

            Console.WriteLine(nextNumber.ToString());

        }
    }
}
