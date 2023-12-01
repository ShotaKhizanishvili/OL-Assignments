while (true)
{
    Console.WriteLine("Select math operation: Addition \nSubtraction \nMultiplication \n" +
                      "Division \nSquare \nSquare Root \nPower");
    var operation = Console.ReadLine();

    switch (operation)
    {
        case "Addition":
        {
            InputNumbers(out double firstNum, out double secondNum);
            Console.WriteLine("Answer: " + Add(firstNum, secondNum));
            break;
        }
        case "Subtraction":
        {
            InputNumbers(out double firstNum, out double secondNum);
            Console.WriteLine("Answer: " + Subtract(firstNum, secondNum));
            break;
        }
        case "Multiplication":
        {
            InputNumbers(out double firstNum, out double secondNum);
            Console.WriteLine("Answer: " + Multiply(firstNum, secondNum));
            break;
        }
        case "Division":
        {
            InputNumbers(out double firstNum, out double secondNum);
            Console.WriteLine("Answer: " + Divide(firstNum, secondNum));
            break;
        }
        case "Square":
        {
            InputNumber(out double number);
            Console.WriteLine("Answer: " + Square(number));
            break;
        }
        case "Square Root":
        {
            InputNumber(out double number);
            Console.WriteLine("Answer: " + SquareRoot(number));
            break;
        }
        case "Power":
        {
            InputNumbers(out double number, out double power);
            Console.WriteLine("Answer: " + Power(number, (int)power));
            break;
        }

        default:
        {
            Console.WriteLine(operation + " is not a math operation");
            break;
        }
    }
}

void InputNumbers(out double firstNum, out double secondNum)
{
    Console.Write("Enter first number:");
    firstNum = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second number:");
    secondNum = Convert.ToDouble(Console.ReadLine());
}

void InputNumber(out double number)
{
    Console.Write("Enter number:");
    number = Convert.ToDouble(Console.ReadLine());
}

double Add(double firstNum, double secondNum)
{
    return firstNum + secondNum;
}

double Subtract(double firstNum, double secondNum)
{
    return firstNum - secondNum;
}

double Multiply(double firstNum, double secondNum)
{
    return firstNum * secondNum;
}

double Divide(double firstNum, double secondNum)
{
    if (secondNum == 0)
    {
        throw new ArgumentException("Can not divide by zero.");
    }

    return firstNum / secondNum;
}

double Square(double number)
{
    return Math.Pow(number, 2);
}

double SquareRoot(double number)
{
    return Math.Sqrt(number);
}

double Power(double number, int power)
{
    return Math.Pow(number, power);
}