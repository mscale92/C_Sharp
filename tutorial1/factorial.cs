using System;
namespace MyFactorial
{
    public class FactorialValues
    {
        //use recursion, calling a function upon itself, in order to find the factorial of a number
        public long Factorial(int num)
        {
            if (num == 0)
                return 1;
            return num * Factorial(num - 1);
            
        }

        public string AskUser()
        {
            //ask the user for an integer
            Console.WriteLine("Please enter a whole number to find its factorial");

            //ReadLine() is always a string
            return Console.ReadLine();

            //we're returning a string so that we can test to see if its an integer in our print function,
            //if we returned a string valued as an integer, well that causes a program crashing error
        }

        public void Print()
        {
            //have the user's answer equal to the return value of our function
            //this way, we can print the exact answer the user gave us, to throw it back in their face!
            string usersAns = AskUser();


            //have a backup number in case the user doesn't enter a number
            int x = 0;

            //if the data type is not an integer, a different message appears
            if (!Int32.TryParse(usersAns, out x))
            {
                Console.WriteLine("Ahem, {0} is not a valid whole number. \nNice Try :P!", usersAns);
            }

            else
            {
                
                //convert the string into an integer and pop it into our Factorial function
                Console.WriteLine("The factorial is {0}", Factorial(Int32.Parse(usersAns)));
            }

        }
    }

    class ExecuteFactorial
    {
        static void Main(string[] args)
        {
            FactorialValues fact = new FactorialValues();

            fact.Print();

            Console.ReadKey();
        }
    }
}
