using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodExerise
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------Exercise 1
            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What's your favortite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string favoriteFood = Console.ReadLine();

            Console.WriteLine($"This a story about {name} the {favoriteAnimal}. \n" +
                             $"{name} was eating {favoriteFood} and wearing a {favoriteColor} t-shirt \n" +
                             $"and rocking out to {favoriteBand}");

            Console.ForegroundColor = ConsoleColor.Green;
            int x = 2;
            int y = 3;
            int[] myArray = { 2, 3, 3, 4, 5 };


            Console.WriteLine(add(x,y));
            Console.WriteLine(multiply(x, y));

            Console.WriteLine(add(myArray));
            Console.WriteLine(multiply(myArray));
        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int add(int [] myArray)
        {
            var sum = 0;

            foreach (var num in myArray)
            {
                sum += num;
            }
            return sum;
        }


        public static int multiply(int num1, int num2) 
        {
            return num1 * num2;
        }

        public static int multiply(int [] myArray)
        {
            
            var result = 1;

            foreach (var num in myArray)
            {
                result *= num;
            }
            return result;
        }

    }
}
