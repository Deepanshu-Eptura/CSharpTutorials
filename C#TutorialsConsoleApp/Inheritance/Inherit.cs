using System;
/**
 * >> 1. Inheritance is one of the primary pillars of object oriented programming.
 >>   2. It allows code reuse.
 >>   3. Code reuse can reduce time and errors.

Note: You will specify all the common fields, properties, methods in the base class, which allows           reusability. In the derived class you will only have fields, properties and methods, that are specific to them.

1. In this example DerivedClass inherits from ParentClass.
2. C# supports only single class inheritance.
3. C# supports multiple interface inheritance.
4. Child class is a specialization of base class.
5. Base classes are automatically instantiated before derived classes.
6. Parent Class constructor executes before Child Class constructor.

Multiple class inheritance cant be possible
 */

namespace C_TutorialsConsoleApp.Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalay;
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    internal class Inherit
    {
        public static void Main()

        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Deepanshu";
            FTE.LastName = "Saini";
            FTE.YearlySalay = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Part";
            PTE.LastName = "Time";
            PTE.PrintFullName();
        }
    }
}
