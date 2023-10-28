namespace Number_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            long number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(ToBinary(number));
        }

        public static string ToBinary(long number)
        {
            return Convert.ToString(number, 2);
        }
    }
}