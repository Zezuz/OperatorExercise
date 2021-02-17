using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit typing -
            string variableName = "Hello";

            //inferred typing -
            var varName = "Hello";


            // x += 12 is ( x = x+12)
            // x -= 11 is ( x = x-12)
            // x /= 12 is ( x = x/12)
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

        }
    }
}
