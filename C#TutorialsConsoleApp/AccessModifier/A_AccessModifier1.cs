using System;
/**
 * Access Modifier                                  Accessibility
----------------------------------------------------------------------------------------
Private               -                      Only with in the containing class
Public                -                     Anywhere, No Restrictions
Protected             -       With in the containing types and the types derived from the containing type
Internal              -                  Anywhere with in the containing assembly
Protected Internal    -                  Anywhere with in the containing assembly, and from within a                                             derived class in any another assembly

types mean - class , structure, interface (deafult is of "internal")
type members - method, varialble ,etc       (deafult is of "private")
 */

namespace C_TutorialsConsoleApp.AccessModifier
{
    public class Customer
    {
        protected int ID;
    }
    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;
            //this.ID;
            //base.ID;
        }
    }
    internal class A_AccessModifier1
    {
        public static void Main()
        {
            CorporateCustomer c1= new CorporateCustomer();
            Console.WriteLine();
            
        }
    }
}
