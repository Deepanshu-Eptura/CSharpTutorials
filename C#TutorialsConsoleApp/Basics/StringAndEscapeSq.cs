using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialsConsoleApp.Basics
/**
 *                      String in C#          
 * >> group of characters i.e. String is enclosed within the double quotes ("")
 *  
 *                   Escape Sequences in C#
 *  >> Character combinations consisting of a backslash (\) followed by a letter or by a combination of digits are called "escape sequences."
 *  \n - represents a new line character
    \t - represents a horizontal tab character
    \"	Double quotation mark
 *  
·                       Verbatim Literal
        >>  they make escape sequence as a normal character to be print
        >>  @  symbol is used
 */

{
    internal class StringAndEscapeSq
    {
        static void Main()
        {
            string demo = "Hello";
            Console.WriteLine("This is simple String: {0}",demo);

            //when you want to print duoble quotes("") 
            string demo1 = "\"Hello\"";
            Console.WriteLine("This String with double quotes: {0}", demo1);

            //when you want to print word in a newline 
            string demo2 = "Welcome\nDeepanshu\nSaini";
            Console.WriteLine("This String with newline: {0}", demo2);

            //here  we used \ to print the single backslash(\)
            string location = "C:\\Users\\DeepanshuSaini\\Downloads\\submitted";
            Console.WriteLine("This String with single backslash: {0}", location);

            //here  we appended '@' to print the single backslash(\) and also \\
            string location1 = @"C:\\Users\\DeepanshuSaini\\Downloads\\submitted";
            Console.WriteLine("This String with double backslashusing '@': {0}", location1);

            string location2 = @"C:\Users\DeepanshuSaini\Downloads\submitted";
            Console.WriteLine("This String with single backslash using '@' : {0}", location2);
        }
    }
}
