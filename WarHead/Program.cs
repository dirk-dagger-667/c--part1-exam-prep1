using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHead
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] circuitBoard = new int[16,16];
            int allLeftCounter = 0;
            int allRightCounter = 0;
            int row = 0;
            int col = 0;

            FillInGrid(circuitBoard, allLeftCounter, allRightCounter);

            while (true)
            {
                string command = Console.ReadLine();
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
                string redOrBlue = "";

                if (command == "hover")
                {
                    if (circuitBoard[row, col] == 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
                else if (command == "operate")
                {
                    if ((row > 0 && row < 16) && (col > 0 && col < 8) && circuitBoard[row, col] == 0 
                        && (circuitBoard[row - 1, col + 1] == 1 && circuitBoard[row - 1, col] == 1
                        && circuitBoard[row - 1, col - 1] == 1 && circuitBoard[row, col + 1] == 1 && circuitBoard[row, col - 1] == 1 
                        && circuitBoard[row + 1, col + 1] == 1
                        && circuitBoard[row + 1, col] == 1 && circuitBoard[row + 1, col - 1] == 1))
                    {
                        allLeftCounter--;
                    }
                    else if ((row > 0 && row < 16) && (col > 7 && col < 16) && circuitBoard[row, col] == 0
                        && (circuitBoard[row - 1, col + 1] == 1 && circuitBoard[row - 1, col] == 1
                        && circuitBoard[row - 1, col - 1] == 1 && circuitBoard[row, col + 1] == 1 && circuitBoard[row, col - 1] == 1
                        && circuitBoard[row + 1, col + 1] == 1
                        && circuitBoard[row + 1, col] == 1 && circuitBoard[row + 1, col - 1] == 1))
                    {
                        allRightCounter--;
                    }
                    else if (circuitBoard[row, col] == 1)
                    {
                        Console.WriteLine("missed");
                        Console.WriteLine("{0} {1}", allLeftCounter, allRightCounter);
                        Console.WriteLine("BOOM");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "cut")
                {
                    redOrBlue = Console.ReadLine();

                    if (redOrBlue == "red")
                    {
                        if (allLeftCounter == 0)
                        {
                            Console.WriteLine(allRightCounter + "/r/n disarmed");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(allLeftCounter + "/r/n BOOM");
                            break;
                        }
                    }
                    else if (redOrBlue == "blue")
                    {
                        if (allRightCounter == 0)
                        {
                            Console.WriteLine(allLeftCounter + "/r/n disarmed");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(allRightCounter + "/r/n BOOM");
                            break;
                        }
                    }
                }
            }
        }

        public static void FillInGrid(int[,] grid, int leftCounter, int rightCounter)
        {
            for (int i = 0; i < 16; i++)
            {
                int inputNumbers = int.Parse(Console.ReadLine());
                int mask = 1;

                for (int j = 15; j >= 0; j--)
                {
                    grid[i, j] = inputNumbers & mask;
                    inputNumbers = inputNumbers >> 1;

                    if ((i > 0 && i < 15) && (j > 0 && j < 8) && grid[i, j] == 0 && (grid[i - 1, j + 1] == 1 && grid[i - 1, j] == 1 
                        && grid[i - 1, j - 1] == 1 && grid[i, j + 1] == 1 && grid[i, j - 1] == 1 && grid[i + 1, j + 1] == 1 
                        && grid[i + 1, j] == 1 && grid[i + 1, j - 1] == 1))
                    {
                        leftCounter++;
                    }
                    else if ((i > 0 && i < 15) && (j > 7 && j < 16) && grid[i, j] == 0 && (grid[i - 1, j + 1] == 1 && grid[i - 1, j] == 1 
                        && grid[i - 1, j - 1] == 1 && grid[i, j + 1] == 1 && grid[i, j - 1] == 1 && grid[i + 1, j + 1] == 1 
                        && grid[i + 1, j] == 1 && grid[i + 1, j - 1] == 1))
                    {
                        rightCounter++;
                    }
                }
            }
        }
    }
}
