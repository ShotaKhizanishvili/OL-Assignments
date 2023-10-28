namespace Day_Planner
{
    internal class Program
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        private static readonly Dictionary<Days, string[]> ActivityDictionary = new()
    {
        { Days.Monday, new[] { "Work" } },
        { Days.Tuesday, new[] { "Work", "Day off" } },
        { Days.Wednesday, new[] { "Work", "Work harder" } },
        { Days.Thursday, new[] { "Work" } },
        { Days.Friday, new[] { "Work", "Read" } },
        { Days.Saturday, new[] { "Sleep", "Play", "Hike", "Read", "Drink" } },
        { Days.Sunday, new[] { "Sleep", "Play", "Hike", "Read", "Drink" } },
    };
        static void Main(string[] args)
        {
            Console.WriteLine("Write a week day:");
            var dayString = Console.ReadLine();
            var parsed = Enum.TryParse(dayString, out Days day);

            if (!parsed)
            {
                throw new ArgumentOutOfRangeException("Invalid week day");
            }

            var random = new Random();

            var activities = ActivityDictionary[day];
            var randomIndex = random.Next(0, activities.Length - 1);
            Console.WriteLine(activities[randomIndex]);
        }
        //public static Days ConvertDayToEnum(string day)
        //{
        //    switch (day)
        //    {
        //        case "Monday":
        //            {
        //                return Days.Monday;
        //            }

        //        case "Tuesday":
        //            {
        //                return Days.Tuesday;
        //            }
        //        case "Wednesday":
        //            {
        //                return Days.Wednesday;
        //            }
        //        case "Thursday":
        //            {
        //                return Days.Thursday;
        //            }
        //        case "Friday":
        //            {
        //                return Days.Friday;
        //            }
        //        case "Saturday":
        //            {
        //                return Days.Saturday;
        //            }
        //        case "Sunday":
        //            {
        //                return Days.Sunday;
        //            }

        //        default:
        //            {
        //                Console.WriteLine("Your input is not a day");
        //                break;
        //            }
        //    }
        //    return default;
        //}
    }
}