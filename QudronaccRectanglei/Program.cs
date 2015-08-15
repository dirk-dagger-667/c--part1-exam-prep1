using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QudronaccRectanglei
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int RNumber = int.Parse(Console.ReadLine());
            int CNumber = int.Parse(Console.ReadLine());
            StringBuilder stringLine = new StringBuilder();
            int currentNumber = 0;

            Console.Write("{0} {1} {2} {3} ", firstNumber, secondNumber, thirdNumber, fourthNumber);

            if (CNumber > 4)
            {

                for (int i = 4; i < CNumber; i++)
                {

                    currentNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = fourthNumber;
                    fourthNumber = currentNumber;

                    stringLine.Append(currentNumber + " ");

                }

                Console.WriteLine(stringLine.ToString().TrimEnd(' '));

                stringLine.Clear();

            }

            if (RNumber > 1)
            {

                for (int i = 1; i < RNumber; i++)
                {

                    for (int j = 0; j < CNumber; j++)
                    {

                        currentNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                        thirdNumber = fourthNumber;
                        fourthNumber = currentNumber;

                        stringLine.Append(currentNumber + " ");

                    }

                    Console.WriteLine(stringLine.ToString().TrimEnd(' '));

                    stringLine.Clear();

                }

            }
        }
    }
}
