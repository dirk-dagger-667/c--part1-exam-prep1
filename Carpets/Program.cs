using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber/2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new String('.', inputNumber / 2 - 1 - i) + "/" + Multiply(" /", i/2) + 
                        Multiply("\\ ", i/2) + "\\" +
                    new String('.', inputNumber / 2 - 1 - i));
                    
                }
                else
                {
                    Console.WriteLine(new String('.', inputNumber / 2 - 1 - i) + Multiply("/ ", (i + 1) / 2) + Multiply(" \\", (i + 1) / 2) +
                    new String('.', inputNumber / 2 - 1 - i));
                }
            }

            for (int i = inputNumber/2; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new String('.', inputNumber/2 - i) + Multiply("\\ ", i/2) +
                        Multiply(" /", i/2) +
                    new String('.', inputNumber/2 - i));

                }
                else
                {
                    Console.WriteLine(new String('.', inputNumber / 2 - i) + Multiply("\\ ", i/2) + "\\" + "/" +
                        Multiply(" /", i/2) +
                    new String('.', inputNumber / 2 - i));
                }
            }

        }

        public static string Multiply(string source, int multiplier)
        {
            StringBuilder sb = new StringBuilder(multiplier * source.Length);
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(source);
            }

            return sb.ToString();
        }
    }
}
