using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ------------Exercise 1--------------------------------

            Console.WriteLine("Hello, What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color :) What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great, now what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("Here is your mad lib!");

            Console.WriteLine($"{userName} was walking home from school when a " +
                $"{color} {animal} was spotted across the street performing a " +
                $"{band} cover");
            
        }
    }
}
