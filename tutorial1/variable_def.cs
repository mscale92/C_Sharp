using System;
namespace VariableDefinition
{
    public class VariableDefProgram
    {
        static void Main(string[] args)
        {
            //declaring variables and data types
            short a;
            int b;
            double c;

            string A;
            string B;
            string C;

            //assigning values to variables
            a = 4;
            b = 20;
            c = a + b;

            A = "4";
            B = "20";
            C = A + B;

            //The {0} refer to the variable order after the quotes, like an array starts at zero
            //This prevents having to break quotes, so {0} refers to variable a in this instance
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", A, B, C);

            Console.ReadLine();

        }
    }
}
