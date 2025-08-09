using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    internal class Ex_01
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car(){Cost=56,MaxSpeed=120},
                new Car(){Cost=70,MaxSpeed=150},
                new Car(){Cost=45,MaxSpeed=180},
                new Car(){Cost=32,MaxSpeed=200},
                new Car(){Cost=82,MaxSpeed=280},
            };

            var selected = from c in cars
                           where c.Cost <60
                           orderby c.Cost
                           select c;
            foreach (var car in selected)
            {
                Console.WriteLine($"{car.Cost} {car.MaxSpeed}");
            }
        }
    }
}
