namespace Person_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);
            person1.Greet();
            person2.Greet();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            if (age > 0)
            {
                Age = age;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Age must be more than 0.");
            }
        }
        public bool IsAdult()
        {
            if (this.Age >= 18)
            {
                return true;
            }
            return false;
        }
        public void Greet()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
        }
    }
}