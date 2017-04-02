using System;
namespace MultiplierApp
{
    class Numbers
    {
        //This is where we will declare our data, as member variables, as well as our functions that affect our data

        //member variables, double rather than float or decimal
        double number1;
        double number2;

        public void NumberValues()
        {
            number1 = 3;
            number2 = 8;
        }

        public double Multiply()
        {
            return number1 * number2;
        }

        public void Print()
        {
            Console.WriteLine("Number One: {0}", number1);
            Console.WriteLine("Number Two: {0}", number2);
            Console.WriteLine("Total: {0}", Multiply());
        }

        //public means that this method can be accessed anywhere, we want our Main() to have access
        //{0} means space

    }

    class MultiplyNumbers
    {
       //This will be where our Main goes, our main execution

        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            num.NumberValues();
            num.Print();

            /*We are making a new Numbers object called num
             Then we call upon the methods we created within Numbers with our new object*/

            Console.ReadLine();
        }
    }



}


//let's csc this bad boy