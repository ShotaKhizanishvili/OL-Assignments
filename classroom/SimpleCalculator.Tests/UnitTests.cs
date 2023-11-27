namespace SimpleCalculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,2)]
        public void Addition_Test(double a, double b)
        {
            double sum = SimpleCalculator.Addition(a, b);

            Assert.That(a + b, Is.EqualTo(sum));
        }

        [TestCase(1,2)]
        public void Subtraction_Test(double a, double b)
        {
            double sum = SimpleCalculator.Subtraction(a, b);

            Assert.That(a - b, Is.EqualTo(sum));
        }

        [TestCase(1,2)]
        public void Multiplication_Test(double a, double b)
        {
            double sum = SimpleCalculator.Multiplication(a, b);

            Assert.That(a * b, Is.EqualTo(sum));
        }

        [TestCase(1,2)]
        public void Division_Test(double a, double b)
        {
            double sum = SimpleCalculator.Division(a, b);

            Assert.That(a / b, Is.EqualTo(sum));
        }
    }
}