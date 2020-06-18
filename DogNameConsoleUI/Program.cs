using System;

namespace DogNameConsoleUI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //declared and initialized a variable
            //camelCase for the variable names
            //explicit typing
            string dogName = "Bear";
            int dogAge = 11;
            char nickName = 'B';
            bool lovesEating = true;
            double tennisBalls = 99;
            decimal weight = 54.8m;

            //string interpolation with the $ and { } around variables
            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old and weighs {weight}. It is {lovesEating} he loves to eat food and play with {tennisBalls} tennis balls. He also likes to be called {nickName}.");

        }
    }
}
