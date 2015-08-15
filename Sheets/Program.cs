using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber = int.Parse(Console.ReadLine());
            int[] arrayOfValues = new int[11] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
            string[] arrayOfListSizes = new string[11] { "A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0" };


            for (int i = 0; i < arrayOfValues.Length; i++)
            {

                if (inputNumber - arrayOfValues[arrayOfValues.Length - 1 - i] >= 0)
                {

                    inputNumber = inputNumber - arrayOfValues[arrayOfValues.Length - 1 - i];
                    arrayOfListSizes[arrayOfValues.Length - 1 - i] = "";

                }

            }

            for (int i = 0; i < arrayOfListSizes.Length; i++)
            {
                if (arrayOfListSizes[i] != "")
                {

                    Console.WriteLine(arrayOfListSizes[i]);

                }
            }
        }
    }
}
