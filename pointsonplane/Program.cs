using System;
using System.Globalization;

namespace pointsonplane
{
    internal class Program
    {
        static void cat()
        {
            Console.WriteLine("         ^        ^ ");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("        / l______/ l)");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("       (  --    --   )");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("     - ( ()       ()  ) --");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("     - ) ==  VV   ==  ( --    ) _");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("        )             ) (   (    )");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("       (  (          ) ( (    )   (");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("      ((    )  (      )   )_____)   )");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("   (__)(_()_)__(_()_) (__)___________)");
            System.Threading.Thread.Sleep(50);
        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("область значений каждой координаты варьируется от -5 до +5");
            while (true)
            {
                Console.Write("введите x:");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("введите y:");
                int y = Int32.Parse(Console.ReadLine());

                string[][] grid = new string[11][];
                for (int i = 0; i < grid.Length; i++)
                {
                    grid[i] = new string[11];
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (j == 5)
                        {
                            grid[i][j] = "| ";
                        }
                        else if (i == 5)
                        {
                            grid[i][j] = "_ ";
                        }
                        else
                        {
                            grid[i][j] = ". ";
                        }

                    }
                }
                if (x <= 0 && y >= 0)
                {
                    int i = 5 - y;
                    int j = 5 + x;
                    grid[i][j] = "x ";
                }
                else if (x >= 0 && y >= 0)
                {
                    int i = 5 - y;
                    int j = 5 + x;
                    grid[i][j] = "x ";
                }
                else if (x <= 0 && y <= 0)
                {
                    int i = 5 - y;
                    int j = 5 + x;
                    grid[i][j] = "x ";
                }
                else if (x >= 0 && y <= 0)
                {
                    int i = 5 - y;
                    int j = 5 + x;
                    grid[i][j] = "x ";
                }
                else if (x == 0 && y == 0)
                {
                    grid[5][5] = "x ";
                }
                for (int i = 0; i < grid.Length; i++) // рисует
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        Console.Write($"{grid[i][j]}");
                    }
                    Console.Write("\n");
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();
                cat();
            }
        }
    }
}
