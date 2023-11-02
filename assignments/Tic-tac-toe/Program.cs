namespace Tic_tac_toe
{
    internal class Program
    {
        private static readonly char[,] boardArr = new char[3, 3] {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };
        static void Main(string[] args)
        {
            Console.WriteLine("Player1 is playing as x");
            Console.WriteLine("Player2 is playing as o");
            PrintBoard();

            int counter = 0;
            while (true)
            {
                SetPositionX();
                if (CheckWin())
                {
                    Console.WriteLine("Player1 Won!");
                    PrintBoard();
                    return;
                }
                if (counter == 8)
                {
                    break;
                }
                counter++;

                SetPositionO();
                if (CheckWin())
                {
                    Console.WriteLine("Player2 Won!");
                    PrintBoard();
                    return;
                }
                counter++;
            }
            Console.WriteLine("It's a draw!");
        }

        private static bool CheckWin()
        {
            #region Horizontal Win
            if (boardArr[0, 0] != '-' && boardArr[0, 0] == boardArr[0, 1] && boardArr[0, 1] == boardArr[0, 2])
            {
                return true;
            }
            if (boardArr[1, 0] != '-' && boardArr[1, 0] == boardArr[1, 1] && boardArr[1, 1] == boardArr[1, 2])
            {
                return true;
            }
            if (boardArr[2, 0] != '-' && boardArr[2, 0] == boardArr[2, 1] && boardArr[2, 1] == boardArr[2, 2])
            {
                return true;
            }
            #endregion

            #region Vertical Win
            if (boardArr[0, 0] != '-' && boardArr[0, 0] == boardArr[1, 0] && boardArr[1, 0] == boardArr[2, 0])
            {
                return true;
            }
            if (boardArr[0, 1] != '-' && boardArr[0, 1] == boardArr[1, 1] && boardArr[1, 1] == boardArr[2, 1])
            {
                return true;
            }
            if (boardArr[0, 2] != '-' && boardArr[0, 2] == boardArr[1, 2] && boardArr[1, 2] == boardArr[2, 2])
            {
                return true;
            }
            #endregion

            #region Diagonal Win
            if (boardArr[0, 0] != '-' && boardArr[0, 0] == boardArr[1, 1] && boardArr[1, 1] == boardArr[2, 2])
            {
                return true;
            }
            if (boardArr[0, 2] != '-' && boardArr[0, 2] == boardArr[1, 1] && boardArr[1, 1] == boardArr[2, 0])
            {
                return true;
            }
            #endregion

            return false;
        }

        private static void PrintBoard()
        {
            Console.WriteLine($"{boardArr[0, 0]} {boardArr[0, 1]} {boardArr[0, 2]}");
            Console.WriteLine($"{boardArr[1, 0]} {boardArr[1, 1]} {boardArr[1, 2]}");
            Console.WriteLine($"{boardArr[2, 0]} {boardArr[2, 1]} {boardArr[2, 2]}");
        }
        private static void SetPositionX()
        {
            int index1, index2;

            Console.Write("Enter Player1 position (x,y or x y):");
            index1 = Console.Read() - '0';
            Console.Read();
            index2 = Convert.ToInt32(Console.ReadLine());
            if (boardArr[index1, index2] == '-')
            {
                boardArr[index1, index2] = 'x';
                PrintBoard();
                return;
            }
            Console.WriteLine($"Cannot set position. [{index1},{index2}] is not empty.");
            SetPositionX();
        }
        private static void SetPositionO()
        {
            int index1, index2;

            Console.Write("Enter Player2 position (x,y or x y):");
            index1 = Console.Read() - '0';
            Console.Read();
            index2 = Convert.ToInt32(Console.ReadLine());
            if (boardArr[index1, index2] == '-')
            {
                boardArr[index1, index2] = 'o';
                PrintBoard();
                return;
            }
            Console.WriteLine($"Cannot set position. [{index1},{index2}] is not empty.");
            SetPositionO();
        }
    }
}