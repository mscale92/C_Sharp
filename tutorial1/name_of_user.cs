using System;
namespace WhatIsYourName
{
    public class QuestionForTheUser
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("What is your name?");

            //ReadLine accepts input from the user, this is from the Console
            name = Console.ReadLine();
           

            Console.WriteLine("Your name is {0}!", name);
            Console.ReadKey();
        }
    }
}
