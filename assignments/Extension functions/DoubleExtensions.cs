namespace Extension_functions
{
    public static class DoubleExtensions
    {
        public static double ToPercent(this double number)
        {
            return number * 100;
        }

        public static double RoundDown(this double number)
        {
            return Math.Floor(number);
        }

        public static decimal ToDecimal(this double number)
        {
            return Convert.ToDecimal(number);
        }

        public static bool IsGreater(this double number, double compare)
        {
            return number > compare;
        }

        public static bool IsLess(this double number, double compare)
        {
            return number < compare;
        }
    }
}
