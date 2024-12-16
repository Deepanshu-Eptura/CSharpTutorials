using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal class AccessModifier1
    {
        public static void Main()
        {
            CorporateCustomer c1= new CorporateCustomer();
            Console.WriteLine();
            
        }
    }
}
