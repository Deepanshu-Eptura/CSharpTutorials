using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialsConsoleApp.Basics
/*
 *                          NULLABLE types
 * >> Nullable types bridge the differences between C# types and Database types
 * 
 *                      Null Coalescing Operator:  ??
 *  double question mark (??) is used.
 */
{
    internal class NullableType
    {
        static void Main()
        {
            int? TicketsOnSale = 100;
            int AvailableTickets;     //here we can also use, Null Coalescing Operator:  ??
            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                //we can also assgin the value by below method, because nullable type can't be implicitly converted into not nullable types, has to be done forcefully(explicitly).

                // AvailableTickets = TicketsOnSale.Value; //this value method pass only not nullable type

                AvailableTickets = (int)TicketsOnSale; //forcefully converting using typecast operator
            }
            Console.WriteLine("AvaialableTickets = {0}", AvailableTickets);

            //using, Null Coalescing Operator:  ?? , to avoid these if - else 

            // int AvailableTickets = TicketsOnSale ?? 0;
            // Console.WriteLine("AvaialableTickets = {0}", AvailableTickets);
        }
    }
}
