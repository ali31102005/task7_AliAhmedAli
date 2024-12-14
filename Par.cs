using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Ahmed_Ali_7
{
    internal class Par
    {
        //Create a base class Parent with properties X and Y, and a constructor to initialize them.
        //Create a derived class Child with an additional property Z, and chain its constructor to the base class. 
        //Demonstrate constructor chaining by creating an instance of Child.
        public int X { get; set; } public int Y { get; set; }

        public Par(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        virtual public int Product()
        {
            return X * Y;
        }


        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
