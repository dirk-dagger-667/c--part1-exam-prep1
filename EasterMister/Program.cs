using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterMister
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine(new String('.', numberN + 1) + new String('*', numberN - 1) + new String('.', numberN + 1));

            if (numberN > 2)
            {
                for (int i = numberN - 2; i >= 0 ; i-=2)
                {
                    Console.WriteLine("." + new String('.', i) + "*"
                        + new String('.', 3*numberN - 3 - 2*i) 
                        + "*" + new String('.', i) + ".");
                }    
            }

            Console.WriteLine(".*" + "." + Multiply("#.", (3*numberN - 4)/2) + "*.");
            Console.WriteLine(".*" + "#" + Multiply(".#", (3 * numberN - 4) / 2) + "*.");

            if (numberN > 2)
            {
                for (int i = 0; i < numberN; i += 2)
                {
                    Console.WriteLine("." + new String('.', i) + "*"
                        + new String('.', 3 * numberN - 3 - 2 * i)
                        + "*" + new String('.', i) + ".");
                }
            }

            Console.WriteLine(new String('.', numberN + 1) + new String('*', numberN - 1) + new String('.', numberN + 1));
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
