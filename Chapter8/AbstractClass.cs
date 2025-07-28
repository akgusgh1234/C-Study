using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    abstract class AbstractBase
    {
        protected void PrivateMethod()
        {
            Console.WriteLine("This is a private method in an abstract class.");
        }
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method in an abstract class.");
        }
        public abstract void AbstractMethod();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("This is an implementation of the abstract method.");
            PrivateMethod();
        }
    }
    class AbstractClass
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethod();
            obj.PublicMethod();
        }
    }
}
