namespace OOPASS_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
// النظري
//Q1  A

//a) What is the difference between Method Overloading and Method Overriding?

//Method Overloading:

//Same method name.
//Different parameters.
//Resolved at Compile Time.


//Method Overriding:

//A child class provides a new implementation of a method from the parent class.
//Uses virtual in the parent and override in the child.
//Resolved at Run Time.

//Q1  B

//What is the difference between Static Binding and Dynamic Binding?

//Static Binding:

//The method to be called is determined at Compile Time.
//Commonly associated with Method Overloading.


//Dynamic Binding:

//The method to be called is determined at Run Time.
//Happens with virtual/override methods.
//The actual object's type determines which overridden method runs.


//Q2 A

// What is the purpose of the sealed keyword when applied to a class?

//The sealed keyword prevents a class from being inherited by another class.


//Q2 B

// What is the difference between a sealed class and a sealed method?

//Sealed Class:

//Prevents other classes from inheriting from it.

//Sealed Method:

//Prevents a derived class from overriding that method again.

//Q2 C
// Can a sealed method be overridden? Why?

//No

//A sealed method cannot be overridden by another derived class because the
//sealed keyword prevents further overriding.