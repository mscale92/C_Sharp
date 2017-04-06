using System;
namespace TypeConversionApp
{

class IntConversion
    {
        static void Main(string[] args)
        {
            float myfloat = 123.475f;
            //always include f after declaring a value as a float
            double mydouble = 4561.78984;
            

            Console.WriteLine("My float {0}", myfloat);
            Console.WriteLine("My float converted {0}", Convert.ToInt32(myfloat));
            Console.WriteLine("My double {0}", mydouble);
            Console.WriteLine("My double converted {0}", Convert.ToInt32(mydouble));
            Console.ReadKey();

            //Don't forget the keyword Convert before Converting anything except strings, that's ToString();
            
        }
    }

}


