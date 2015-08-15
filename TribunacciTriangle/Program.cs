using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribunacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            StringBuilder line = new StringBuilder();
            string stringLine;

            Console.WriteLine(firstNumber);
            Console.WriteLine("{0} {1}", secondNumber, thirdNumber);

            for (int i = 3; i < numberOfLines + 1; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    currentNumber = firstNumber + secondNumber + thirdNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = currentNumber;

                    line.Append(currentNumber + " ");
                }

                stringLine = line.ToString().TrimEnd(' ');

                Console.WriteLine(stringLine);

                line.Clear();

            }

        }
    }
}
