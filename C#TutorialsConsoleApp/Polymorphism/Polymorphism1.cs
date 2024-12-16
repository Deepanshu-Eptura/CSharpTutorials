using System;
/**
 Polymorphism is one of the primary pillars of object-oriented programming.
Polymorphism allows you to invoke derived class methods through a base class reference during runtime.
In the base class the method is declared virtual, and in the derived class we override the same method.
The virtual keyword indicates, the method can be overridden in any derived class.*/

namespace C_TutorialsConsoleApp.Polymorphism
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
    internal class Polymorphism1
    {
        static void Main()
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
