using System;
using C_TutorialsConsoleApp.Inheritance;

//base, keyword is used to control the base class member , which is to be executed and when
namespace C_TutorialsConsoleApp.Inheritance
{
    public class ParentClass
{
    public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor called");
        }
    public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class ChildClass : ParentClass
    {
    public ChildClass() : base("Derived class controlling Parent class")
    {
        Console.WriteLine("ChildClass Constructor called");
    }
    }
    internal class BaseKeyword
    {
        public static void Main()
        {
            ChildClass childClass = new ChildClass();
        }
    }
}
