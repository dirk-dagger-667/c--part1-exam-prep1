using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _369
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int R = 0;

            if (B == 3)
            {

                R = A + C;
                Console.WriteLine(R);

            }
            else if (B == 6)
            {

                R = A * C;
                Console.WriteLine(R);

            }
            else if (B == 9)
            {

                R = A % C;
                Console.WriteLine(R);

            }

            if (R % 3 == 0)
            {

                Console.WriteLine((R / 3));

            }
            else
            {

                Console.WriteLine((R % 3));

            }

        }
    }
}
