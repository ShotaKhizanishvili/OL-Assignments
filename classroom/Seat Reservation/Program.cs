namespace Seat_Reservation
{
    internal class Program
    {
        private static readonly char[,] Seats = new char[4, 4]
        {
            { '0', '0', '0', '0' },
            { '0', '0', '0', '0' },
            { '0', '0', '0', '0' },
            { '0', '0', '0', '0' }
        };

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Initial Seating Chart:");
                DisplaySeats();

                Console.WriteLine("Select an option: ");
                Console.WriteLine("1) Reserve a seat");
                Console.WriteLine("2) View available seats");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your choice: {choice}");
                        ReserveSeat();
                        break;
                    case 2:
                        Console.WriteLine($"Your choice: {choice}");
                        AvailableSeats();
                        break;
                    default:
                        Console.WriteLine("Wrong option, choose from (1,2).");
                        break;
                }
            } while (ContinuePrompt());
        }

        private static void DisplaySeats()
        {
            for (int i = 0; i < Seats.GetLength(0); i++)
            {
                for (int k = 0; k < Seats.GetLength(1); k++)
                {
                    Console.Write(Seats[i, k]);
                }

                Console.WriteLine();
            }
        }

        private static void ReserveSeat()
        {
            Console.Write("Enter the row number: ");
            var index1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the column number: ");
            var index2 = Convert.ToInt32(Console.ReadLine());
            if (index1 >= Seats.GetLength(0) || index2 >= Seats.GetLength(1))
            {
                Console.WriteLine("You entered wrong seats, try again.");
                return;
            }
            if (Seats[index1, index2] == 'X')
            {
                Console.WriteLine("That seat is already reserved, try again.");
                return;
            }

            Seats[index1, index2] = 'X';
            Console.WriteLine("Seat reserved.");
            Console.WriteLine("Updated Seating Chart: ");
            DisplaySeats();
        }

        private static void AvailableSeats()
        {
            DisplaySeats();
        }

        private static bool ContinuePrompt()
        {
            Console.WriteLine("Do you want to continue? (Yes,No)");
            var choice = Console.ReadLine();
            if (choice == "Yes")
            {
                return true;
            }

            return false;
        }
    }
}