using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Ahmed_Ali_7
{
    internal class Child : Par
    {

        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x,y)
        {
            this.Z = z;
        }



        //new public int Product()
        //{
        //    return base.Product() * Z;
        //}

        override public int Product()
        {
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

    }
}
