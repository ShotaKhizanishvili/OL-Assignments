namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var profile = new Profile("Alex", 25);
            profile.Age = -25;
            Console.WriteLine(profile.ToString());
        }
    }

    public class Profile
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Console.Write("Name updated successfully.\n");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (ValidateAge(value))
                {
                    _age = value;
                    Console.Write("Age updated successfully.\n");
                }
                else
                {
                    Console.WriteLine("Trying to set a negative age...");
                    Console.WriteLine("Error: Age cannot be negative.");
                }
            }
        }

        public Profile(string name, int age)
        {
            Console.WriteLine("Creating new profile...");
            Console.Write($"Setting name to '{name}'.");
            Name = name;
            Console.Write($"Setting name to {age}.");
            Age = age;
        }

        public override string ToString()
        {
            return $"Current Profile:\nName: {Name}\nAge: {Age}";
        }

        private bool ValidateAge(int age)
        {
            return age >= 0;
        }
    }
}