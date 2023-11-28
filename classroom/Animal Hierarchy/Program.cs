namespace Animal_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Buddy", 5, "Labrador Retriever");
            Console.WriteLine(dog.ToString());
            dog.GetSound();

            var cat = new Cat("Whiskers", 3, "Siamese");
            Console.WriteLine(cat.ToString());
            cat.GetSound();

            var bird = new Bird("Tweety", 2, "Canary");
            Console.WriteLine(bird.ToString());
            bird.GetSound();
        }
    }

    public abstract class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Breed { get; set; }

        protected Animal(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }

        public abstract void GetSound();
    }

    public class Dog : Animal
    {
        public Dog(string name, int age, string breed) : base(name, age, breed)
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
        public Cat(string name, int age, string breed) : base(name, age, breed)
        {
        }

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
        public Bird(string name, int age, string breed) : base(name, age, breed)
        {
        }

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