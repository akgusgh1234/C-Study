using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter7
{
    class Myclass
    {
        public int Myfield1;
        public int Myfield2;

        public Myclass Deepcopy()
        {
            Myclass newCopy=new Myclass();
            newCopy.Myfield1 = this.Myfield1;
            newCopy.Myfield2 = this.Myfield2;
            return newCopy;
        }
    }
    internal class Deepcopy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow copy");
            {
                Myclass source = new Myclass();
                source.Myfield1 = 10;
                source.Myfield2 = 20;

                Myclass target = source;
                target.Myfield2 = 30;
                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");  
            }

            Console.WriteLine("Deep Copy");
            {
                Myclass source=new Myclass();
                source.Myfield1 = 10;
                source.Myfield2 = 20;
                Myclass target=source.Deepcopy();
                target.Myfield2 = 30;
                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
            }
        }
    }
}*/
