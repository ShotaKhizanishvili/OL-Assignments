namespace Grade_Analyzer
{
    internal class Program
    {
        private enum LetterGrade
        {
            A,
            B,
            C,
            D,
            F
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your grades separated by commas: ");
            var input = Console.ReadLine();
            var gradesArr = input.Split(',');
            var parsedGrades = ParseArr(gradesArr);
            if (parsedGrades.Any(a => (a < 0 || a > 100)))
            {
                Console.WriteLine("Grade can't be less than 0 or more than 100.");
                return;
            }

            Console.WriteLine($"Average Grade: {CalculateAverage(parsedGrades)}");
            Console.WriteLine($"Letter Grade: {DetermineLetterGrade(parsedGrades)}");
        }

        private static double CalculateAverage(double[] gradesArr)
        {
            double sum = 0;
            foreach (var grade in gradesArr)
            {
                sum += grade;
            }

            return sum/gradesArr.Length;
        }

        private static LetterGrade DetermineLetterGrade(double[] gradesArr)
        {
            var average = CalculateAverage(gradesArr);
            if (average >= 90 && average <= 100)
            {
                return LetterGrade.A;
            }
            if (average >= 80 && average < 90)
            {
                return LetterGrade.B;
            }
            if (average >= 70 && average < 80)
            {
                return LetterGrade.C;
            }

            if (average >= 60 && average < 70)
            {
                return LetterGrade.D;
            }

            return LetterGrade.F;
        }

        private static double[] ParseArr(string[] gradesArr)
        {
            double[] parsedGrades = new double[gradesArr.Length];
            for (int i = 0; i < gradesArr.Length; i++)
            {
                string trimmedGrade = gradesArr[i].Trim();
                double.TryParse(trimmedGrade, out double value);
                parsedGrades[i] = value;
            }

            return parsedGrades;
        }
    }
}