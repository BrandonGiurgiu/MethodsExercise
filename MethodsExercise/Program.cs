namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;

        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }
        static void Main(string[] args)
        {
            // -----------Exercise 2---------------------------------

            var amountOfCars = Sum(2, 6);
            Console.WriteLine($"{amountOfCars}");

            var amountOfVans = Subtract(6, 2);
            Console.WriteLine($"{amountOfVans}");

            var amountOfBikes = Divide(10, 5);
            Console.WriteLine($"{amountOfCars}");

            var amountOfTrucks = Multiply(2, 6);
            Console.WriteLine($"{amountOfTrucks}");


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
