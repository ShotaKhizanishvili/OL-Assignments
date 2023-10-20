using System;

//1. * *Age Bracket Determination:**(Easy)Create a program that asks for the user's
//    age and categorizes them as a child, a teenager, an adult, or a senior


namespace Age_Bracket_Determination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Input your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age <= 19 && age >= 13)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >=18 && age< 50)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age >= 50)
            {
                Console.WriteLine("You are a senior.");
            }

        }
    }
}