namespace Console_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum, result;
            string operation;

            result = default;

            Console.WriteLine("Enter first number: ");
            firstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter math operation (+, -, *, /): ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    {
                        result = Addition(firstNum, secondNum); break;
                    }
                case "-":
                    {
                        result = Subtraction(firstNum, secondNum); break;
                    }
                case "*":
                    {
                        result = Multiplication(firstNum, secondNum); break;
                    }
                case "/":
                    {
                        if (secondNum == 0)
                        {
                            Console.WriteLine("Can not divide by zero.");
                            return;
                        }
                        result = Division(firstNum, secondNum); break;
                    }
                default:
                    {
                        Console.WriteLine(operation + " is not a math operation");
                        break;
                    }
            }
            Console.WriteLine(result);
        }
        public static double Addition(double firstNum,double secondNum)
        {
            return firstNum + secondNum;
        }
        public static double Subtraction(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public static double Multiplication(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public static double Division(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
    }
}