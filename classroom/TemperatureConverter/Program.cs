namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, farenheit;
            celsius = Convert.ToDouble(Console.ReadLine());
            farenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(celsius + " Celsius is " + CelsiusToF(celsius) + "F");
            Console.WriteLine(farenheit + " Farenheit is " + FarenheitToC(farenheit) + "C");
        }

        //(0°C × 9/5) + 32 = 32°F
        public static double CelsiusToF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        //(0°F − 32) × 5/9 = -17.78°C
        public static double FarenheitToC(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}