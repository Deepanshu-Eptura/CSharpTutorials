using System;
/**
 *              Static and Instance class members
>>  When a class member includes a static modifier, the member is called as static member. When no static modifier is present the member is called as non static member or instance member.

>>  Static members are invoked using class name, where as instance members are invoked using instances (objects) of the class.

>>  An instance member belongs to specific instance(object) of a class. If I create 3 objects of a class, I will have 3 sets of instance members in the memory, where as there will ever be only one copy of a static member, no matter how many instances of a class are created.

                        Static constructor
Static constructors are used to initialize static fields in a class.
You declare a static constructor by using the keyword static in front of the constructor name.
Static Constructor is called only once, no matter how many instances you create.
Static constructors are called before instance constructors
 */

namespace C_TutorialsConsoleApp.Class
{
    class Circle
    {
       public static float _PI;
        int _Radius;
        static Circle()
        {
            Console.WriteLine("static const. called");
            Circle._PI = 3.141F;
        }
        public Circle(int Radius)
        {
            Console.WriteLine("instance const. called");
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }
    internal class StaticandInstance
    {
        public static void Main()
        {
            Circle C1 = new Circle(5);
            float Area1 =C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);
            Circle C2= new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
        }
    }
}
