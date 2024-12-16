using System;
/**
 In C# to encapsulate and protect fields we use properties
1. We use get and set accessors to implement properties
2. A property with both get and set accessor is a Read/Write property
3. A property with only get accessor is a Read only property
4. A property with only set accessor is a Write only property
Note: The advantage of properties over traditional Get() and Set() methods is that, you can access them as if they were public fields
                                Why Encapsulation?
Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
Flexible: the programmer can change one part of the code without affecting other parts
Increased security of data
 */

namespace C_TutorialsConsoleApp.Propertiies
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    //Using automatic properties:
    //class Person
    //{
    //    public string Name  // property
    //    { get; set; }
    //}
    internal class Propperties
    {
        static void Main()
        {
            Person myObj = new Person();
            myObj.Name = "Deepanshu";
            Console.WriteLine(myObj.Name);
        }

       
    }
}
