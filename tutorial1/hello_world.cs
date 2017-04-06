using System;
namespace HelloWorldApp {

    class HelloWorld
    {
        static void Main()
        {
            /*my first hello world in c#*/
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

}


/*What's going here?
 Well, we are running a basic, very basic, C# program.
 Let's explain the working parts:
    1. using System
        using is a keyword in C#, it means that the program is including a namespace

        System refers to the namespace System
     
    WAIT! 
    What's a namespace?

    "Namespaces are C# program elements designed to help you organize your programs," -csharp-station.com
    
    From what I can figure, from my first C# program, namespaces are elements that encompass code. You can create your own or use
    ones that already exist in the framework, or both.
    
    So the System namespace has a whole bunch of code, similar to the special functions in JS Array Methods, telling the program
    that we will be using classes specified in the System namespace. At least, that's what I've gathered so far.

    2. namespace
        Well namespace is a keyword that declares a new namespace, like declaring a new element.
        Its value exits between curly brackets. Generally, it's a good idea to start with more general namespaces and nest more
        specific namespaces to better organize code, according to Google.
    
    3. static void
        Alright, JS does not have this so static is new to me. From what I can tell, and have read, static void tells the program where
        to start, an entry way.
        C# needs a static starting point, or a static function to call.

        Void simply says that it doesn't return a value. I copied some notes from StackOverflow below
            {
            "public" means that main() can be called from anywhere.
            "static" means that main() doesn't belong to a specific object
            "void" means that main() returns no value
            "main" is the name of a function. main() is special because it is the start of the program.
            "String[]" means an array of String.
            "args" is the name of the String[] (within the body of main()). "args" is not special; you could name it anything else and the program would work the same.
            }

    4. Main()
        This is the main function, or method if you prefer, just like in C!

    5. class
        Ah the class keyword, this defines a class, aka a collection of methods aka a group of functions and data, like a JS Object.
        And, like JS methods, there are built in classes that can be accessed by using namespaces, sound familiar System?

        To me, I could be very wrong, classes seem to function similarly to Object Methods in JS.
     
    6. Console
        Another keyword! This one is a class in the System namespace, it refers to actions appearing/affecting the console

        6a. Writeline()
        Writeline takes a string between its () and writes it out.

        Funny, this all seems familiar to console.log() ;)
        
        6a. ReadKey();
        ReadKey tells the program to wait for a key press in order to stop. 
        This prevents the screen from running then immediately closing when the program is launched in VS (Visual Studio)
     
    Some keynotes:
        C# is case sensitive
        Always always always end statements with ; just like JS
*/
