using System;

namespace MethodsFun
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine();

                Console.WriteLine("What is your favorite Movie?");
                string userMovie = Console.ReadLine();

                Console.WriteLine("What is your favorite relaxing drink?");
                string userDrink = Console.ReadLine();

                Console.WriteLine("What is your favorite season?");
                string userSeason = Console.ReadLine();

                Console.WriteLine($"{userName} loves nothing more than to curl up on the couch with a nice cup of {userDrink}.");
                Console.WriteLine($"Nothing beats watching {userMovie} on a perfect {userSeason} night.");
                Console.WriteLine($"Try not to spill your {userDrink} when your favorite part of {userMovie} happens!");

                Console.WriteLine("Now let's try some math.");
                Console.WriteLine("Give me a number to add.");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Give me a number to add to the first number.");
                int num2 = int.Parse(Console.ReadLine());

                int sum = Sum(num1, num2);
                Console.WriteLine($"The sum is: {sum}.");

                Console.WriteLine("Do you remember your multiplication tables??");

                Console.WriteLine("Give me a number to multiply.");
                int product1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Give me a number to multiply with the first number.");
                int product2 = int.Parse(Console.ReadLine());

                int product = Multiply(product1, product2);
                Console.WriteLine($"The product is: {product}");
                Console.WriteLine($"Ok {userName}, that's enough math for the day!  Go enjoy a nice cup of {userDrink}.");
                Console.WriteLine("You Earned it!");

            }

            public static int Sum(int num1, int num2)
            {

                return num1 + num2;
            }

            public static int Multiply(int x, int y)
            {

                return x * y;
            }
        }
    }

