using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter11
{
    class StructArray<T>where T : struct
    {
        public T[] Array {  get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T>where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size) { Array = new T[size]; }
    }
    class Base { }
    class Derived : Base { }
    class BasedArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BasedArray(int size) { Array = new U[size]; }
        public void CopyArray<T>( T []Source )where T : Base
        {
            Source.CopyTo( Array, 0 );
        }
    }
    
    internal class ConstrainsOnTypeparameters
    {
        public static T CreateInstance<T>()where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            RefArray<StructArray<double>> b=new RefArray<StructArray<double>>(3);
            b.Array[0]=new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            BasedArray<Base> c = new BasedArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BasedArray<Derived> d=new BasedArray<Derived> (3);
            d.Array[0]=new Derived();
            d.Array[1]=CreateInstance<Derived>();
            d.Array[2]=CreateInstance<Derived>();


        }
    }
}
*/