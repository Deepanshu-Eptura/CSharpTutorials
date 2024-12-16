using System;
/**
 *                          Internal
A member with internal access modifier is available any where with in the containing assembly. It's a compile time error to access, an internal member from outside the containing assembly.

                        Protected Internal
Protected Intemal members can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly. It is a combination of protected and internal. If you have understood protected and intemal, this should be very easy to follow.
 */

namespace C_TutorialsConsoleApp.AccessModifier
{
    class InternalTest
    {
        internal string name = "Deepanshu Saini";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }


        protected internal string name1 = "Saini Deepanshu";
        protected internal void Msg1(string msg1)
        {
            Console.WriteLine("Hello " + msg1);
        }
    }
    internal class B_AccessModifier
    {
        static void Main()
        {
            InternalTest internalTest = new InternalTest();
            // Accessing internal variable  
            Console.WriteLine("Hello Internal " + internalTest.name);
            // Accessing internal function  
            internalTest.Msg("Internal");

            InternalTest internalTest2 = new InternalTest();
            // Accessing protected internal variable  
            Console.WriteLine("Hello Protected internal " + internalTest2.name);
            // Accessing protected internal function  
            internalTest2.Msg("Protected Internal");
        }
    }
}
