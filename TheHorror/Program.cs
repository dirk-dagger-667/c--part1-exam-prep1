using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputNumber = Console.ReadLine();
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {

                if (i % 2 == 0)
                {
                    counter++;
                    sum += int.Parse(inputNumber[i].ToString());

                }

            }

            Console.WriteLine("{0} {1}", counter, sum);

        }
    }
}
