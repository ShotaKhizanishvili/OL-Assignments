namespace Array_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numbers separated by commas: ");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(',');
            double[] numbers = new double[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                string trimmedNumString = numberStrings[i].Trim();
                double.TryParse(trimmedNumString, out double value);
                numbers[i] = value;
            }

            Console.WriteLine($"Sum: {CalculateSum(numbers)}");
            Console.WriteLine($"Average: {CalculateAverage(numbers)}");
            Console.WriteLine($"Maximum: {FindMax(numbers)}");
            Console.WriteLine($"Minimum: {FindMin(numbers)}");
        }
        public static double CalculateSum(double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static double CalculateAverage(double[] numbers)
        {
            return CalculateSum(numbers) / numbers.Length;
        }
        public static double FindMax(double[] numbers)
        {
            double maxValue = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            return maxValue;
        }
        public static double FindMin(double[] numbers)
        {
            double minValue = numbers[0];
            for (int i = 0;i<numbers.Length;i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }
            return minValue;
        }
    }
}