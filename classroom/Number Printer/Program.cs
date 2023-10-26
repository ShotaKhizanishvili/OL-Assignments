//Number Printer: (Easy)Create a program that prints numbers from 1 to n,
//    where n is input by the user

namespace Number_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}