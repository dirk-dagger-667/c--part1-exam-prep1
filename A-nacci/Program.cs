using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {

            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            StringBuilder stringLine = new StringBuilder();

            if (numberOfLines >= 1)
            {
                Console.WriteLine(firstLetter);
            }
            if (numberOfLines >= 2)
            {
                Console.WriteLine("{0}\r\n{1} {2}", firstLetter, secondLetter, (char)(firstLetter + secondLetter - 64));
            }
            if (numberOfLines >= 3)
            {

                firstLetter = secondLetter;
                secondLetter = (char)(firstLetter + secondLetter - 64);

                for (int i = 3; i <= numberOfLines; i++)
                {

                    for (int j = 0; j < 2; j++)
                    {

                        currentNumber = firstLetter + secondLetter - 64 + 1;
                        firstLetter = secondLetter;
                        secondLetter = (char)currentNumber;

                        stringLine.Append((char)currentNumber);
                        stringLine.Append(new String(' ', i - 1));

                    }

                    Console.WriteLine(stringLine);

                    stringLine.Clear();

                }
            }
        }
    }
}
