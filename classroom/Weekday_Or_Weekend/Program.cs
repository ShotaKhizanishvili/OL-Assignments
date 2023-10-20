//2. * *Weekday or Weekend:**(Easy)Develop a program that determines whether a day
//    input by the user falls on a weekday or a weekend using a switch case
//3. * *Month Quarter: **(Easy)Extend the** Weekday or Weekend**program to categorize
//        the current month into a quarter of the year(Q1, Q2, Q3, Q4)

namespace Weekday_Or_Weekend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day;
            string month;

            Console.Write("Input day name: ");
            day = Console.ReadLine();

            if (day == null)
            {
                Console.WriteLine("try again.");
                return;
            }

            Console.Write("Input month: ");
            month = Console.ReadLine();

            if(month == null)
            {
                Console.WriteLine("try again");
                return;
            }

            switch (day)
            {
                case "Monday":
                    {
                        Console.WriteLine("Weekday");
                        break;
                    }

                case "Tuesday":
                    {
                        Console.WriteLine("Weekday");
                        break;
                    }
                case "Wednesday":
                    {
                        Console.WriteLine("Weekday");
                        break;
                    }
                case "Thursday":
                    {
                        Console.WriteLine("Weekday");
                        break;
                    }
                case "Friday":
                    {
                        Console.WriteLine("Weekday");
                        break;
                    }
                case "Saturday":
                    {
                        Console.WriteLine("Weekend");
                        break;
                    }
                case "Sunday":
                    {
                        Console.WriteLine("Weekend");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Your input is not a weekday nor a weekend");
                        break;
                    }
            }
            switch (month)
            {
                case "January":
                    {
                        Console.WriteLine("January is in Q1");
                        break;
                    }
                case "February":
                    {
                        Console.WriteLine("February is in Q1");
                        break;
                    }
                case "March":
                    {
                        Console.WriteLine("March is in Q1");
                        break;
                    }
                case "April":
                    {
                        Console.WriteLine("April is in Q2");
                        break;
                    }
                case "May":
                    {
                        Console.WriteLine("May is in Q2");
                        break;
                    }
                case "June":
                    {
                        Console.WriteLine("June is in Q2");
                        break;
                    }
                case "July":
                    {
                        Console.WriteLine("July is in Q3");
                        break;
                    }
                case "August":
                    {
                        Console.WriteLine("August is in Q3");
                        break;
                    }
                case "September":
                    {
                        Console.WriteLine("September is in Q3");
                        break;
                    }
                case "October":
                    {
                        Console.WriteLine("October is in Q4");
                        break;
                    }
                case "November":
                    {
                        Console.WriteLine("November is in Q4");
                        break;
                    }
                case "December":
                    {
                        Console.WriteLine("December is in Q4");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Your input is not a month.");
                        break;
                    }
            }
        }
    }
}