using System;
/**
 Function overloading and Method overloading terms are used interchangeably.
Method overloading allows a class to have multiple methods with the same name, but, with a different signature. So, in C# functions can be overloaded based on the number, type(int, float etc) and kind(Value, Ref or Out) of parameters.
The signature of a method consists of the name of the method and the type, kind (value, reference, or output) and the number of its formal parameters. The signature of a method does not include the return type and the params modifier. So, it is not possible to overload a function, just based on the return type or params modifier.*/

namespace C_TutorialsConsoleApp.Polymorphism
{
    internal class MethodOverloading
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main()
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
