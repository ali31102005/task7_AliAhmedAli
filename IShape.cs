using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Ahmed_Ali_7
{
    internal interface IShape
    {

        double Area { get; }

        void Draw();
        void PrintDetails()
        {
            Console.WriteLine("This is a shape");
        }
    }



    class Rectangle : IShape
    {

        public double Area { get; }

        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }


    class Circle: IShape
    {
        public double Area { get; }
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }


        public void PrintDetails()
        {
            Console.WriteLine("This is a Circle");
        }
    }
}
