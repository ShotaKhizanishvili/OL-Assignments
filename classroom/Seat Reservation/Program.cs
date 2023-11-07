namespace Seat_Reservation
{
    internal class Program
    {
        private static char[,] seats = new char[4, 4] {
            { '0','0','0','0' },
            { '0','0','0','0' },
            { '0','0','0','0' },
            { '0','0','0','0' }
        };
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Initial Seating Chart:");
            DisplaySeats();

            Console.WriteLine("Select an option: ");
            Console.WriteLine("1) Reserve a seat");
            Console.WriteLine("2)View available seats");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:break;
                case 2:break;
                default:break;
            }
        }
        public static void DisplaySeats()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int k = 0; k < seats.GetLength(1); k++)
                {
                    Console.Write(seats[i, k]);
                }
                Console.WriteLine();
            }
        }
        public static void ReserveSeat()
        {
            int index1, index2;
            Console.Write("Enter the row number: ");
            index1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the column number: ");
            index2 = Convert.ToInt32(Console.ReadLine());
            if (index1 >= seats.GetLength(0) || index2 >= seats.GetLength(1))
            {
                Console.WriteLine("You entered wrong seats, try again.");
            }

            seats[index1, index2] = 'X';
            Console.WriteLine("Updated Seating Chart: ");
            DisplaySeats();
        }
        public static void AvailableSeats()
        {
            DisplaySeats();
        }
    }
}