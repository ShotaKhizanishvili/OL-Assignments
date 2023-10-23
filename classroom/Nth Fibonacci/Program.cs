namespace Nth_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateFibonacci(number));
        }
        public static long CalculateFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            return (CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2));
        }
    }
}