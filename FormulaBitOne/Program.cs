using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBitOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] grid = new int[8,8];
            int counterCells = 1;
            int counterTurns = 0;
            int col = 7;
            int row = 0;

            for (int i = 0; i < 8; i++)
            {
                int inputNumbers = int.Parse(Console.ReadLine());
                int mask = 1;

                for (int j = 7; j >= 0; j--)
                {
                    grid[i, j] = inputNumbers & mask;
                    inputNumbers = inputNumbers >> 1;
                }
            }

            while (true)
            {
                if (grid[row + 1,col] == 0 && row < 8)
                {
                    row += 1;
                    counterCells++;
                    
                }
                else if (grid[row,col - 1] == 0 && col >= 0)
                {
                    col -= 1;
                    counterCells++;
                }
                else if (grid[row - 1, col] == 0 && row >= 0)
                {
                    row -= 1;
                    counterCells++;
                }
                else
                {
                    break;
                }
            }

        }
    }
}
