using System;
/**
 *>>  When a method declaration includes a static modifier, that method is said to be a static method.
When no static modifier is present, the method is said to be an instance method.

>>  Static method is invoked using the class name, where as an instance method is invoked using
an instance of the class.

>>  The difference between instance methods and static methods is that multiple instances of a
class can be created (or instantiated) and each instance has its own separate method. However,
when a method is static, there are no instances of that method, and you can invoke only that
one definition of the static method.

 */

namespace C_TutorialsConsoleApp.Basics
{
    internal class Methods
    {

        public static void Main()
        {
            Methods.EvenNumbers(30); //or just, EvenNumbers(30);

            Methods P = new Methods(); //creating object
            int Sum = P.Add(10, 20);
            Console.WriteLine("Sum {0}", Sum);
        }
        //instance method
        public  int Add(int FN, int SN)
        {
            return FN + SN;
        }

        //static methods
        public static void EvenNumbers(int Target)
        {
            int Start = 0;
            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start +2;
            }
        }

    }
}
