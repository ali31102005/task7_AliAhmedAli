using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Ahmed_Ali_7
{
    internal class Car : IMovable
    {
        public int Id { get; }
        public string Brand { get; set; }
        public float Price { get; set; }

        public Car(int Id) : this(Id, "Kia", 500_000)
        {

        }

        public Car(int Id, string Brand, float Price)
        {
            this.Id = Id;
            this.Brand = Brand;
            this.Price = Price;
        }

        public Car(int Id, string Brand) : this(Id, Brand, 700_000)
        {
            
        }

        public Car()
        {

        }

        public void Move()
        {
            Console.WriteLine("Car is moved");
        }



    }
}
