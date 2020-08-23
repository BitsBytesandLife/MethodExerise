using System;

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


        }
    }
}
