//Even Number Finder: (Medium)Build a program that finds all even numbers from 1 to n,
//    utilizing the continue statement

namespace Even_Number_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (!IsEven(i))
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
        public static bool IsEven(int k)
        {
            if (k % 2 == 0 && k != 0)
            {
                return true;
            }
            return false;
        }
    }
}