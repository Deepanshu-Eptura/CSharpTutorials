using System;
/**
 *      There are 4 different types of parameters a method can have
>>   1 Value Parameters: Creates a copy of the parameter passed, so modifications does not
        affect each other.

>>  2. Reference Parameters: The ref method parameter keyword on a method parameter causes
        a method to refer to the same variable that was passed into the method. Any changes made
        to the parameter in the method will be reflected in that variable when control passes back
        to the calling method.

>> 3. Out Parameters: Use when you want a method to return more than one value.

>>  4. Parameter Arrays: The params keyword lets you specify a method parameter that takes a
        variable number of arguments. You can send a comma-separated list of arguments, or an
        array, or no arguments. Params keyword should be the last one in a method declaration,
        and only one params keyword is permitted in a method declaration.
 */

namespace C_TutorialsConsoleApp.Basics
{
    internal class MethodParameter
    {
        public static void Main()
        {
            int i = 0;
            SimpleMethod(ref i);
            Console.WriteLine(i);
        }
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        //                              OUT PARAMETER
        //public static void Main()
        //{
        //    int Total =0;
        //    int Product = 0; 
        //    Calculate(10, 20, out Total, out Product);
        //    Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
        //}
        //public static void Calculate(int FN, int SN, out int Sum, out int Product)
        //{
        //    Sum =FN +SN;
        //    Product =FN *SN;
        //}

        //      PARAMS ARRAYS
        //public static void Main()
        //{
        //    int[] Numbers = new int[3];
        //    Numbers[0]= 101;
        //    Numbers[1]= 102;
        //    Numbers[2]=103;
        //    //ParamsMethod();
        //    //Params Method (Numbers); 
        //    ParamsMethod(1, 2, 3, 4, 5);
        //}
        //public static void ParamsMethod(params int[] Numbers)
        //{
        //    Console.WriteLine("There are {0} elemnts", Numbers.Length);
        //    foreach (int i in Numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
