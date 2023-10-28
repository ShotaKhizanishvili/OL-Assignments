using System.Diagnostics;

namespace Multiplication_Table_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generate(8,8);
        }

        public static void Generate(int n1, int n2)
        {
            PrintColumnTitles(n2);

            for (int i = 1; i <= n1; i++)
            {
                Console.Write($"{i} ");
                Console.ForegroundColor = ConsoleColor.Red;
                for (int j = 1; j <= n2; j++)
                {
                    Console.Write($"{i * j} ");
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine();
            }
        }

        private static void PrintColumnTitles(int n2)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"  ");
            for (int i = 1; i <= n2; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}