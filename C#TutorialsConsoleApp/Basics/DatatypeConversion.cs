using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialsConsoleApp.Basics

/**
 *               Implicit conversions
 *     Implicit conversion is done by the compiler:
    1. When there is no loss of information if the conversion is done
    2. If there is no possibility of throwing exceptions during the conversion
    Example: Converting an int to a float will not loose any data and no
    exception will be thrown, hence an implicit conversion can be done.          
 *            
                  Explicit Conversions
    Where as when converting a float to an int, we loose the fractional part and
    also a possibility of overflow exception. Hence, in this case an explicit
    conversion is required. For explicit conversion we can use cast operator or
    the convert class in c#

                 Difference between Parse() and TryParse()

 */
{
    internal class DatatypeConversion
    {
        static void Main()
        {
            float f = 123.45F;
            int i = (int)f;
            // int i = Convert.ToInt32(f); // exception ouccurs when a large value dataype is converted into small datatype
            Console.WriteLine(i);

            //Parse(), it takes a string and convert it into integer
            string strNumber = "100";
            int k = int.Parse(strNumber);
            Console.WriteLine(k);

            //TryParse()
            string strNumber2 = "100TG";
            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(strNumber2, out Result);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {

                Console.WriteLine("Please eneter a valin no.");
                Console.WriteLine("Please dfeneter a valin no.");
            }
        }
    }
}
