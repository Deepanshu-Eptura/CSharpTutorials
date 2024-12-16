using System;
using System.Collections.Generic;
/**
 * with the help of this, <T> but WE CAN GIVE ANY NAME, <ANY_NAME>
 * 
 * we can make ant class, interface and method as a generic type
 
 */


namespace C_TutorialsConsoleApp.Generics
{
    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
    //making class  generic using, <T>
    public class Calculator2<T>
    {
        public static bool IsEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
    internal class Generic
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual<int>(10, 10);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            //when class is generic
            bool Equal2 = Calculator2<int>.IsEqual(10, 10); //generic class ref.
            if (Equal2)
            {
                Console.WriteLine("yes,Equal");
            }
            else
            {
                Console.WriteLine("sorry, not Equal");
            }
        }
    }
}
