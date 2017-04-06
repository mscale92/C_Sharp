using System;
namespace ConvertToStringApp
{
   class NotStringDataTypes
    {
        //member variables
        bool truth;
        int wholeNum;
        float decimalNum;
        
        //value for our data, void because it does not return any one value
        public void DataValues()
        {
            truth = true;
            wholeNum = 45;
            decimalNum = 18.9f;
        }
        
        //function that prints our data on the console
        public void Print()
        {
            Console.WriteLine("These are my strings");
            Console.WriteLine(truth.ToString());
            Console.WriteLine(wholeNum.ToString());
            Console.WriteLine(decimalNum.ToString());
        }
        
    }

    class stringConverter
    {
        static void Main(string[] args)
        {
            NotStringDataTypes data = new NotStringDataTypes();
            //assign our other class to a variable in order to access our functions and data

            data.DataValues();
            //assign value to our data values

            data.Print();
            //print our data as converted strings

            Console.ReadKey();
        }
    }
}
