namespace Investment_Forecaster
{
    internal class Program
    {
        private static double compound = 1;
        static void Main(string[] args)
        {
            decimal pValue;
            double rate, timeInYears;

            Console.Write("Enter the initial principal amount: ");
            pValue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the annual interest rate (as a percentage): ");
            rate = Convert.ToDouble(Console.ReadLine())/100;

            Console.Write("Enter the number of years: ");
            timeInYears = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Future value of your investment: ${CalculateFutureValue(pValue, rate, timeInYears).ToString("N2")}");
        }
        public static decimal CalculateFutureValue(decimal pValue, double rate, double timeInYears) //FV = P * (1 + (r / n))^(n * t)
        {
            return pValue * Convert.ToDecimal(Math.Pow(1 + (rate / compound), compound * timeInYears));
        }
    }
}