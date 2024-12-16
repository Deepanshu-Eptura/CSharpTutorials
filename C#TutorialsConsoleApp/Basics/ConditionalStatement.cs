using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialsConsoleApp.Basics
{
    internal class ConditionalStatement
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            //code for switch
            switch (UserNumber)
            {
                //case 10:
                //    Console.WriteLine("Your number is 10");
                //    break;
                //case 20:
                //    Console.WriteLine("Your number is 20");
                //    break;
                //case 30:
                //    Console.WriteLine("Your number is 30");
                //    break;
                //default:
                //    Console.WriteLine("Your number is not 10, 20 & 30");
                //    break;

                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;
            }
        }
    }
}
