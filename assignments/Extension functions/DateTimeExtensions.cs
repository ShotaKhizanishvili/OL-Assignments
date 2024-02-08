namespace Extension_functions
{
    public static class DateTimeExtensions
    {
        public static DateTime Min(this DateTime date, DateTime otherDate)
        {
            return date < otherDate ? date : otherDate;
        }

        public static DateTime Max(this DateTime date, DateTime otherDate)
        {
            return date > otherDate ? date : otherDate;
        }

        public static DateTime BeginningOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime EndOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
    }
}
