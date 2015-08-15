using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTowerOfDoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tower = new int[8,8];
            string command = "";
            int row = 0;
            int col = 0;
            int futureRow = 0;
            int futureCol = 0;
            bool selected = false;
            int startingKnights = 0;
            int endingKnights = 0;
            double sum = 0;
            
            FillInGrid(tower, startingKnights);

            while (command != "end")
            {
                command = Console.ReadLine();

                if (command == "select" && tower[row, col] == 1)
                {
                    selected = true;
                    row = int.Parse(Console.ReadLine());
                    row = 7 - row;
                    col = int.Parse(Console.ReadLine());
                }
                else if (command == "move" && selected == true)
                {
                    selected = false;
                    futureRow = int.Parse(Console.ReadLine());
                    futureRow = 7 - row;
                    futureCol = int.Parse(Console.ReadLine());

                    Move(tower, row, col, futureRow, futureCol);
                }
                else if (command == "kill" && selected == true)
                {
                    selected = false;
                    futureRow = int.Parse(Console.ReadLine());
                    futureRow = 7 - row;
                    futureCol = int.Parse(Console.ReadLine());

                    Kill(tower, row, col, futureRow, futureCol);
                }
            }

            CountKnightsAndSum(tower, endingKnights, sum);
        }

        public static void CountKnightsAndSum(int[,] grid, int counter, double sum) 
        {
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 7; j >= 0; j--)
                {
                    if (grid[i, j] != 0)
                    {
                        counter++;
                        sum += Math.Pow(2, j);
                    }
                }
            }
        }

        public static void FillInGrid(int[,] grid, int counter)
        {
            for (int i = 7; i >= 0; i--)
            {
                int inputNumbers = int.Parse(Console.ReadLine());
                int mask = 1;

                for (int j = 7; j >= 0; j--)
                {
                    grid[i, j] = inputNumbers & mask;
                    inputNumbers = inputNumbers >> 1;

                    if ((inputNumbers & mask) == 1)
                    {
                        counter++;
                    }
                }
            }
        }

        public static void Move(int[,] grid, int row, int col, int futureRow, int futureCol) 
        {
            if ((futureRow < 0 || futureRow > 7) && row > 2 && row <= 7)
            {
                grid[row, col] = 0;
            }
            else if ((futureRow < 0 || futureRow > 7) && row < 2 && row >= 0)
            {
                grid[row, col] = 2;
            }
            else if ((grid[futureRow, futureCol] == 1) || (grid[futureRow, futureCol + 1] == 1 && futureCol + 1 <= 7) 
                || (grid[futureRow, futureCol - 1] == 1 && futureCol - 1 >= 0))
            {
                grid[row, col] = 0;
            }
            else
            {
                grid[futureRow, futureCol] = 1;
                grid[row, col] = 0;
            }
        }

        public static void Kill(int[,] grid, int row, int col, int futureRow, int futureCol)
        {
            if ((futureRow < 0 || futureRow > 7) && row > 2 && row <=7)
            {
                grid[row, col] = 0;
            }
            else if ((futureRow < 0 || futureRow > 7) && row < 2 && row >= 0)
            {
                grid[row, col] = 2;
            }
            else if (grid[futureRow, futureCol] == 1)
            {
                grid[futureRow, futureCol] = 1;
                grid[row, col] = 0;
            }
            else
            {
                if (grid[futureRow, futureCol] == 0)
                {
                    if (grid[futureRow, futureCol + 1] == 1 && futureCol + 1 <= 7 && grid[futureRow, futureCol - 1] == 1 && futureCol - 1 >= 0)
                    {
                        grid[row, col] = 0;
                    }
                    else if(grid[futureRow, futureCol - 1] == 1 && futureCol - 1 >= 0)
                    {
                        grid[futureRow, futureCol - 1] = 0;
                        grid[row, col] = 0;
                    }
                    else if (grid[futureRow, futureCol + 1] == 1 && futureCol + 1 <= 7)
                    {
                        grid[futureRow, futureCol + 1] = 0;
                        grid[row, col] = 0;
                    }
                }
            }
        }
    }
}
