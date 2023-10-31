namespace Grade_Analyzer
{
    internal class Program
    {
        public enum LetterGrade { A, B, C, D, F }

        static void Main(string[] args)
        {
            //...
            int[] gradesArr = new int[1];

            Console.Write("Enter your grades separated by commas: ");

            Console.Write($"Average Grade: {CalculateAverage(gradesArr)}");

            Console.Write($"Average Grade: {DetermineLetterGrade()}");
        }

        public static double CalculateAverage(int[] gradesArr)
        {
            return default;
        }
        public static LetterGrade DetermineLetterGrade()
        {
            return default;
        }
    }
}