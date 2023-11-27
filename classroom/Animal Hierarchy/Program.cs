namespace Animal_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();

            var cat = new Cat();

            var bird = new Bird();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public Animal(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }
        public abstract void GetSound();
    }
    public class Dog : Animal
    {
        public Dog(string name, int age, string breed) : base(name,age,breed)
        {

        }
        public override void GetSound()
        {
            Console.WriteLine($"{this.Name} says: Woof!");
        }
        public override string ToString()
        {
            return $"A dog named {this.Name} is created. It is {this.Age} years old and a {this.Breed}.";
        }
    }
    public class Cat : Animal
    {
        public override void GetSound()
        {
            Console.WriteLine($"{this.Breed} says: Meow!");
        }
        public override string ToString()
        {
            return $"A cat named {this.Name} is created. It is {this.Age} years old and a {this.Breed}.";
        }
    }
    public class Bird : Animal
    {
        public override void GetSound()
        {
            Console.WriteLine($"{this.Name} says: Tweet tweet!");
        }
        public override string ToString()
        {
            return $"A bird named {this.Name} is created. It is {this.Age} years old and a {this.Breed}.";
        }
    }

}