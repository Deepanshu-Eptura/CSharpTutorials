using System;
/**
 * Use the new keyword to hide a base class member. You will get a compiler warning, if you miss the new keyword.
 * 
    Different ways to invoke a hidden base class member from derived class
    1. Use base keyword
    2. Cast child type to parent type and invoke the hidden member
    3. ParentClass PC = new ChildClass()
       PC.HiddenMethod()
 */

namespace C_TutorialsConsoleApp.Inheritance
{
    public class Employee1
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }
    public class PartTimeEmployee1 : Employee1
    {
    public new void PrintFullName()
        {
            base.PrintFullName(); //base refers to base class , 1st method

            //Console.WriteLine(FirstName + " " + LastName + "- Contractor");
        }
    }


internal class MethodHiding
    {
        public static void Main()
        {

           // Employee1 PTE = new PartTimeEmployee1(); //3rd another method

          //  ((Employee1)PTE).PrintFullName();   //2nd method

            PartTimeEmployee1 PTE = new PartTimeEmployee1();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            PTE.PrintFullName();
        }
    }
}
