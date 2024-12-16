/*
 * >> C# is a case sensitive language.
 * >> Here "System" is a namespace.
 * >> Namespace:- it is  is used to organize your code, and it is a container for classes and     other                   namespaces.
 * >> Namespace here is system which tells us that our code is using system or our code is in system.
 * 
 * >> Console - it is class persent in System namespace
 * 
 *       <<   Pgm to print and Reading input from user and 2 ways to write to console    >>
 * */
using System;

namespace C_TutorialsConsoleApp
{
    internal class Intro
    {
        static void Main() //here in Main, 'M' is in capital (in java it is "main")

        {
            //here WriteLine() is function which is used to print something
            Console.WriteLine("Welcome to C# Tutorials, your name please?"); 

            //here ReadLine() is function which is used to read input from user
            string UserName = Console.ReadLine();

            // 1st way, this is concatination to print input from user
            //Console.WriteLine("Hello " + UserName); 

            // 2nd way, this is Placeholder syntax to print input from user  (mostly preffered)        
            Console.WriteLine("Hello {0}", UserName);

            Console.WriteLine("Please enter your full name");

            Console.WriteLine("Please enter your firstname");
            string FirstName= Console.ReadLine();
            Console.WriteLine("Please enter your lastname");
            string LastName= Console.ReadLine();

            Console.WriteLine("Welcome {0} {1}", FirstName, LastName);
        }
    }
}
