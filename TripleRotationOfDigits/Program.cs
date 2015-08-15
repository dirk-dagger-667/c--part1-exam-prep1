using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleRotationOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputNumber = Console.ReadLine();
            StringBuilder outputNumber = new StringBuilder();
            char[] arrayOfNumber = new char[inputNumber.Length];


            if (inputNumber.Length > 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (inputNumber[inputNumber.Length - 3 + j] != '0')
                    {

                        outputNumber.Append(inputNumber[inputNumber.Length - 3 + j]);

                    }
                }

                outputNumber.Append(inputNumber);

                for (int i = 0; i < outputNumber.Length - 3; i++)
                {

                    Console.Write(outputNumber[i]);

                }
            }
            else if(inputNumber.Length == 2)
            {

                arrayOfNumber = inputNumber.ToCharArray();
                Array.Reverse(arrayOfNumber);
                Console.WriteLine(new string(arrayOfNumber));

            }
            else
            {

                Console.WriteLine(inputNumber);

            }
        }
    }
}
