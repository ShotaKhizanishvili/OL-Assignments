namespace Discount_Calculator
{
    internal class Program
    {
        public static double ticketpriceUSD = 100;
        static void Main(string[] args)
        {
            int age;

            Console.Write("Input your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (!AgeValidation(age))
            {
                throw new ArgumentOutOfRangeException("Age must be more than 0.");
            }

            Console.WriteLine($"Ticket price for you is {CalculatePrice(age)}$");
        }

        public static double CalculatePrice(int age)
        {
            if (age < 18)
            {
                ticketpriceUSD = ticketpriceUSD * 75 / 100;
            }
            if (age >64)
            {
                ticketpriceUSD = ticketpriceUSD * 85 / 100;
            }


            return ticketpriceUSD;
        }
        public static bool AgeValidation(int age)
        {
            if(age <= 0)
            {
                return false;
            }
            return true;
        }
    }
}