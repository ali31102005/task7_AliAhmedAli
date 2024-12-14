
using Ali_Ahmed_Ali_7;
using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ali_Ahmed_Ali_6
{



    class Program
    {



        public static void Main()
        {




            #region p1

            //Car c1 = new Car();
            //Car c2 = new Car(3110);
            //Car c3 = new Car(2005,"Kia");
            //Car c4 = new Car(179,"BMW",2_000_000);
            //fun();

            #endregion


            #region p2
            //Console.WriteLine(Calculator.Add(10, 20));
            //Console.WriteLine(Calculator.Add(11.5, 13.5));
            //Console.WriteLine(Calculator.Add(10, 20, 30));
            #endregion


            #region p3
            //Child ch = new Child(4, 5, 6);
            //Par p1 = new Par(10, 20);
            //Par p = new Child(1, 2, 3);

            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(ch.ToString());
            //output with new: 2
            // output with override: 6
            #endregion


            #region p4
            //Rectangle r = new Rectangle();
            //r.Draw();
            #endregion
            #region p5

            //Circle circle = new Circle();
            //circle.PrintDetails();

            #endregion


            #region p6

            //IMovable car = new Car();
            //car.Move();
            #endregion
            #region p7

            //MYFile file = new MYFile();
            //Console.Write("Enter string: ");
            //file.Write();
            //file.Read();

            #endregion



            //Why does defining a custom constructor suppress the default constructor in C#? 
            //because the compiler assumes you are taking full control of the initialization process.
            //To avoid ambiguity or invalid object states, the default constructor is not generated 
            //automatically—you must explicitly define it if needed.

            //How does method overloading improve code readability and reusability ?

            //Method overloading improves code readability by allowing multiple methods with the same name to handle different types or 
            //numbers of parameters, making the code more intuitive and easier to understand.It enhances reusability by enabling a single
            //method name to perform similar operations on different data types, reducing redundancy and promoting cleaner,
            //more maintainable code.


            //What is the purpose of constructor chaining in inheritance ?
            //to ensure that the constructors of all base classes are executed and each class initialize its own fields
            //and apply code reuse



            //How does new differ from override in method overriding?
            //new: the method call is based on reference type
            //override: the method call is based on object type and determined in run time(Late binding or dynamic binding)

            //Why is ToString() often overridden in custom classes? 
            //to customize the output and provide a meaningful readable string representation of an object

            //Why can't you create an instance of an interface directly? 
            //because an interface only defines a contract(method signatures) without any implementation.
            //It doesn't contain the actual code to execute, so the runtime can't instantiate it.
            //You must create a class or struct that implements the interface and provides the concrete implementation.

            //What are the benefits of default implementations in interfaces introduced in C# 8.0? 

            //Backward Compatibility: New methods can be added to interfaces without breaking existing implementations.
            //Code Reusability: Common functionality can be provided in the interface, reducing duplication.
            //Flexibility: Implementing classes can either use the default implementation or override it.
            //Simplified Maintenance: Reduces the need for creating new interface versions when adding methods.


            //Why is it useful to use an interface reference to access implementing class methods?  
            //it enables polymorphism and you can ref to any class implements this interface that make code reusable
            //and maintainable
            //How does C# overcome the limitation of single inheritance with interfaces?
            //by allowing multiple interface inheritance and one class can implement more than one interface



            //What is the difference between a virtual method and an abstract method in C#?
            //Virtual methods have default implementations and can be optionally overridden.
            //Abstract methods have no implementation and must be overridden in derived classes



            //Classes are reference types, support inheritance, and are heap-allocated and equality implements shallow copy
            //Structs are value types, do not support inheritance, and are stack-allocated,
            //making them more suitable for lightweight, small data structures and equality implements deep copy


            //If inheritance is relation between classes clarify other relations between classes

            //Association: One class uses or interacts with another.
            //Aggregation: One class contains another, but they can exist independently.
            //Composition: One class contains another, and they cannot exist independently.
            //Dependency : One class depends on another for its functionality.
            //Realization: A class implements an interface.
            //Abstraction: Hides implementation details and exposes essential features.




        }








    }




















}