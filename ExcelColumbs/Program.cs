using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace ExcelColumbs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());
            string[] indexes = new string[numberOfLines];
            BigInteger sum = new BigInteger();
            int coef = 0;

            for (int i = 0; i < indexes.Length; i++)
            {

                indexes[i] = Console.ReadLine();

            }

            for (int i = 0; i < indexes.Length; i++)
            {

                switch (indexes[indexes.Length - 1 - i])
                {

                    case "A":

                        coef = 1;

                        break;
                    case "B":

                        coef = 2;

                        break;
                    case "C":

                        coef = 3;

                        break;
                    case "D":

                        coef = 4;

                        break;
                    case "E":

                        coef = 5;

                        break;
                    case "F":

                        coef = 6;

                        break;
                    case "G":

                        coef = 7;

                        break;
                    case "H":

                        coef = 8;

                        break;
                    case "I":

                        coef = 9;

                        break;
                    case "J":

                        coef = 10;

                        break;
                    case "K":

                        coef = 11;

                        break;
                    case "L":

                        coef = 12;

                        break;
                    case "M":

                        coef = 13;

                        break;
                    case "N":

                        coef = 14;

                        break;
                    case "O":

                        coef = 15;

                        break;
                    case "P":

                        coef = 16;

                        break;
                    case "Q":

                        coef = 17;

                        break;
                    case "R":

                        coef = 18;

                        break;
                    case "S":

                        coef = 19;

                        break;
                    case "T":

                        coef = 20;

                        break;
                    case "U":

                        coef = 21;

                        break;
                    case "V":

                        coef = 22;

                        break;
                    case "W":

                        coef = 23;

                        break;
                    case "X":

                        coef = 24;

                        break;
                    case "Y":

                        coef = 25;

                        break;
                    case "Z":

                        coef = 26;

                        break;
                }

                sum += coef * (BigInteger)Math.Pow(26, i);

            }

            Console.WriteLine(sum);

        }
    }
}
